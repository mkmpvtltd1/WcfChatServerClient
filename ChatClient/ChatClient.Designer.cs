namespace ChatClient
{
    partial class ChatClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.grpUserCredentials = new System.Windows.Forms.GroupBox();
            this.grpUserList = new System.Windows.Forms.GroupBox();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.grpMessageWindow = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSendMessage = new System.Windows.Forms.TextBox();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.grpUserCredentials.SuspendLayout();
            this.grpUserList.SuspendLayout();
            this.grpMessageWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LoginName";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(117, 26);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(112, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(282, 26);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // grpUserCredentials
            // 
            this.grpUserCredentials.Controls.Add(this.label1);
            this.grpUserCredentials.Controls.Add(this.btnLogin);
            this.grpUserCredentials.Controls.Add(this.txtUserName);
            this.grpUserCredentials.Location = new System.Drawing.Point(12, 12);
            this.grpUserCredentials.Name = "grpUserCredentials";
            this.grpUserCredentials.Size = new System.Drawing.Size(397, 55);
            this.grpUserCredentials.TabIndex = 3;
            this.grpUserCredentials.TabStop = false;
            this.grpUserCredentials.Text = "UserCredentials";
            // 
            // grpUserList
            // 
            this.grpUserList.Controls.Add(this.lstUsers);
            this.grpUserList.Location = new System.Drawing.Point(499, 22);
            this.grpUserList.Name = "grpUserList";
            this.grpUserList.Size = new System.Drawing.Size(127, 342);
            this.grpUserList.TabIndex = 4;
            this.grpUserList.TabStop = false;
            this.grpUserList.Text = "UserOnline";
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(6, 28);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(115, 290);
            this.lstUsers.TabIndex = 0;
            // 
            // grpMessageWindow
            // 
            this.grpMessageWindow.Controls.Add(this.btnSend);
            this.grpMessageWindow.Controls.Add(this.txtSendMessage);
            this.grpMessageWindow.Controls.Add(this.rtbMessages);
            this.grpMessageWindow.Location = new System.Drawing.Point(21, 117);
            this.grpMessageWindow.Name = "grpMessageWindow";
            this.grpMessageWindow.Size = new System.Drawing.Size(436, 310);
            this.grpMessageWindow.TabIndex = 5;
            this.grpMessageWindow.TabStop = false;
            this.grpMessageWindow.Text = "MessageWindow";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(353, 265);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click+=btnSend_Click;
            // 
            // txtSendMessage
            // 
            this.txtSendMessage.Location = new System.Drawing.Point(6, 265);
            this.txtSendMessage.Name = "txtSendMessage";
            this.txtSendMessage.Size = new System.Drawing.Size(303, 20);
            this.txtSendMessage.TabIndex = 1;
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(6, 19);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.Size = new System.Drawing.Size(390, 204);
            this.rtbMessages.TabIndex = 0;
            this.rtbMessages.Text = "";
            // 
            // ChatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 453);
            this.Controls.Add(this.grpMessageWindow);
            this.Controls.Add(this.grpUserList);
            this.Controls.Add(this.grpUserCredentials);
            this.Name = "ChatClient";
            this.Text = "Client";
            this.grpUserCredentials.ResumeLayout(false);
            this.grpUserCredentials.PerformLayout();
            this.grpUserList.ResumeLayout(false);
            this.grpMessageWindow.ResumeLayout(false);
            this.grpMessageWindow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox grpUserCredentials;
        private System.Windows.Forms.GroupBox grpUserList;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.GroupBox grpMessageWindow;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSendMessage;
    }
}

