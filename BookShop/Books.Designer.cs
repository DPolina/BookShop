
namespace BookShop
{
    partial class Books
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            panel2 = new Panel();
            BookDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            pictureBox4 = new PictureBox();
            RefreshBtn = new Button();
            CatSearchCb = new ComboBox();
            label4 = new Label();
            ResetBtn = new Button();
            DeleteBtn = new Button();
            EditBtn = new Button();
            label13 = new Label();
            PriceTb = new TextBox();
            label12 = new Label();
            QtyTb = new TextBox();
            BCatCb = new ComboBox();
            label11 = new Label();
            label3 = new Label();
            BautTb = new TextBox();
            label8 = new Label();
            SaveBtn = new Button();
            label2 = new Label();
            BTitleTb = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            booksBindingSource = new BindingSource(components);
            panel1 = new Panel();
            panel7 = new Panel();
            label10 = new Label();
            panel6 = new Panel();
            label9 = new Label();
            panel5 = new Panel();
            label7 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            booksBindingSource1 = new BindingSource(components);
            booksBindingSource2 = new BindingSource(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)booksBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)booksBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)booksBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(BookDGV);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(RefreshBtn);
            panel2.Controls.Add(CatSearchCb);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(ResetBtn);
            panel2.Controls.Add(DeleteBtn);
            panel2.Controls.Add(EditBtn);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(PriceTb);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(QtyTb);
            panel2.Controls.Add(BCatCb);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(BautTb);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(SaveBtn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(BTitleTb);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(318, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(965, 604);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // BookDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            BookDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            BookDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            BookDGV.ColumnHeadersHeight = 25;
            BookDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            BookDGV.DefaultCellStyle = dataGridViewCellStyle3;
            BookDGV.GridColor = Color.White;
            BookDGV.Location = new Point(17, 384);
            BookDGV.Name = "BookDGV";
            BookDGV.RowHeadersVisible = false;
            BookDGV.RowHeadersWidth = 51;
            BookDGV.RowTemplate.Height = 24;
            BookDGV.Size = new Size(927, 188);
            BookDGV.TabIndex = 45;
            BookDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            BookDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            BookDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            BookDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            BookDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            BookDGV.ThemeStyle.BackColor = Color.White;
            BookDGV.ThemeStyle.GridColor = Color.White;
            BookDGV.ThemeStyle.HeaderStyle.BackColor = Color.SlateGray;
            BookDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            BookDGV.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BookDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            BookDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            BookDGV.ThemeStyle.HeaderStyle.Height = 25;
            BookDGV.ThemeStyle.ReadOnly = false;
            BookDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            BookDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            BookDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            BookDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            BookDGV.ThemeStyle.RowsStyle.Height = 24;
            BookDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            BookDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            BookDGV.CellContentClick += BookDGV_CellContentClick;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(11, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 43;
            pictureBox4.TabStop = false;
            // 
            // RefreshBtn
            // 
            RefreshBtn.BackColor = Color.SlateGray;
            RefreshBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RefreshBtn.ForeColor = Color.White;
            RefreshBtn.Location = new Point(579, 322);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(140, 37);
            RefreshBtn.TabIndex = 25;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = false;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // CatSearchCb
            // 
            CatSearchCb.ForeColor = Color.DarkGray;
            CatSearchCb.FormattingEnabled = true;
            CatSearchCb.Items.AddRange(new object[] { "Programming", "Networking", "Math", "Physics", "Novels", "Biography" });
            CatSearchCb.Location = new Point(381, 327);
            CatSearchCb.Name = "CatSearchCb";
            CatSearchCb.Size = new Size(192, 28);
            CatSearchCb.TabIndex = 16;
            CatSearchCb.Text = "Filter by category";
            CatSearchCb.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            CatSearchCb.SelectionChangeCommitted += CatSearchCb_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(415, 283);
            label4.Name = "label4";
            label4.Size = new Size(130, 34);
            label4.TabIndex = 24;
            label4.Text = "Book List";
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.SlateGray;
            ResetBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResetBtn.ForeColor = Color.White;
            ResetBtn.Location = new Point(629, 220);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(147, 38);
            ResetBtn.TabIndex = 22;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.SlateGray;
            DeleteBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(476, 220);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(147, 38);
            DeleteBtn.TabIndex = 21;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.SlateGray;
            EditBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(323, 221);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(147, 38);
            EditBtn.TabIndex = 20;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DimGray;
            label13.Location = new Point(825, 144);
            label13.Name = "label13";
            label13.Size = new Size(57, 23);
            label13.TabIndex = 19;
            label13.Text = "Price";
            // 
            // PriceTb
            // 
            PriceTb.BorderStyle = BorderStyle.FixedSingle;
            PriceTb.Location = new Point(825, 170);
            PriceTb.Multiline = true;
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(93, 28);
            PriceTb.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DimGray;
            label12.Location = new Point(671, 143);
            label12.Name = "label12";
            label12.Size = new Size(93, 23);
            label12.TabIndex = 17;
            label12.Text = "Quantity";
            // 
            // QtyTb
            // 
            QtyTb.BorderStyle = BorderStyle.FixedSingle;
            QtyTb.Location = new Point(671, 169);
            QtyTb.Multiline = true;
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(119, 28);
            QtyTb.TabIndex = 16;
            // 
            // BCatCb
            // 
            BCatCb.ForeColor = Color.DarkGray;
            BCatCb.FormattingEnabled = true;
            BCatCb.Items.AddRange(new object[] { "Programming", "Networking", "Math", "Physics", "Novels", "Biography", "Biology", "Astrology", "For children" });
            BCatCb.Location = new Point(459, 170);
            BCatCb.Name = "BCatCb";
            BCatCb.Size = new Size(174, 28);
            BCatCb.TabIndex = 15;
            BCatCb.Text = "Select Category";
            BCatCb.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(459, 144);
            label11.Name = "label11";
            label11.Size = new Size(116, 23);
            label11.TabIndex = 14;
            label11.Text = "Categories";
            label11.Click += label11_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(249, 145);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 12;
            label3.Text = "Author";
            // 
            // BautTb
            // 
            BautTb.BorderStyle = BorderStyle.FixedSingle;
            BautTb.Location = new Point(249, 171);
            BautTb.Multiline = true;
            BautTb.Name = "BautTb";
            BautTb.Size = new Size(172, 28);
            BautTb.TabIndex = 11;
            BautTb.TextChanged += textBox2_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(929, 9);
            label8.Name = "label8";
            label8.Size = new Size(22, 23);
            label8.TabIndex = 10;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.SlateGray;
            SaveBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(170, 221);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(147, 38);
            SaveBtn.TabIndex = 8;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(33, 143);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 5;
            label2.Text = "Book Title";
            label2.Click += label2_Click;
            // 
            // BTitleTb
            // 
            BTitleTb.BorderStyle = BorderStyle.FixedSingle;
            BTitleTb.Location = new Point(33, 169);
            BTitleTb.Multiline = true;
            BTitleTb.Name = "BTitleTb";
            BTitleTb.Size = new Size(172, 28);
            BTitleTb.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(437, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(393, 19);
            label1.Name = "label1";
            label1.Size = new Size(157, 34);
            label1.TabIndex = 1;
            label1.Text = "Book Shop";
            // 
            // booksBindingSource
            // 
            booksBindingSource.DataSource = typeof(Books);
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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 604);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label10);
            panel7.Location = new Point(24, 537);
            panel7.Name = "panel7";
            panel7.Size = new Size(100, 50);
            panel7.TabIndex = 16;
            panel7.Paint += panel7_Paint;
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
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label9);
            panel6.Location = new Point(24, 305);
            panel6.Name = "panel6";
            panel6.Size = new Size(259, 63);
            panel6.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(17, 11);
            label9.Name = "label9";
            label9.Size = new Size(200, 40);
            label9.TabIndex = 11;
            label9.Text = "Dashboard";
            label9.Click += label9_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label7);
            panel5.Location = new Point(24, 220);
            panel5.Name = "panel5";
            panel5.Size = new Size(259, 63);
            panel5.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(17, 10);
            label7.Name = "label7";
            label7.Size = new Size(96, 40);
            label7.TabIndex = 11;
            label7.Text = "Users";
            label7.Click += label7_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSlateGray;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(24, 135);
            panel3.Name = "panel3";
            panel3.Size = new Size(259, 63);
            panel3.TabIndex = 13;
            panel3.Paint += panel3_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(61, 13);
            label6.Name = "label6";
            label6.Size = new Size(111, 40);
            label6.TabIndex = 11;
            label6.Text = "Books";
            label6.Click += label6_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(8, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
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
            // booksBindingSource1
            // 
            booksBindingSource1.DataSource = typeof(Books);
            // 
            // booksBindingSource2
            // 
            booksBindingSource2.DataSource = typeof(Books);
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1298, 628);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Books";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Books";
            Load += Books_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BookDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)booksBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)booksBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)booksBindingSource2).EndInit();
            ResumeLayout(false);
        }

        private void UserNameLbl_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel2;
        private Label label8;
        private Label label2;
        private TextBox BTitleTb;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label5;
        private PictureBox pictureBox3;
        private Panel panel3;
        private Label label6;
        private Label label11;
        private Label label3;
        private TextBox BautTb;
        private ComboBox BCatCb;
        private Label label13;
        private TextBox PriceTb;
        private Label label12;
        private TextBox QtyTb;
        public Button SaveBtn;
        public Button ResetBtn;
        public Button DeleteBtn;
        public Button EditBtn;
        private Label label4;
        private ComboBox CatSearchCb;
        public Button RefreshBtn;
        private Panel panel5;
        private Label label7;
        private Panel panel6;
        private Label label9;
        private Panel panel7;
        private Label label10;
        private BindingSource booksBindingSource;
        private BindingSource booksBindingSource1;
        private BindingSource booksBindingSource2;
        private PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2DataGridView BookDGV;
    }
}