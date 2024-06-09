namespace Bai05
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

        private void InitializeComponent()
        {
            btnFetchEmails = new Button();
            btnRandomFood = new Button();
            lblFoodName = new Label();
            lblContributorName = new Label();
            pictureBoxFood = new PictureBox();
            listViewContributions = new ListView();
            columnHeaderId = new ColumnHeader();
            columnHeaderFoodName = new ColumnHeader();
            columnHeaderImagePath = new ColumnHeader();
            columnHeaderContributorName = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFood).BeginInit();
            SuspendLayout();
            // 
            // btnFetchEmails
            // 
            btnFetchEmails.Location = new Point(504, 100);
            btnFetchEmails.Name = "btnFetchEmails";
            btnFetchEmails.Size = new Size(147, 47);
            btnFetchEmails.TabIndex = 0;
            btnFetchEmails.Text = "Tải email";
            btnFetchEmails.UseVisualStyleBackColor = true;
            btnFetchEmails.Click += btnFetchEmails_Click;
            // 
            // btnRandomFood
            // 
            btnRandomFood.Location = new Point(267, 100);
            btnRandomFood.Name = "btnRandomFood";
            btnRandomFood.Size = new Size(216, 47);
            btnRandomFood.TabIndex = 1;
            btnRandomFood.Text = "Chọn món ngẫu nhiên";
            btnRandomFood.UseVisualStyleBackColor = true;
            btnRandomFood.Click += btnRandomFood_Click;
            // 
            // lblFoodName
            // 
            lblFoodName.AutoSize = true;
            lblFoodName.Location = new Point(267, 16);
            lblFoodName.Name = "lblFoodName";
            lblFoodName.Size = new Size(62, 20);
            lblFoodName.TabIndex = 2;
            lblFoodName.Text = "Món ăn:";
            // 
            // lblContributorName
            // 
            lblContributorName.AutoSize = true;
            lblContributorName.Location = new Point(267, 50);
            lblContributorName.Name = "lblContributorName";
            lblContributorName.Size = new Size(124, 20);
            lblContributorName.TabIndex = 3;
            lblContributorName.Text = "Người đóng góp:";
            // 
            // pictureBoxFood
            // 
            pictureBoxFood.Location = new Point(12, 16);
            pictureBoxFood.Name = "pictureBoxFood";
            pictureBoxFood.Size = new Size(225, 143);
            pictureBoxFood.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFood.TabIndex = 4;
            pictureBoxFood.TabStop = false;
            // 
            // listViewContributions
            // 
            listViewContributions.Columns.AddRange(new ColumnHeader[] { columnHeaderId, columnHeaderFoodName, columnHeaderImagePath, columnHeaderContributorName });
            listViewContributions.Location = new Point(12, 165);
            listViewContributions.Name = "listViewContributions";
            listViewContributions.Size = new Size(639, 200);
            listViewContributions.TabIndex = 5;
            listViewContributions.UseCompatibleStateImageBehavior = false;
            listViewContributions.View = View.Details;
            // 
            // columnHeaderId
            // 
            columnHeaderId.Text = "Id";
            columnHeaderId.Width = 159;
            // 
            // columnHeaderFoodName
            // 
            columnHeaderFoodName.Text = "Food Name";
            columnHeaderFoodName.Width = 159;
            // 
            // columnHeaderImagePath
            // 
            columnHeaderImagePath.Text = "Image Path";
            columnHeaderImagePath.Width = 159;
            // 
            // columnHeaderContributorName
            // 
            columnHeaderContributorName.Text = "Contributor Name";
            columnHeaderContributorName.Width = 159;
            // 
            // Form1
            // 
            ClientSize = new Size(663, 383);
            Controls.Add(listViewContributions);
            Controls.Add(pictureBoxFood);
            Controls.Add(lblContributorName);
            Controls.Add(lblFoodName);
            Controls.Add(btnRandomFood);
            Controls.Add(btnFetchEmails);
            Name = "Form1";
            Text = "Ứng dụng đóng góp món ăn";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnFetchEmails;
        private System.Windows.Forms.Button btnRandomFood;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Label lblContributorName;
        private System.Windows.Forms.PictureBox pictureBoxFood;
        private System.Windows.Forms.ListView listViewContributions;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderFoodName;
        private System.Windows.Forms.ColumnHeader columnHeaderImagePath;
        private System.Windows.Forms.ColumnHeader columnHeaderContributorName;
    }
}
