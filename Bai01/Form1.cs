using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            string fromAddress = tbFrom.Text;
            string toAddress = tbTo.Text;
            string subject = tbSubject.Text;
            string body = rtbBody.Text;

            try
            {
                using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
                {
                    client.EnableSsl = true;

                    // Kết nối an toàn
                    string email = "tkhang1522004@gmail.com"; 
                    string password = "yerm vvbp lvtv ncue"; 

                    client.Credentials = new NetworkCredential(email, password);

                    using (MailMessage mailMessage = new MailMessage(fromAddress, toAddress, subject, body))
                    {
                        client.Send(mailMessage);
                    }
                }

                MessageBox.Show("Email gửi thành công");
            }
            catch (SmtpException ex)
            {
                MessageBox.Show($"SMTP lỗi: {ex.StatusCode} - {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
    }
}
