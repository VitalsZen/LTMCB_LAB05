using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bai04
{
    partial class Mainform : Form
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
            rtb1_Show = new RichTextBox();
            bt1_WtF = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbCost = new TextBox();
            tbName = new TextBox();
            tbTotal = new TextBox();
            label7 = new Label();
            cbRoom1 = new CheckBox();
            cbRoom2 = new CheckBox();
            cbRoom3 = new CheckBox();
            label8 = new Label();
            tbCount = new TextBox();
            btAdd = new Button();
            bt3_Read = new Button();
            btDatVe = new Button();
            progressBar1 = new ProgressBar();
            tbImageURL = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // rtb1_Show
            // 
            rtb1_Show.BackColor = SystemColors.Info;
            rtb1_Show.Location = new Point(495, 12);
            rtb1_Show.Name = "rtb1_Show";
            rtb1_Show.ReadOnly = true;
            rtb1_Show.Size = new Size(345, 394);
            rtb1_Show.TabIndex = 22;
            rtb1_Show.Text = "";
            // 
            // bt1_WtF
            // 
            bt1_WtF.Location = new Point(12, 12);
            bt1_WtF.Name = "bt1_WtF";
            bt1_WtF.Size = new Size(452, 37);
            bt1_WtF.TabIndex = 21;
            bt1_WtF.Text = "Write a to File";
            bt1_WtF.UseVisualStyleBackColor = true;
            bt1_WtF.Click += bt1_WtF_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 220);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 40;
            label3.Text = "Giá vé chuẩn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 170);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 39;
            label2.Text = "Phòng chiếu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 119);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 38;
            label1.Text = "Tên phim";
            // 
            // tbCost
            // 
            tbCost.BorderStyle = BorderStyle.FixedSingle;
            tbCost.Enabled = false;
            tbCost.Location = new Point(157, 222);
            tbCost.Name = "tbCost";
            tbCost.PlaceholderText = "Nhập giá tiền (đơn vị: VND)";
            tbCost.Size = new Size(307, 27);
            tbCost.TabIndex = 36;
            // 
            // tbName
            // 
            tbName.BorderStyle = BorderStyle.FixedSingle;
            tbName.Enabled = false;
            tbName.Location = new Point(157, 121);
            tbName.Name = "tbName";
            tbName.Size = new Size(307, 27);
            tbName.TabIndex = 35;
            // 
            // tbTotal
            // 
            tbTotal.BorderStyle = BorderStyle.FixedSingle;
            tbTotal.Enabled = false;
            tbTotal.Location = new Point(385, 74);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(79, 27);
            tbTotal.TabIndex = 41;
            tbTotal.TextAlign = HorizontalAlignment.Center;
            tbTotal.TextChanged += tbTotal_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(233, 72);
            label7.Name = "label7";
            label7.Size = new Size(131, 25);
            label7.TabIndex = 42;
            label7.Text = "Số lượng phim";
            // 
            // cbRoom1
            // 
            cbRoom1.AutoSize = true;
            cbRoom1.Location = new Point(157, 173);
            cbRoom1.Name = "cbRoom1";
            cbRoom1.Size = new Size(47, 24);
            cbRoom1.TabIndex = 44;
            cbRoom1.Text = "P1";
            cbRoom1.UseVisualStyleBackColor = true;
            // 
            // cbRoom2
            // 
            cbRoom2.AutoSize = true;
            cbRoom2.Location = new Point(267, 173);
            cbRoom2.Name = "cbRoom2";
            cbRoom2.Size = new Size(47, 24);
            cbRoom2.TabIndex = 45;
            cbRoom2.Text = "P2";
            cbRoom2.UseVisualStyleBackColor = true;
            // 
            // cbRoom3
            // 
            cbRoom3.AutoSize = true;
            cbRoom3.Location = new Point(376, 173);
            cbRoom3.Name = "cbRoom3";
            cbRoom3.Size = new Size(47, 24);
            cbRoom3.TabIndex = 46;
            cbRoom3.Text = "P3";
            cbRoom3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(11, 326);
            label8.Name = "label8";
            label8.Size = new Size(162, 25);
            label8.TabIndex = 49;
            label8.Text = "Số lần nhập còn lại";
            // 
            // tbCount
            // 
            tbCount.BorderStyle = BorderStyle.FixedSingle;
            tbCount.Enabled = false;
            tbCount.Location = new Point(179, 328);
            tbCount.Name = "tbCount";
            tbCount.Size = new Size(79, 27);
            tbCount.TabIndex = 48;
            tbCount.TextAlign = HorizontalAlignment.Center;
            // 
            // btAdd
            // 
            btAdd.Enabled = false;
            btAdd.Location = new Point(319, 321);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(145, 38);
            btAdd.TabIndex = 47;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // bt3_Read
            // 
            bt3_Read.Location = new Point(35, 375);
            bt3_Read.Name = "bt3_Read";
            bt3_Read.Size = new Size(190, 49);
            bt3_Read.TabIndex = 65;
            bt3_Read.Text = "Thống kê";
            bt3_Read.UseVisualStyleBackColor = true;
            bt3_Read.Click += bt3_Read_Click;
            // 
            // btDatVe
            // 
            btDatVe.Location = new Point(277, 375);
            btDatVe.Name = "btDatVe";
            btDatVe.Size = new Size(165, 46);
            btDatVe.TabIndex = 68;
            btDatVe.Text = "Đặt vé";
            btDatVe.UseVisualStyleBackColor = true;
            btDatVe.Click += btDatVe_Click;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Red;
            progressBar1.Location = new Point(495, 412);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(345, 29);
            progressBar1.TabIndex = 69;
            // 
            // tbImageURL
            // 
            tbImageURL.BorderStyle = BorderStyle.FixedSingle;
            tbImageURL.Location = new Point(179, 280);
            tbImageURL.Name = "tbImageURL";
            tbImageURL.Size = new Size(285, 27);
            tbImageURL.TabIndex = 70;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 280);
            label6.Name = "label6";
            label6.Size = new Size(159, 25);
            label6.TabIndex = 73;
            label6.Text = "Đường dẫn poster";
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 450);
            Controls.Add(label6);
            Controls.Add(tbImageURL);
            Controls.Add(progressBar1);
            Controls.Add(btDatVe);
            Controls.Add(bt3_Read);
            Controls.Add(label8);
            Controls.Add(tbCount);
            Controls.Add(btAdd);
            Controls.Add(cbRoom3);
            Controls.Add(cbRoom2);
            Controls.Add(cbRoom1);
            Controls.Add(label7);
            Controls.Add(tbTotal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbCost);
            Controls.Add(tbName);
            Controls.Add(rtb1_Show);
            Controls.Add(bt1_WtF);
            Name = "Mainform";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtb1_Show;
        private Button bt1_WtF;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb2_ID;
        private TextBox tbCost;
        private TextBox tbName;
        private TextBox tbTotal;
        private Label label7;
        private CheckBox cbRoom1;
        private CheckBox cbRoom2;
        private CheckBox cbRoom3;
        private Label label8;
        private TextBox tbCount;
        private Button btAdd;
        private Button bt3_Read;
        private Button btDatVe;
        private ProgressBar progressBar1;
        private TextBox tbImageURL;
        private Label label6;
    }
}