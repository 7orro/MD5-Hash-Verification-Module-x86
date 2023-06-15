using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace MD5_Hash_Verification_Module_x86
{
    public partial class MD5HashVerificationModule : Form
    {
        private bool isDragging;
        private int xOffset;
        private int yOffset;
        private bool isMessageBoxDisplayed;
        private Timer blinkTimer;
        private int blinkCounter;

        public MD5HashVerificationModule()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Red;
            this.MouseDown += MD5HashVerificationModule_MouseDown;
            this.MouseMove += MD5HashVerificationModule_MouseMove;
            this.MouseUp += MD5HashVerificationModule_MouseUp;
            this.DragEnter += MD5HashVerificationModule_DragEnter;
            this.DragDrop += MD5HashVerificationModule_DragDrop;

            blinkTimer = new Timer();
            blinkTimer.Interval = 500;
            blinkTimer.Tick += BlinkTimer_Tick;
        }

        private void MD5HashVerificationModule_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            xOffset = e.X;
            yOffset = e.Y;
        }

        private void MD5HashVerificationModule_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left = e.X + this.Left - xOffset;
                this.Top = e.Y + this.Top - yOffset;
            }
        }

        private void MD5HashVerificationModule_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void MD5HashVerificationModule_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void MD5HashVerificationModule_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                string path = files[0];

                if (File.Exists(path))
                {
                    try
                    {
                        using (var md5 = MD5.Create())
                        {
                            using (var stream = File.OpenRead(path))
                            {
                                byte[] hash = md5.ComputeHash(stream);
                                string hashString = BitConverter.ToString(hash).Replace("-", "").ToLower();

                                labelActualHash.Text = hashString;

                                Clipboard.SetText(hashString);

                                StartBlinkTimer();
                            }
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error reading the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Directory.Exists(path) && !isMessageBoxDisplayed)
                {
                    MessageBox.Show("No, you idiot! Folders have no MD5 hash!", "Invalid Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isMessageBoxDisplayed = true;
                }
            }
        }

        private void PictureBoxClose_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxClose.Image = MD5_Hash_Verification_Module_x86.Properties.Resources.close_active;
        }

        private void PictureBoxClose_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxClose.Image = MD5_Hash_Verification_Module_x86.Properties.Resources.close_inactive;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartBlinkTimer()
        {
            blinkCounter = 0;
            labelToClipMsg.Visible = true;
            blinkTimer.Start();
        }

        private void BlinkTimer_Tick(object sender, EventArgs e)
        {
            blinkCounter++;

            if (blinkCounter <= 10)
            {
                labelToClipMsg.Visible = !labelToClipMsg.Visible;
            }
            else
            {
                blinkTimer.Stop();
                labelToClipMsg.Visible = false;
            }
        }
    }
}
