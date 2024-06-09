using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Bai04
{
    partial class BookingForm : Form
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
            label2 = new Label();
            bt3_Exit = new Button();
            bt2_Reset = new Button();
            lb4_Title = new Label();
            bt1_Confirm = new Button();
            Lb3_Theater = new Label();
            lb2_Movie = new Label();
            tb1_Name = new TextBox();
            lb1_Name = new Label();
            cb2_Movie = new ComboBox();
            clb1_Seats = new CheckedListBox();
            cb1_Theater = new ComboBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tb2_Mail = new TextBox();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(544, 64);
            label2.Name = "label2";
            label2.Size = new Size(123, 22);
            label2.TabIndex = 31;
            label2.Text = "Chọn chỗ ngồi";
            // 
            // bt3_Exit
            // 
            bt3_Exit.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt3_Exit.Location = new Point(544, 304);
            bt3_Exit.Name = "bt3_Exit";
            bt3_Exit.Size = new Size(215, 40);
            bt3_Exit.TabIndex = 30;
            bt3_Exit.Text = "Thoát";
            bt3_Exit.UseVisualStyleBackColor = true;
            bt3_Exit.Click += bt3_Exit_Click;
            // 
            // bt2_Reset
            // 
            bt2_Reset.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt2_Reset.Location = new Point(300, 304);
            bt2_Reset.Name = "bt2_Reset";
            bt2_Reset.Size = new Size(191, 40);
            bt2_Reset.TabIndex = 29;
            bt2_Reset.Text = "Xóa";
            bt2_Reset.UseVisualStyleBackColor = true;
            bt2_Reset.Click += bt2_Reset_Click;
            // 
            // lb4_Title
            // 
            lb4_Title.AutoSize = true;
            lb4_Title.Font = new Font("Times New Roman", 13F, FontStyle.Bold);
            lb4_Title.Location = new Point(55, 21);
            lb4_Title.Name = "lb4_Title";
            lb4_Title.Size = new Size(132, 25);
            lb4_Title.TabIndex = 27;
            lb4_Title.Text = "Thông tin vé";
            // 
            // bt1_Confirm
            // 
            bt1_Confirm.Enabled = false;
            bt1_Confirm.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt1_Confirm.Location = new Point(48, 304);
            bt1_Confirm.Name = "bt1_Confirm";
            bt1_Confirm.Size = new Size(198, 40);
            bt1_Confirm.TabIndex = 24;
            bt1_Confirm.Text = "Xác nhận";
            bt1_Confirm.UseVisualStyleBackColor = true;
            bt1_Confirm.Click += bt1_Confirm_Click;
            // 
            // Lb3_Theater
            // 
            Lb3_Theater.AutoSize = true;
            Lb3_Theater.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lb3_Theater.Location = new Point(44, 208);
            Lb3_Theater.Name = "Lb3_Theater";
            Lb3_Theater.Size = new Size(69, 22);
            Lb3_Theater.TabIndex = 23;
            Lb3_Theater.Text = "Phòng: ";
            // 
            // lb2_Movie
            // 
            lb2_Movie.AutoSize = true;
            lb2_Movie.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb2_Movie.Location = new Point(44, 159);
            lb2_Movie.Name = "lb2_Movie";
            lb2_Movie.Size = new Size(61, 22);
            lb2_Movie.TabIndex = 22;
            lb2_Movie.Text = "Phim: ";
            // 
            // tb1_Name
            // 
            tb1_Name.BorderStyle = BorderStyle.FixedSingle;
            tb1_Name.Location = new Point(141, 64);
            tb1_Name.Name = "tb1_Name";
            tb1_Name.Size = new Size(237, 27);
            tb1_Name.TabIndex = 21;
            // 
            // lb1_Name
            // 
            lb1_Name.AutoSize = true;
            lb1_Name.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb1_Name.Location = new Point(44, 64);
            lb1_Name.Name = "lb1_Name";
            lb1_Name.Size = new Size(73, 22);
            lb1_Name.TabIndex = 20;
            lb1_Name.Text = "Họ tên: ";
            // 
            // cb2_Movie
            // 
            cb2_Movie.FormattingEnabled = true;
            cb2_Movie.Location = new Point(141, 157);
            cb2_Movie.Name = "cb2_Movie";
            cb2_Movie.Size = new Size(237, 28);
            cb2_Movie.TabIndex = 19;
            cb2_Movie.SelectionChangeCommitted += cb2_Movie_SelectionChangeCommitted;
            // 
            // clb1_Seats
            // 
            clb1_Seats.CheckOnClick = true;
            clb1_Seats.FormattingEnabled = true;
            clb1_Seats.ImeMode = ImeMode.NoControl;
            clb1_Seats.Location = new Point(420, 94);
            clb1_Seats.MultiColumn = true;
            clb1_Seats.Name = "clb1_Seats";
            clb1_Seats.ScrollAlwaysVisible = true;
            clb1_Seats.Size = new Size(371, 136);
            clb1_Seats.TabIndex = 18;
            clb1_Seats.ItemCheck += clb1_Seats_ItemCheck;
            // 
            // cb1_Theater
            // 
            cb1_Theater.Enabled = false;
            cb1_Theater.FormattingEnabled = true;
            cb1_Theater.Location = new Point(141, 200);
            cb1_Theater.Name = "cb1_Theater";
            cb1_Theater.Size = new Size(237, 28);
            cb1_Theater.TabIndex = 17;
            cb1_Theater.SelectionChangeCommitted += cb1_Theater_SelectionChangeCommitted;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(26, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 231);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 114);
            label1.Name = "label1";
            label1.Size = new Size(68, 22);
            label1.TabIndex = 32;
            label1.Text = "Email: ";
            // 
            // tb2_Mail
            // 
            tb2_Mail.BorderStyle = BorderStyle.FixedSingle;
            tb2_Mail.Location = new Point(141, 109);
            tb2_Mail.Name = "tb2_Mail";
            tb2_Mail.Size = new Size(237, 27);
            tb2_Mail.TabIndex = 33;
            tb2_Mail.Text = "22520624@gm.uit.edu.vn";
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 368);
            Controls.Add(tb2_Mail);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(bt3_Exit);
            Controls.Add(bt2_Reset);
            Controls.Add(lb4_Title);
            Controls.Add(bt1_Confirm);
            Controls.Add(Lb3_Theater);
            Controls.Add(lb2_Movie);
            Controls.Add(tb1_Name);
            Controls.Add(lb1_Name);
            Controls.Add(cb2_Movie);
            Controls.Add(clb1_Seats);
            Controls.Add(cb1_Theater);
            Controls.Add(pictureBox1);
            Name = "BookingForm";
            Text = "Bai04_DatVe";
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button bt3_Exit;
        private Button bt2_Reset;
        private Label lb4_Title;
        private Button bt1_Confirm;
        private Label Lb3_Theater;
        private Label lb2_Movie;
        private TextBox tb1_Name;
        private Label lb1_Name;
        private ComboBox cb2_Movie;
        private CheckedListBox clb1_Seats;
        private ComboBox cb1_Theater;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox tb2_Mail;
    }
}