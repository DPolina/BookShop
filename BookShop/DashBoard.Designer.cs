namespace BookShop
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            label6 = new Label();
            label7 = new Label();
            panel5 = new Panel();
            label9 = new Label();
            panel6 = new Panel();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            panel7 = new Panel();
            label10 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            panel9 = new Panel();
            UserTotalLbl = new Label();
            label13 = new Label();
            pictureBox5 = new PictureBox();
            panel8 = new Panel();
            AmountLbl = new Label();
            label11 = new Label();
            Icon = new PictureBox();
            panel4 = new Panel();
            BookStockLbl = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Icon).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(17, 10);
            label6.Name = "label6";
            label6.Size = new Size(111, 40);
            label6.TabIndex = 11;
            label6.Text = "Books";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(17, 10);
            label7.Name = "label7";
            label7.Size = new Size(96, 40);
            label7.TabIndex = 11;
            label7.Text = "Users";
            label7.Click += label7_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label7);
            panel5.Location = new Point(21, 225);
            panel5.Name = "panel5";
            panel5.Size = new Size(259, 63);
            panel5.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(17, 12);
            label9.Name = "label9";
            label9.Size = new Size(200, 40);
            label9.TabIndex = 11;
            label9.Text = "Dashboard";
            // 
            // panel6
            // 
            panel6.BackColor = Color.SlateGray;
            panel6.Controls.Add(label9);
            panel6.Location = new Point(21, 310);
            panel6.Name = "panel6";
            panel6.Size = new Size(259, 63);
            panel6.TabIndex = 19;
            panel6.Paint += panel6_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(931, 10);
            label8.Name = "label8";
            label8.Size = new Size(22, 23);
            label8.TabIndex = 10;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(449, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(403, 19);
            label1.Name = "label1";
            label1.Size = new Size(157, 34);
            label1.TabIndex = 1;
            label1.Text = "Book Shop";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label6);
            panel3.Location = new Point(21, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(259, 63);
            panel3.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(14, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 604);
            panel1.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label10);
            panel7.Location = new Point(21, 536);
            panel7.Name = "panel7";
            panel7.Size = new Size(100, 50);
            panel7.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(11, 11);
            label10.Name = "label10";
            label10.Size = new Size(77, 23);
            label10.TabIndex = 11;
            label10.Text = "Logout";
            label10.Click += label10_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(93, 32);
            label5.Name = "label5";
            label5.Size = new Size(190, 40);
            label5.TabIndex = 11;
            label5.Text = "Book Shop";
            label5.Click += label5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(24, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(320, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(965, 604);
            panel2.TabIndex = 7;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(11, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 43;
            pictureBox4.TabStop = false;
            // 
            // panel9
            // 
            panel9.BackColor = Color.LightSlateGray;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(UserTotalLbl);
            panel9.Controls.Add(label13);
            panel9.Controls.Add(pictureBox5);
            panel9.Location = new Point(309, 361);
            panel9.Name = "panel9";
            panel9.Size = new Size(354, 136);
            panel9.TabIndex = 16;
            // 
            // UserTotalLbl
            // 
            UserTotalLbl.AutoSize = true;
            UserTotalLbl.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserTotalLbl.ForeColor = Color.White;
            UserTotalLbl.Location = new Point(96, 78);
            UserTotalLbl.Name = "UserTotalLbl";
            UserTotalLbl.Size = new Size(107, 40);
            UserTotalLbl.TabIndex = 13;
            UserTotalLbl.Text = "Stock";
            UserTotalLbl.Click += UserTotalLbl_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(71, 21);
            label13.Name = "label13";
            label13.Size = new Size(106, 44);
            label13.TabIndex = 11;
            label13.Text = "Users";
            label13.Click += label13_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(240, 21);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(96, 97);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.LightSlateGray;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(AmountLbl);
            panel8.Controls.Add(label11);
            panel8.Controls.Add(Icon);
            panel8.Location = new Point(532, 175);
            panel8.Name = "panel8";
            panel8.Size = new Size(354, 136);
            panel8.TabIndex = 15;
            // 
            // AmountLbl
            // 
            AmountLbl.AutoSize = true;
            AmountLbl.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AmountLbl.ForeColor = Color.White;
            AmountLbl.Location = new Point(70, 78);
            AmountLbl.Name = "AmountLbl";
            AmountLbl.Size = new Size(107, 40);
            AmountLbl.TabIndex = 13;
            AmountLbl.Text = "Stock";
            AmountLbl.Click += AmountLbl_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(14, 22);
            label11.Name = "label11";
            label11.Size = new Size(209, 37);
            label11.TabIndex = 11;
            label11.Text = "Total Amount";
            // 
            // Icon
            // 
            Icon.Image = (Image)resources.GetObject("Icon.Image");
            Icon.Location = new Point(240, 21);
            Icon.Name = "Icon";
            Icon.Size = new Size(96, 97);
            Icon.SizeMode = PictureBoxSizeMode.Zoom;
            Icon.TabIndex = 12;
            Icon.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSlateGray;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(BookStockLbl);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(80, 175);
            panel4.Name = "panel4";
            panel4.Size = new Size(354, 136);
            panel4.TabIndex = 14;
            // 
            // BookStockLbl
            // 
            BookStockLbl.AutoSize = true;
            BookStockLbl.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BookStockLbl.ForeColor = Color.White;
            BookStockLbl.Location = new Point(70, 78);
            BookStockLbl.Name = "BookStockLbl";
            BookStockLbl.Size = new Size(107, 40);
            BookStockLbl.TabIndex = 13;
            BookStockLbl.Text = "Stock";
            BookStockLbl.Click += BookStockLbl_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 22);
            label2.Name = "label2";
            label2.Size = new Size(210, 40);
            label2.TabIndex = 11;
            label2.Text = "Books Stock";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(240, 21);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(96, 97);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1298, 628);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoard";
            Load += DashBoard_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Icon).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private Label label7;
        private Panel panel5;
        private Label label9;
        private Panel panel6;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel3;
        private Panel panel1;
        private Label label5;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel7;
        private Label label10;
        private Panel panel4;
        private Label label2;
        private PictureBox pictureBox3;
        private Label BookStockLbl;
        private Panel panel8;
        private Label AmountLbl;
        private Label label11;
        private PictureBox Icon;
        private Panel panel9;
        private Label UserTotalLbl;
        private Label label13;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
    }
}