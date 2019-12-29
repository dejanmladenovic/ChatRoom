namespace ChatAppForm
{
    partial class OnlineUser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUserName = new System.Windows.Forms.Label();
            this.soundIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.soundIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUserName.Location = new System.Drawing.Point(38, 13);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(75, 21);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "John Doe";
            // 
            // soundIcon
            // 
            this.soundIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.soundIcon.Image = global::ChatAppForm.Properties.Resources.sound;
            this.soundIcon.Location = new System.Drawing.Point(3, 11);
            this.soundIcon.Name = "soundIcon";
            this.soundIcon.Size = new System.Drawing.Size(25, 24);
            this.soundIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.soundIcon.TabIndex = 2;
            this.soundIcon.TabStop = false;
            this.soundIcon.Click += new System.EventHandler(this.soundIcon_Click);
            // 
            // OnlineUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.soundIcon);
            this.Controls.Add(this.lblUserName);
            this.Name = "OnlineUser";
            this.Size = new System.Drawing.Size(163, 47);
            ((System.ComponentModel.ISupportInitialize)(this.soundIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox soundIcon;
    }
}
