namespace MD5_Hash_Verification_Module_x86
{
    partial class MD5HashVerificationModule
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MD5HashVerificationModule));
            this.labelMD5hash = new System.Windows.Forms.Label();
            this.labelActualHash = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.labelToClipMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMD5hash
            // 
            this.labelMD5hash.AutoSize = true;
            this.labelMD5hash.BackColor = System.Drawing.Color.Transparent;
            this.labelMD5hash.Location = new System.Drawing.Point(349, 113);
            this.labelMD5hash.Name = "labelMD5hash";
            this.labelMD5hash.Size = new System.Drawing.Size(59, 13);
            this.labelMD5hash.TabIndex = 0;
            this.labelMD5hash.Text = "MD5 hash:";
            // 
            // labelActualHash
            // 
            this.labelActualHash.AutoSize = true;
            this.labelActualHash.BackColor = System.Drawing.Color.Transparent;
            this.labelActualHash.Font = new System.Drawing.Font("Unispace", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActualHash.Location = new System.Drawing.Point(349, 139);
            this.labelActualHash.Name = "labelActualHash";
            this.labelActualHash.Size = new System.Drawing.Size(0, 15);
            this.labelActualHash.TabIndex = 1;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxClose.Image = global::MD5_Hash_Verification_Module_x86.Properties.Resources.close_inactive;
            this.pictureBoxClose.Location = new System.Drawing.Point(99, 4);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxClose.TabIndex = 2;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            this.pictureBoxClose.MouseEnter += new System.EventHandler(this.PictureBoxClose_MouseEnter);
            this.pictureBoxClose.MouseLeave += new System.EventHandler(this.PictureBoxClose_MouseLeave);
            // 
            // labelToClipMsg
            // 
            this.labelToClipMsg.AutoSize = true;
            this.labelToClipMsg.BackColor = System.Drawing.Color.Transparent;
            this.labelToClipMsg.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToClipMsg.Location = new System.Drawing.Point(367, 174);
            this.labelToClipMsg.Name = "labelToClipMsg";
            this.labelToClipMsg.Size = new System.Drawing.Size(231, 14);
            this.labelToClipMsg.TabIndex = 3;
            this.labelToClipMsg.Text = "MD5 hash was copied to clipboard";
            this.labelToClipMsg.Visible = false;
            // 
            // MD5HashVerificationModule
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = global::MD5_Hash_Verification_Module_x86.Properties.Resources.md5hash_hud;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(636, 237);
            this.Controls.Add(this.labelToClipMsg);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.labelActualHash);
            this.Controls.Add(this.labelMD5hash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(636, 237);
            this.MinimumSize = new System.Drawing.Size(636, 237);
            this.Name = "MD5HashVerificationModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MD5 FileHash VM x86";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MD5HashVerificationModule_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MD5HashVerificationModule_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMD5hash;
        private System.Windows.Forms.Label labelActualHash;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label labelToClipMsg;
    }
}

