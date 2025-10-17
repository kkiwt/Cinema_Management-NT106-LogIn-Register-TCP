namespace Week4SampleCode
{
    partial class Client
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
            this.serverIPBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.serverIPLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.sendMsgBox = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.msgBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // serverIPBox
            // 
            this.serverIPBox.Location = new System.Drawing.Point(195, 44);
            this.serverIPBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serverIPBox.Name = "serverIPBox";
            this.serverIPBox.Size = new System.Drawing.Size(208, 31);
            this.serverIPBox.TabIndex = 0;
            this.serverIPBox.Text = "127.0.0.1";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(532, 44);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(187, 31);
            this.usernameBox.TabIndex = 1;
            // 
            // serverIPLabel
            // 
            this.serverIPLabel.AutoSize = true;
            this.serverIPLabel.Location = new System.Drawing.Point(18, 48);
            this.serverIPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serverIPLabel.Name = "serverIPLabel";
            this.serverIPLabel.Size = new System.Drawing.Size(169, 25);
            this.serverIPLabel.TabIndex = 2;
            this.serverIPLabel.Text = "IP remote server";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(414, 48);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(110, 25);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(18, 553);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(100, 25);
            this.messageLabel.TabIndex = 4;
            this.messageLabel.Text = "Message";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(768, 36);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(160, 50);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(975, 36);
            this.disconnectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(160, 50);
            this.disconnectButton.TabIndex = 6;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // sendMsgBox
            // 
            this.sendMsgBox.Location = new System.Drawing.Point(22, 584);
            this.sendMsgBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendMsgBox.Name = "sendMsgBox";
            this.sendMsgBox.Size = new System.Drawing.Size(920, 63);
            this.sendMsgBox.TabIndex = 8;
            this.sendMsgBox.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(988, 584);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(147, 66);
            this.sendButton.TabIndex = 9;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // msgBox
            // 
            this.msgBox.Location = new System.Drawing.Point(22, 95);
            this.msgBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(1158, 421);
            this.msgBox.TabIndex = 10;
            this.msgBox.Text = "";
            // 
            // Bai4_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.sendMsgBox);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.serverIPLabel);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.serverIPBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Bai4_Client";
            this.Text = "Bai4_Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverIPBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label serverIPLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.RichTextBox sendMsgBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.RichTextBox msgBox;
    }
    
}