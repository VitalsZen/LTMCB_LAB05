using System;
using System.Windows.Forms;

namespace Bai06
{
    partial class MenuMail
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            tbImapServer = new TextBox();
            tbImapPort = new TextBox();
            tbSmtpServer = new TextBox();
            tbSmtpPort = new TextBox();
            btLogin = new Button();
            listViewEmails = new ListView();
            btRefresh = new Button();
            btSendMail = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            progressBar1 = new ProgressBar();
            btLogout = new Button();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(116, 45);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(296, 27);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(116, 83);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(296, 27);
            txtPassword.TabIndex = 1;
            // 
            // tbImapServer
            // 
            tbImapServer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbImapServer.BorderStyle = BorderStyle.FixedSingle;
            tbImapServer.Location = new Point(600, 49);
            tbImapServer.Name = "tbImapServer";
            tbImapServer.Size = new Size(263, 27);
            tbImapServer.TabIndex = 2;
            // 
            // tbImapPort
            // 
            tbImapPort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbImapPort.BorderStyle = BorderStyle.FixedSingle;
            tbImapPort.Location = new Point(887, 49);
            tbImapPort.Name = "tbImapPort";
            tbImapPort.Size = new Size(50, 27);
            tbImapPort.TabIndex = 3;
            tbImapPort.TextAlign = HorizontalAlignment.Center;
            // 
            // tbSmtpServer
            // 
            tbSmtpServer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbSmtpServer.BorderStyle = BorderStyle.FixedSingle;
            tbSmtpServer.Location = new Point(600, 87);
            tbSmtpServer.Name = "tbSmtpServer";
            tbSmtpServer.Size = new Size(263, 27);
            tbSmtpServer.TabIndex = 4;
            // 
            // tbSmtpPort
            // 
            tbSmtpPort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbSmtpPort.BorderStyle = BorderStyle.FixedSingle;
            tbSmtpPort.Location = new Point(887, 87);
            tbSmtpPort.Name = "tbSmtpPort";
            tbSmtpPort.Size = new Size(50, 27);
            tbSmtpPort.TabIndex = 5;
            tbSmtpPort.TextAlign = HorizontalAlignment.Center;
            // 
            // btLogin
            // 
            btLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btLogin.Location = new Point(855, 130);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(100, 46);
            btLogin.TabIndex = 6;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btnLogin_Click;
            // 
            // listViewEmails
            // 
            listViewEmails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewEmails.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewEmails.FullRowSelect = true;
            listViewEmails.GridLines = true;
            listViewEmails.Location = new Point(12, 130);
            listViewEmails.Name = "listViewEmails";
            listViewEmails.Size = new Size(837, 325);
            listViewEmails.TabIndex = 7;
            listViewEmails.UseCompatibleStateImageBehavior = false;
            listViewEmails.View = View.Details;
            listViewEmails.DoubleClick += listViewEmails_DoubleClick;
            // 
            // btRefresh
            // 
            btRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btRefresh.Location = new Point(855, 182);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(100, 46);
            btRefresh.TabIndex = 8;
            btRefresh.Text = "Refresh";
            btRefresh.UseVisualStyleBackColor = true;
            btRefresh.Click += btnRefresh_Click;
            // 
            // btSendMail
            // 
            btSendMail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btSendMail.Location = new Point(855, 234);
            btSendMail.Name = "btSendMail";
            btSendMail.Size = new Size(100, 46);
            btSendMail.TabIndex = 9;
            btSendMail.Text = "Send Mail";
            btSendMail.UseVisualStyleBackColor = true;
            btSendMail.Click += btnSendMail_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 49);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 10;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 83);
            label2.Name = "label2";
            label2.Size = new Size(42, 23);
            label2.TabIndex = 11;
            label2.Text = "Pass";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(528, 53);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 12;
            label3.Text = "IMAP";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(528, 87);
            label4.Name = "label4";
            label4.Size = new Size(53, 23);
            label4.TabIndex = 13;
            label4.Text = "SMTP";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(443, 97);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(480, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(475, 97);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 18);
            label5.Name = "label5";
            label5.Size = new Size(92, 23);
            label5.TabIndex = 16;
            label5.Text = "Login Info";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(510, 18);
            label6.Name = "label6";
            label6.Size = new Size(69, 23);
            label6.TabIndex = 17;
            label6.Text = "Setting";
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.Location = new Point(12, 461);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(837, 17);
            progressBar1.TabIndex = 18;
            // 
            // btLogout
            // 
            btLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btLogout.Location = new Point(855, 286);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(100, 46);
            btLogout.TabIndex = 19;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = true;
            btLogout.Click += btLogout_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mail From";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Subject";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Content";
            columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Date Received";
            columnHeader4.Width = 137;
            // 
            // MenuMail
            // 
            ClientSize = new Size(967, 482);
            Controls.Add(btLogout);
            Controls.Add(progressBar1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btSendMail);
            Controls.Add(btRefresh);
            Controls.Add(listViewEmails);
            Controls.Add(btLogin);
            Controls.Add(tbSmtpPort);
            Controls.Add(tbSmtpServer);
            Controls.Add(tbImapPort);
            Controls.Add(tbImapServer);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "MenuMail";
            Text = "Email Client";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox tbImapServer;
        private System.Windows.Forms.TextBox tbImapPort;
        private System.Windows.Forms.TextBox tbSmtpServer;
        private System.Windows.Forms.TextBox tbSmtpPort;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.ListView listViewEmails;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btSendMail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label6;
        private ProgressBar progressBar1;
        private Button btLogout;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}
