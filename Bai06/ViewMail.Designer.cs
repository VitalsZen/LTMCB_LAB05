using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Bai06
{
    partial class ViewMail
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
            tbSubject = new TextBox();
            tbBody = new TextBox();
            tbTo = new TextBox();
            label5 = new Label();
            label1 = new Label();
            btReply = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // tbFrom
            // 
            tbFrom.BorderStyle = BorderStyle.None;
            tbFrom.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbFrom.Location = new Point(102, 17);
            tbFrom.Name = "tbFrom";
            tbFrom.ReadOnly = true;
            tbFrom.Size = new Size(417, 23);
            tbFrom.TabIndex = 0;
            // 
            // tbSubject
            // 
            tbSubject.BackColor = SystemColors.Menu;
            tbSubject.BorderStyle = BorderStyle.None;
            tbSubject.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbSubject.Location = new Point(12, 89);
            tbSubject.Multiline = true;
            tbSubject.Name = "tbSubject";
            tbSubject.ReadOnly = true;
            tbSubject.ScrollBars = ScrollBars.Horizontal;
            tbSubject.Size = new Size(713, 59);
            tbSubject.TabIndex = 1;
            tbSubject.WordWrap = false;
            // 
            // tbBody
            // 
            tbBody.BackColor = Color.White;
            tbBody.BorderStyle = BorderStyle.FixedSingle;
            tbBody.Font = new System.Drawing.Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBody.Location = new Point(12, 154);
            tbBody.Multiline = true;
            tbBody.Name = "tbBody";
            tbBody.ReadOnly = true;
            tbBody.ScrollBars = ScrollBars.Both;
            tbBody.Size = new Size(723, 353);
            tbBody.TabIndex = 2;
            tbBody.WordWrap = false;
            // 
            // tbTo
            // 
            tbTo.BorderStyle = BorderStyle.None;
            tbTo.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTo.Location = new Point(120, 60);
            tbTo.Name = "tbTo";
            tbTo.ReadOnly = true;
            tbTo.Size = new Size(360, 23);
            tbTo.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(-86, 17);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 17;
            label5.Text = "From: ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-86, 56);
            label1.Name = "label1";
            label1.Size = new Size(38, 23);
            label1.TabIndex = 18;
            label1.Text = "To: ";
            // 
            // btReply
            // 
            btReply.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btReply.Location = new Point(586, 7);
            btReply.Name = "btReply";
            btReply.Size = new Size(120, 41);
            btReply.TabIndex = 19;
            btReply.Text = "Reply";
            btReply.UseVisualStyleBackColor = true;
            btReply.Click += btReply_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 17);
            label2.Name = "label2";
            label2.Size = new Size(53, 23);
            label2.TabIndex = 20;
            label2.Text = "From:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 60);
            label3.Name = "label3";
            label3.Size = new Size(31, 23);
            label3.TabIndex = 21;
            label3.Text = "To:";
            // 
            // ViewMail
            // 
            ClientSize = new Size(737, 509);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btReply);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(tbTo);
            Controls.Add(tbBody);
            Controls.Add(tbSubject);
            Controls.Add(tbFrom);
            Name = "ViewMail";
            Text = "Email Content";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.TextBox tbBody;
        private TextBox tbTo;
        private Label label5;
        private Label label1;
        private Button btReply;
        private Label label2;
        private Label label3;
    }
}
