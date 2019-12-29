namespace ChatAppForm
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.onlineBox = new ChatAppForm.OnlineBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chatBox = new ChatAppForm.ChatBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.panel2.Controls.Add(this.onlineBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 912);
            this.panel2.TabIndex = 1;
            // 
            // onlineBox
            // 
            this.onlineBox.Location = new System.Drawing.Point(0, 5);
            this.onlineBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.onlineBox.Name = "onlineBox";
            this.onlineBox.Size = new System.Drawing.Size(294, 889);
            this.onlineBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(303, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(933, 912);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Controls.Add(this.chatBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(933, 807);
            this.panel4.TabIndex = 1;
            // 
            // chatBox
            // 
            this.chatBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatBox.AutoScroll = true;
            this.chatBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.chatBox.Location = new System.Drawing.Point(9, 5);
            this.chatBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(920, 0);
            this.chatBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSendMessage);
            this.panel1.Controls.Add(this.messageBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 807);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 105);
            this.panel1.TabIndex = 0;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSendMessage.Location = new System.Drawing.Point(836, 5);
            this.btnSendMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(93, 95);
            this.btnSendMessage.TabIndex = 1;
            this.btnSendMessage.Text = "Posalji";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // messageBox
            // 
            this.messageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageBox.BackColor = System.Drawing.Color.White;
            this.messageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.messageBox.Location = new System.Drawing.Point(9, 12);
            this.messageBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(818, 78);
            this.messageBox.TabIndex = 0;
            this.messageBox.Text = "Unesite poruku...";
            this.messageBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.messageBox_MouseClick);
            this.messageBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.messageBox_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 912);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private ChatBox chatBox;
        private System.Windows.Forms.Button btnSendMessage;
        private OnlineBox onlineBox;
    }
}

