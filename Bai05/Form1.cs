using System;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;

namespace Bai05
{
    public partial class Form1 : Form
    {
        private string dbPath = "Data Source=Food.db";
        int Count = 0;
        string failed;

        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();  // Khởi tạo cơ sở dữ liệu
        }

        private void InitializeDatabase()
        {
            if (!File.Exists("Food.db"))  // Kiểm tra xem tệp cơ sở dữ liệu đã tồn tại chưa
            {
                SQLiteConnection.CreateFile("Food.db");  // Tạo tệp cơ sở dữ liệu nếu chưa tồn tại
                using (var conn = new SQLiteConnection(dbPath))
                {
                    conn.Open();
                    string sql = @"
                        CREATE TABLE FOOD (
                            ID TEXT PRIMARY KEY UNIQUE NOT NULL,
                            FOODNAME TEXT NOT NULL,
                            IMAGEPATH TEXT NOT NULL,
                            CONTRIBUTOR TEXT NOT NULL
                        )";
                    SQLiteCommand command = new SQLiteCommand(sql, conn);
                    command.ExecuteNonQuery();  // Tạo bảng FOOD
                }
            }
        }

        private void btnFetchEmails_Click(object sender, EventArgs e)
        {
            FetchEmails();  // Gọi hàm FetchEmails để lấy email
            LoadDataToListView();  // Gọi hàm LoadDataToListView để tải dữ liệu vào ListView
        }

        private void FetchEmails()
        {
            using (var client = new ImapClient())
            {
                failed = "";
                client.Connect("imap.gmail.com", 993, true);  // Kết nối đến máy chủ IMAP
                client.Authenticate("phtkhang1502@gmail.com", "tsaqjqjssgkrsnkn");  // Xác thực người dùng

                client.Inbox.Open(FolderAccess.ReadWrite);  // Mở hộp thư đến
                var query = SearchQuery.SubjectContains("Đóng góp món ăn").And(SearchQuery.NotSeen);  // Tìm kiếm email chưa đọc với tiêu đề chứa "Đóng góp món ăn"
                var uids = client.Inbox.Search(query);  // Lấy danh sách UID của email phù hợp

                foreach (var uid in uids)
                {
                    var message = client.Inbox.GetMessage(uid);  // Lấy nội dung email
                    ProcessEmail(message);  // Xử lý email
                    client.Inbox.AddFlags(uid, MessageFlags.Seen, true);  // Đánh dấu email là đã đọc
                }

                client.Disconnect(true);  // Ngắt kết nối
            }
        }

        private void SaveContribution(string foodName, string imagePath, string contributorName)
        {
            using (var conn = new SQLiteConnection(dbPath))
            {
                conn.Open();
                string countSql = "SELECT COUNT(*) FROM FOOD";
                using (var countCmd = new SQLiteCommand(countSql, conn))
                {
                    Count = Convert.ToInt32(countCmd.ExecuteScalar());  // Đếm số lượng bản ghi hiện có
                }

                if (contributorName == "")
                {
                    contributorName = "Người ẩn danh";  // Nếu không có tên người đóng góp, gán giá trị mặc định
                }
                string sql = "INSERT INTO FOOD (ID, FOODNAME, IMAGEPATH, CONTRIBUTOR) VALUES (@ID, @FOODNAME, @IMAGEPATH, @CONTRIBUTOR)";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", Count + 1);  // Gán ID dựa trên số lượng bản ghi
                    cmd.Parameters.AddWithValue("@FOODNAME", foodName);
                    cmd.Parameters.AddWithValue("@IMAGEPATH", imagePath);
                    cmd.Parameters.AddWithValue("@CONTRIBUTOR", contributorName);
                    cmd.ExecuteNonQuery();  // Thêm bản ghi mới vào bảng FOOD
                }
            }
        }

        private void btnRandomFood_Click(object sender, EventArgs e)
        {
            DisplayRandomFood();  // Gọi hàm DisplayRandomFood để hiển thị món ăn ngẫu nhiên
        }

        private void DisplayRandomFood()
        {
            using (var conn = new SQLiteConnection(dbPath))
            {
                conn.Open();
                string sql = "SELECT * FROM FOOD ORDER BY RANDOM() LIMIT 1";  // Lấy một món ăn ngẫu nhiên
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string foodName = reader["FOODNAME"].ToString();
                            string imagePath = reader["IMAGEPATH"].ToString();
                            string contributorName = reader["CONTRIBUTOR"].ToString();

                            lblFoodName.Text = $"Món ăn: {foodName}";
                            lblContributorName.Text = $"Người đóng góp: {contributorName}";

                            LoadImageFromUrl(imagePath);  // Gọi hàm LoadImageFromUrl để tải hình ảnh món ăn
                        }
                    }
                }
            }
        }

        private void LoadImageFromUrl(string url)
        {
            try
            {
                var request = WebRequest.Create(url);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pictureBoxFood.Image = System.Drawing.Image.FromStream(stream);  // Tải và hiển thị hình ảnh từ URL
                }
            }
            catch
            {
                pictureBoxFood.Image = null;  // Nếu lỗi, đặt hình ảnh thành null
            }
        }

        private void LoadDataToListView()
        {
            listViewContributions.Items.Clear();  // Xóa các mục hiện có trong ListView

            using (var conn = new SQLiteConnection(dbPath))
            {
                conn.Open();
                string sql = "SELECT * FROM FOOD";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new ListViewItem(reader["ID"].ToString());
                            item.SubItems.Add(reader["FOODNAME"].ToString());
                            item.SubItems.Add(reader["IMAGEPATH"].ToString());
                            item.SubItems.Add(reader["CONTRIBUTOR"].ToString());
                            listViewContributions.Items.Add(item);  // Thêm mục vào ListView
                        }
                    }
                }
            }
        }

        private void ProcessEmail(MimeMessage message)
        {
            string contributorName = message.From.Mailboxes.FirstOrDefault()?.Name ?? "Người ẩn danh";  
            // Lấy tên người đóng góp hoặc gán giá trị mặc định
            string body = message.TextBody;
            body = body.Replace(";\r\n", ";");
            var lines = body.Split("\r\n");
            foreach (var line in lines)
            {
                var parts = line.Split(';');
                if (parts.Length == 2)
                {
                    var foodName = parts[0];
                    var imagePath = parts[1];
                    // Kiểm tra xem món ăn đã tồn tại trong cơ sở dữ liệu chưa trước khi thêm vào
                    if (!FoodExists(foodName))
                    {
                        SaveContribution(foodName, imagePath, contributorName);  // Lưu đóng góp món ăn nếu chưa tồn tại
                    }
                    else
                        failed += foodName + "; ";
                }
            }
            if (failed != "")
                MessageBox.Show("Món ăn thêm vào thất bại: " + failed + "\nLỗi: Trùng tên với món ăn đã có trong cơ sở dữ liệu", "Warning!!");
        }

        private bool FoodExists(string foodName)
        {
            bool exists = false;
            using (var conn = new SQLiteConnection(dbPath))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM FOOD WHERE FOODNAME = @FOODNAME";  // Kiểm tra xem món ăn đã tồn tại chưa
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@FOODNAME", foodName);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    exists = count > 0;  // Nếu số lượng lớn hơn 0, món ăn đã tồn tại
                }
            }
            return exists;
        }
    }
}
