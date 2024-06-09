using System;
using System.Linq;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit;
using MimeKit;

namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
            tbEmail.Text = "phtkhang1502@gmail.com";
            tbPassword.Text = "tsaq jqjs sgkr snkn";
        }

        private void InitializeDataGridView()
        {
            dtgvInfo.ColumnCount = 4;
            dtgvInfo.Columns[0].Name = "Subject";
            dtgvInfo.Columns[1].Name = "Mail From";
            dtgvInfo.Columns[2].Name = "Content";
            dtgvInfo.Columns[3].Name = "Time Received";
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPassword.Text;

            try
            {
                using (var client = new ImapClient())
                {
                    client.Connect("imap.gmail.com", 993, true); 
                    client.Authenticate(email, password);

                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    dtgvInfo.Rows.Clear();

                    int limit = inbox.Count > 50 ? 50 : inbox.Count; // Giới hạn 50 mail gần nhất

                    for (int i = 0; i < limit; i++)
                    {
                        var message = inbox.GetMessage(i);
                        dtgvInfo.Rows.Add(message.Subject, message.From.ToString(), message.TextBody, message.Date.LocalDateTime);
                    }

                    lbCountTotal.Text = limit.ToString();

                    client.Disconnect(true);
                }

                MessageBox.Show("Đăng nhập và triết xuất email thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
    }
}
