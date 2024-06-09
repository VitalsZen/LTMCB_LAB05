using System;
using System.Linq;
using System.Windows.Forms;
using MailKit.Net.Pop3;
using MimeKit;

namespace Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dtgvInfo.Columns.Add("Subject", "Subject"); 
            dtgvInfo.Columns.Add("From", "From"); 
            dtgvInfo.Columns.Add("Content", "Content");
            dtgvInfo.Columns.Add("Date Received", "Date Received"); 
            tbPassword.Text = "yfdo ntzm dxne dkze"; 
            tbEmail.Text = "phtkhang1502@gmail.com"; 
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            string hostname = "pop.gmail.com"; 
            int port = 995; 
            string email = tbEmail.Text;
            string password = tbPassword.Text; 

            try
            {
                using (var client = new Pop3Client())
                {
                    client.Connect(hostname, port, true); 
                    client.Authenticate(email, password); 

                    int messageCount = client.Count; 
                    lbCountTotal.Text = messageCount.ToString(); // Hiển thị tổng số email

                    dtgvInfo.Rows.Clear(); // Xóa dữ liệu cũ trong DataGridView

                    // Lặp qua từng email và hiển thị thông tin
                    for (int i = 0; i < messageCount; i++)
                    {
                        var message = client.GetMessage(i);
                        var subject = message.Subject;

                        // Lấy người gửi email
                        var from = string.Join(", ", message.From.Select(f => ((MailboxAddress)f).Address));

                        // Lấy nội dung email hoặc thông báo nếu không có văn bản thuần
                        var body = message.TextBody ?? "[No Plain Text]"; 
                        var dateReceived = message.Date.ToString(); 

                        dtgvInfo.Rows.Add(subject, from, body, dateReceived);
                    }

                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
