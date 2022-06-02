
namespace formjdrppe
{
    partial class chat
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
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSending = new System.Windows.Forms.RichTextBox();
            this.listBoxMessage = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxIp
            // 
            this.textBoxIp.Location = new System.Drawing.Point(53, 29);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(274, 20);
            this.textBoxIp.TabIndex = 1;
            this.textBoxIp.Text = "10.1.1.91";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSending
            // 
            this.textBoxSending.Location = new System.Drawing.Point(53, 315);
            this.textBoxSending.Name = "textBoxSending";
            this.textBoxSending.Size = new System.Drawing.Size(274, 55);
            this.textBoxSending.TabIndex = 3;
            this.textBoxSending.Text = "";
            this.textBoxSending.TextChanged += new System.EventHandler(this.textBoxSending_TextChanged);
            // 
            // listBoxMessage
            // 
            this.listBoxMessage.FormattingEnabled = true;
            this.listBoxMessage.Location = new System.Drawing.Point(53, 64);
            this.listBoxMessage.Name = "listBoxMessage";
            this.listBoxMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxMessage.Size = new System.Drawing.Size(274, 251);
            this.listBoxMessage.TabIndex = 4;
            // 
            // chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.listBoxMessage);
            this.Controls.Add(this.textBoxSending);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxIp);
            this.Name = "chat";
            this.Text = "chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.chat_FormClosing);
            this.Load += new System.EventHandler(this.chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox textBoxSending;
        public System.Windows.Forms.ListBox listBoxMessage;
    }
}