using MimeKit;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bai06
{
    public partial class ViewMail : Form
    {
        string Email;
        string Pass;
        string Smtpserver;
        int Smtpport;

        public ViewMail(string email, string password, string smtpServer, int smtpPort , MimeMessage message)
        {
            InitializeComponent();

            Email = email;
            Pass = password;
            Smtpserver =  smtpServer;
            Smtpport = smtpPort;


            tbFrom.Text = message.From.ToString();
            tbTo.Text = message.To.ToString();
            tbSubject.Text = message.Subject;
            tbBody.Text = message.TextBody;

        }

        private void btReply_Click(object sender, EventArgs e) // Mở form SendMail.cs 
        {
            string input = tbFrom.Text;
            string extractedmail = ExtractEmail(input);
            var form =  new SendMail(Email, Pass,  extractedmail, Smtpserver, tbSubject.Text );
            form.Show();
        }

        private string ExtractEmail(string input) // triết xuất mail từ format ( Tên <Mail>)
        {
            string pattern = @"<([^>]+)>";

            Match match = Regex.Match(input, pattern);

            if (match.Success)
            {
                return match.Groups[1].Value;
            }

            return null;
        }
    }
}
