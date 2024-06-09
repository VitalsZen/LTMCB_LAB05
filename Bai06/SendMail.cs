using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Windows.Forms;

namespace Bai06
{
    public partial class SendMail : Form
    {
        private string email;
        private string password;
        private string smtpServer;
        private int smtpPort;
        bool IsReply = false;
        public SendMail(string email, string password, string smtpServer, int smtpPort)
        {
            InitializeComponent();
            this.email = email;
            this.password = password;
            this.smtpServer = smtpServer;
            this.smtpPort = 465; // sử dụng port 465 thay vì 587 
            //  bị lỗi MailKit.Security.SslHandshakeException: 
            // 'An error occurred while attempting to establish an SSL or TLS connection
            tbFrom.Text = email;
        }

        public SendMail(string email, string password, string mailrep, string smtpServer, string SubjectRep)
        {
            InitializeComponent();
            this.email = email;
            this.password = password;
            tbTo.Text = mailrep;
            this.smtpServer = smtpServer;
            this.smtpPort = 465; 

            tbFrom.Text = email;
            tbBody.Text += @$"Đây là mail trả lời cho mail có chủ đề ""{SubjectRep}""  " + "\n";
            string separatorLine = new string('-', tbBody.Width / (int)tbBody.Font.SizeInPoints);

            //Thêm dòng trên vào tbBody
            tbBody.AppendText(separatorLine + Environment.NewLine);
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(tbName.Text, tbFrom.Text));
            message.To.Add(new MailboxAddress("", tbTo.Text));
            message.Subject = tbSubject.Text;

            var bodyBuilder = new BodyBuilder();
            if (chkHtml.Checked) // phân biệt Body HTML 
            {
                bodyBuilder.HtmlBody = tbBody.Text;
                smtpPort = 465;
            }
            else
            {
                bodyBuilder.TextBody = tbBody.Text;
            }

            if (!string.IsNullOrEmpty(tbAttachment.Text))
            {
                bodyBuilder.Attachments.Add(tbAttachment.Text);
            }

            message.Body = bodyBuilder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                client.Connect(smtpServer,465, true);
                client.Authenticate(email, password);
                client.Send(message);
                client.Disconnect(true);
            }

            MessageBox.Show("Email gửi thành công !");
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    tbAttachment.Text = dialog.FileName;
                }
            }
        }
    }
}
