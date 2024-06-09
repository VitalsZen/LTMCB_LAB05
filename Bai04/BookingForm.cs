using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net;

namespace Bai04
{
    public partial class BookingForm : Form
    {
        List<CPhim> Phims = new List<CPhim>();
        static CPhim SelectedPhim = new CPhim();
        static CPhim.CPhong SelectedPhong = new CPhim.CPhong();
        public BookingForm()
        {
            InitializeComponent();
            try
            {
                Phims = DeserializeJson("input5.txt");
                foreach (var Phim in Phims)
                {
                    cb2_Movie.Items.Add(Phim.TenPhim);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private List<CPhim> DeserializeJson(string Filepath)
        {
            string json = File.ReadAllText(Filepath);
            List<CPhim> Phims = JsonSerializer.Deserialize<List<CPhim>>(json);
            return Phims;
        }

        private void SerializeJson(object obj, string Filepath)
        {
            string json = JsonSerializer.Serialize(obj);
            File.WriteAllText(Filepath, json);
        }

        private void cb2_Movie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cb1_Theater.Items.Clear();
            if (cb2_Movie.SelectedItem != null)
            {
                foreach (CPhim Phim in Phims)
                {
                    if (Phim.TenPhim == cb2_Movie.SelectedItem.ToString())
                    {
                        //MessageBox.Show("1");
                        SelectedPhim = Phim;
                        break;
                    }
                }

                if (SelectedPhim != null && SelectedPhim.Phong != null)
                {
                    //MessageBox.Show("2"); 
                    foreach (CPhim.CPhong phong in SelectedPhim.Phong)
                    {
                        cb1_Theater.Items.Add(phong.TenPhong);
                    }
                }
                cb1_Theater.Enabled = true;
            }
        }

        private void cb1_Theater_SelectionChangeCommitted(object sender, EventArgs e)
        {
            clb1_Seats.Items.Clear();
            if (cb1_Theater.SelectedItem != null && SelectedPhim != null && SelectedPhim.Phong != null)
            {
                //MessageBox.Show("3"); ;
                foreach (CPhim.CPhong c in SelectedPhim.Phong)
                {
                    if (c.TenPhong == cb1_Theater.SelectedItem.ToString())
                    {
                        //MessageBox.Show("4"); ;
                        SelectedPhong = c;
                        break;
                    }
                }

                if (SelectedPhong.suat != null)
                {
                    clb1_Seats.Items.AddRange(SelectedPhong.suat);
                }
            }

        }

        private void clb1_Seats_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (clb1_Seats.CheckedItems.Count == 1)
            {
                if (e.NewValue == CheckState.Unchecked)
                    bt1_Confirm.Enabled = false;
            }
            else
                bt1_Confirm.Enabled = true;
        }

        private void bt1_Confirm_Click(object sender, EventArgs e)
        {
            long tong = 0; // tinh tổng tiền từ checked seats
            long cost = SelectedPhim.GiaVe;
            foreach (string c in clb1_Seats.CheckedItems)
            {
                if (new[] { "A1", "A5", "B1", "B5", "C1", "C5" }.Contains(c))
                {
                    tong += cost * 1 / 4;
                }
                else if (new[] { "A2", "A3", "A4", "C2", "C3", "C4" }.Contains(c))
                {
                    tong += cost * 1;
                }
                else
                {
                    tong += cost * 2;
                }
            }
            string s = "Ho va ten: " + tb1_Name.Text;
            s += System.Environment.NewLine + "Các vé đã chọn: ";
            foreach (string c in clb1_Seats.CheckedItems)
                s += c + " ";
            s += System.Environment.NewLine;
            s += "Phòng chiếu: " + cb1_Theater.Text;
            s += System.Environment.NewLine;
            s += "Số tiền phải trả: " + tong.ToString();


            if (MessageBox.Show(s, "Warning !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) // thông báo lần cuối chắc chắn hay ko ? 
            {
                return;
            }
            else
            {
                MessageBox.Show("Bạn đã đặt vé thành công.", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SelectedPhim.TongTien += tong;
                HashSet<string> temp = SelectedPhong.suat.ToHashSet();
                foreach (string c in clb1_Seats.CheckedItems)
                {
                    temp.Remove(c);
                }
                SelectedPhong.suat = temp.ToArray();
                foreach (var c in SelectedPhim.Phong)
                {
                    if (c.TenPhong == SelectedPhong.TenPhong)
                    {
                        SelectedPhim.Phong.Remove(c);
                        SelectedPhim.Phong.Add(SelectedPhong);
                        break;
                    }
                }
                foreach (var c in Phims)
                {
                    if (SelectedPhim.TenPhim == c.TenPhim)
                    {
                        Phims.Remove(c);
                        Phims.Add(SelectedPhim);
                        break;
                    }
                }
                SerializeJson(Phims, "output5.txt");

                SendConfirmationEmail(tong);
                // blank các ô -> đẹp
                tb1_Name.Text = "";
                cb2_Movie.Text = "";
                cb1_Theater.Text = "";
                cb1_Theater.Enabled = false;
                SelectedPhim = null;
                SelectedPhong = new CPhim.CPhong();
                cb1_Theater.Items.Clear();
                clb1_Seats.Items.Clear();
            }
        }

        private void SendConfirmationEmail(long totalCost)
        {
            string base64image = ConvertImageToBase64(@$"{SelectedPhim.ImageUrl}"); // Chuyển đổi hình ảnh thành chuỗi base64
            string emailContent = $@"
                    <html>
            <head>
                <style>
                    body {{
                        background-image: url('data:image/png;base64,{base64image}');
                        background-size: cover;
                        background-repeat: no-repeat;
                        font-family: Arial, sans-serif;
                        color: black;
                    }}
                    .container {{
                        max-width: 600px;
                        margin: auto;
                        padding: 20px;
                    }}
                </style>
            </head>
            <body>
                <div class='container'>
                    <h2>Chào {tb1_Name.Text},</h2>
                    <p>Bạn đã đặt vé thành công cho bộ phim <strong>{SelectedPhim.TenPhim}</strong> tại phòng chiếu <strong>{cb1_Theater.Text}</strong>.</p>
                    <p>Dưới đây là chi tiết đặt vé của bạn:</p>
                    <ul>
                        <li>Số ghế: {string.Join(", ", clb1_Seats.CheckedItems.Cast<string>())}</li>
                        <li>Tổng tiền: {totalCost.ToString("N0")} VND</li>
                    </ul>
                    <p>Chúc bạn có một trải nghiệm xem phim vui vẻ!</p>
                    <p>Trân trọng,</p>
                    <p>Rạp chiếu phim KhanBanZai</p>
                </div>
            </body>
            </html>";

            string fromAddress = "phtkhang1502@gmail.com";
            string toAddress = tb2_Mail.Text;
            string subject = "Booking Info";
            string body = emailContent;

            try
            {
                using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
                {
                    client.EnableSsl = true; // Kích hoạt SSL

                    string email = "phtkhang1502@gmail.com";
                    string password = "apfs cfto uvbx pefu";

                    client.Credentials = new NetworkCredential(email, password); // Đặt thông tin xác thực

                    using (MailMessage mailMessage = new MailMessage())
                    {
                        mailMessage.From = new MailAddress(fromAddress);
                        mailMessage.To.Add(toAddress);
                        mailMessage.Subject = subject;
                        mailMessage.Body = body;
                        mailMessage.IsBodyHtml = true; // Đặt nội dung email là HTML

                        Attachment attachment = new Attachment(@$"{SelectedPhim.ImageUrl}"); // Đính kèm hình ảnh
                        attachment.ContentDisposition.Inline = true;
                        attachment.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
                        mailMessage.Attachments.Add(attachment);

                        client.Send(mailMessage); // Gửi email
                    }
                }
            }
            catch (SmtpException ex)
            {
                MessageBox.Show($"SMTP error: {ex.StatusCode} - {ex.Message}"); // Hiển thị lỗi SMTP
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}"); // Hiển thị lỗi chung
            }
        }


        private string ConvertImageToBase64(string imagePath)
        {
            byte[] imageArray = File.ReadAllBytes(imagePath);
            return Convert.ToBase64String(imageArray);
        }
        private void bt2_Reset_Click(object sender, EventArgs e)
        {
            tb1_Name.Text = "";
            cb2_Movie.Text = "";
            cb1_Theater.Text = "";
            cb1_Theater.Enabled = false;

        }

        private void bt3_Exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

