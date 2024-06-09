using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Bai06
{
    partial class SendMail
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tbFrom = new TextBox();
            tbName = new TextBox();
            tbTo = new TextBox();
            tbSubject = new TextBox();
            tbBody = new TextBox();
            chkHtml = new CheckBox();
            btSend = new Button();
            tbAttachment = new TextBox();
            btBrowse = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbFrom
            // 
            tbFrom.BorderStyle = BorderStyle.None;
            tbFrom.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbFrom.ForeColor = SystemColors.ScrollBar;
            tbFrom.Location = new Point(92, 12);
            tbFrom.Name = "tbFrom";
            tbFrom.ReadOnly = true;
            tbFrom.Size = new Size(318, 23);
            tbFrom.TabIndex = 0;
            // 
            // tbName
            // 
            tbName.BorderStyle = BorderStyle.FixedSingle;
            tbName.Location = new Point(497, 12);
            tbName.Name = "tbName";
            tbName.Size = new Size(225, 30);
            tbName.TabIndex = 1;
            // 
            // tbTo
            // 
            tbTo.BorderStyle = BorderStyle.FixedSingle;
            tbTo.Location = new Point(92, 59);
            tbTo.Name = "tbTo";
            tbTo.Size = new Size(494, 30);
            tbTo.TabIndex = 2;
            // 
            // tbSubject
            // 
            tbSubject.BorderStyle = BorderStyle.FixedSingle;
            tbSubject.Location = new Point(92, 104);
            tbSubject.Name = "tbSubject";
            tbSubject.ScrollBars = ScrollBars.Horizontal;
            tbSubject.Size = new Size(494, 30);
            tbSubject.TabIndex = 3;
            tbSubject.WordWrap = false;
            // 
            // tbBody
            // 
            tbBody.BorderStyle = BorderStyle.FixedSingle;
            tbBody.Location = new Point(12, 150);
            tbBody.Multiline = true;
            tbBody.Name = "tbBody";
            tbBody.Size = new Size(710, 228);
            tbBody.TabIndex = 4;
            // 
            // chkHtml
            // 
            chkHtml.AutoSize = true;
            chkHtml.Font = new System.Drawing.Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkHtml.Location = new Point(630, 104);
            chkHtml.Name = "chkHtml";
            chkHtml.Size = new Size(80, 29);
            chkHtml.TabIndex = 5;
            chkHtml.Text = "HTML";
            chkHtml.UseVisualStyleBackColor = true;
            // 
            // btSend
            // 
            btSend.Location = new Point(593, 386);
            btSend.Name = "btSend";
            btSend.Size = new Size(129, 35);
            btSend.TabIndex = 6;
            btSend.Text = "Send";
            btSend.UseVisualStyleBackColor = true;
            btSend.Click += btnSend_Click;
            // 
            // tbAttachment
            // 
            tbAttachment.BorderStyle = BorderStyle.FixedSingle;
            tbAttachment.Location = new Point(135, 390);
            tbAttachment.Name = "tbAttachment";
            tbAttachment.ScrollBars = ScrollBars.Horizontal;
            tbAttachment.Size = new Size(297, 30);
            tbAttachment.TabIndex = 7;
            tbAttachment.WordWrap = false;
            // 
            // btBrowse
            // 
            btBrowse.Location = new Point(465, 386);
            btBrowse.Name = "btBrowse";
            btBrowse.Size = new Size(100, 37);
            btBrowse.TabIndex = 8;
            btBrowse.Text = "Browse";
            btBrowse.UseVisualStyleBackColor = true;
            btBrowse.Click += btnBrowse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(53, 23);
            label1.TabIndex = 9;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(31, 23);
            label2.TabIndex = 10;
            label2.Text = "To:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 11;
            label3.Text = "Subject:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(431, 12);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 12;
            label4.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 391);
            label5.Name = "label5";
            label5.Size = new Size(104, 23);
            label5.TabIndex = 13;
            label5.Text = "Attachment:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(2, 375);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(574, 53);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // SendMail
            // 
            ClientSize = new Size(748, 428);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btBrowse);
            Controls.Add(tbAttachment);
            Controls.Add(btSend);
            Controls.Add(chkHtml);
            Controls.Add(tbBody);
            Controls.Add(tbSubject);
            Controls.Add(tbTo);
            Controls.Add(tbName);
            Controls.Add(tbFrom);
            Controls.Add(pictureBox1);
            Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "SendMail";
            Text = "Send Mail";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.TextBox tbBody;
        private System.Windows.Forms.CheckBox chkHtml;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TextBox tbAttachment;
        private System.Windows.Forms.Button btBrowse;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
    }
}
