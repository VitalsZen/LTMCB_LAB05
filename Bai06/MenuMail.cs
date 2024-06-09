using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System;
using System.Windows.Forms;
using Bai06;

namespace Bai06
{
    public partial class MenuMail : Form
    {
        private ImapClient imapClient; 
        private SmtpClient smtpClient; 
        private string email; 
        private string password; 

        public MenuMail()
        {
            InitializeComponent();
            // Thiết lập giá trị mặc định cho các trường máy chủ và cổng
            tbImapPort.Text = "993";
            tbImapServer.Text = "imap.gmail.com";
            tbSmtpPort.Text = "587";
            tbSmtpServer.Text = "smtp.gmail.com";
            txtPassword.Text = "tsaq jqjs sgkr snkn";
            txtEmail.Text = "phtkhang1502@gmail.com";

            LoginDisabled(); // Vô hiệu hóa các nút khi chưa đăng nhập
        }

        private void LoginEnabled()
        {
            // Kích hoạt các nút khi đăng nhập thành công
            btRefresh.Enabled = true;
            btSendMail.Enabled = true;
            btLogout.Enabled = true;
        }

        private void LoginDisabled()
        {
            // Vô hiệu hóa các nút khi chưa đăng nhập
            btRefresh.Enabled = false;
            btSendMail.Enabled = false;
            btLogout.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            email = txtEmail.Text;
            password = txtPassword.Text;

            try
            {
                // Khởi tạo ImapClient và kết nối tới máy chủ IMAP
                imapClient = new ImapClient();
                imapClient.Connect(tbImapServer.Text, Convert.ToInt32(tbImapPort.Text), true);
                imapClient.Authenticate(email, password);
                LoadEmails(); // Tải email

                LoginEnabled(); // Kích hoạt các nút sau khi đăng nhập thành công

                MessageBox.Show("Đăng nhập thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đăng nhập gặp trục trặc: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEmails()
        {
            try
            {
                var inbox = imapClient.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                listViewEmails.Items.Clear();

                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);
                    var item = new ListViewItem(new[]
                    {
                        message.From.ToString(),
                        message.Subject,
                        GetMessageContent(message),
                        message.Date.ToString()
                    });
                    listViewEmails.Items.Add(item);
                    progressBar1.Maximum = inbox.Count - 1;
                    Invoke(new Action(() => progressBar1.Value = i));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load emails: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEmails(); // Tải lại email khi nhấn nút Refresh
        }
        private void btnSendMail_Click(object sender, EventArgs e)
        {
            var form2 = new SendMail(email, password, tbSmtpServer.Text, Convert.ToInt32(tbSmtpPort.Text));
            form2.Show();
        }

        private void listViewEmails_DoubleClick(object sender, EventArgs e)
        {
            if (listViewEmails.SelectedItems.Count > 0)
            {
                var index = listViewEmails.SelectedItems[0].Index;
                var message = imapClient.Inbox.GetMessage(index);

                var form3 = new ViewMail(email, password, tbSmtpServer.Text, Convert.ToInt32(tbSmtpPort.Text), message);
                form3.Show();
            }
        }

       

        private string GetMessageContent(MimeMessage message)
        {
            var textBody = message.TextBody ?? "";
            var htmlBody = message.HtmlBody ?? "";

            return !string.IsNullOrEmpty(textBody) ? textBody : htmlBody;
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            try
            {
                if (imapClient?.IsConnected == true)
                {
                    imapClient.Disconnect(true); // Ngắt kết nối ImapClient
                    imapClient.Dispose();
                }

                if (smtpClient?.IsConnected == true)
                {
                    smtpClient.Disconnect(true); // Ngắt kết nối SmtpClient
                    smtpClient.Dispose();
                }

                email = string.Empty;
                password = string.Empty;
                listViewEmails.Items.Clear();
                progressBar1.Value = 0;

                LoginDisabled(); // Vô hiệu hóa các nút sau khi đăng xuất

                MessageBox.Show("Đăng xuất thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đăng xuất gặp trục trặc: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
