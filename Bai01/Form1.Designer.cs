﻿namespace Bai01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbFrom = new TextBox();
            tbTo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btConnect = new Button();
            label4 = new Label();
            label5 = new Label();
            tbSubject = new TextBox();
            rtbBody = new RichTextBox();
            SuspendLayout();
            // 
            // tbFrom
            // 
            tbFrom.BorderStyle = BorderStyle.FixedSingle;
            tbFrom.Location = new Point(80, 14);
            tbFrom.Name = "tbFrom";
            tbFrom.Size = new Size(387, 27);
            tbFrom.TabIndex = 0;
            // 
            // tbTo
            // 
            tbTo.BorderStyle = BorderStyle.FixedSingle;
            tbTo.Location = new Point(80, 68);
            tbTo.Name = "tbTo";
            tbTo.Size = new Size(387, 27);
            tbTo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 14);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 3;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 70);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 4;
            label2.Text = "To";
            // 
            // btConnect
            // 
            btConnect.Location = new Point(500, 10);
            btConnect.Name = "btConnect";
            btConnect.Size = new Size(152, 85);
            btConnect.TabIndex = 5;
            btConnect.Text = "Send";
            btConnect.UseVisualStyleBackColor = true;
            btConnect.Click += btConnect_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 146);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 6;
            label4.Text = "Subject";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 192);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 7;
            label5.Text = "Body";
            // 
            // tbSubject
            // 
            tbSubject.BorderStyle = BorderStyle.FixedSingle;
            tbSubject.Location = new Point(85, 146);
            tbSubject.Name = "tbSubject";
            tbSubject.Size = new Size(567, 27);
            tbSubject.TabIndex = 8;
            // 
            // rtbBody
            // 
            rtbBody.Location = new Point(88, 196);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(564, 224);
            rtbBody.TabIndex = 9;
            rtbBody.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 450);
            Controls.Add(rtbBody);
            Controls.Add(tbSubject);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btConnect);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbTo);
            Controls.Add(tbFrom);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbFrom;
        private TextBox tbTo;
        private Label label1;
        private Label label2;
        private Button btConnect;
        private Label label4;
        private Label label5;
        private TextBox tbSubject;
        private RichTextBox rtbBody;
    }
}
