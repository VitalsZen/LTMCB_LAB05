namespace Bai02
{
    partial class Form1
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btConnect = new Button();
            label2 = new Label();
            label1 = new Label();
            tbPassword = new TextBox();
            tbEmail = new TextBox();
            label3 = new Label();
            lbCountTotal = new Label();
            dtgvInfo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgvInfo).BeginInit();
            SuspendLayout();
            // 
            // btConnect
            // 
            btConnect.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btConnect.Location = new Point(510, 23);
            btConnect.Name = "btConnect";
            btConnect.Size = new Size(212, 85);
            btConnect.TabIndex = 10;
            btConnect.Text = "Login";
            btConnect.UseVisualStyleBackColor = true;
            btConnect.Click += new EventHandler(btConnect_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 83);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 27);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 8;
            label1.Text = "Email";
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.FixedSingle;
            tbPassword.Location = new Point(90, 81);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(387, 27);
            tbPassword.TabIndex = 7;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.FixedSingle;
            tbEmail.Location = new Point(90, 27);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(387, 27);
            tbEmail.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 136);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 11;
            label3.Text = "Total";
            // 
            // lbCountTotal
            // 
            lbCountTotal.AutoSize = true;
            lbCountTotal.Location = new Point(119, 136);
            lbCountTotal.Name = "lbCountTotal";
            lbCountTotal.Size = new Size(17, 20);
            lbCountTotal.TabIndex = 12;
            lbCountTotal.Text = "0";
            // 
            // dtgvInfo
            // 
            dtgvInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Set AutoSizeColumnsMode to Fill
            dtgvInfo.Location = new Point(14, 178);
            dtgvInfo.Name = "dtgvInfo";
            dtgvInfo.RowHeadersWidth = 51;
            dtgvInfo.Size = new Size(746, 245);
            dtgvInfo.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgvInfo);
            Controls.Add(lbCountTotal);
            Controls.Add(label3);
            Controls.Add(btConnect);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgvInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btConnect;
        private Label label2;
        private Label label1;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private Label label3;
        private Label lbCountTotal;
        private DataGridView dtgvInfo;
    }
}
