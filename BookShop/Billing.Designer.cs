namespace BookShop
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel7 = new Panel();
            label10 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            ResetBillBtn = new Button();
            panel2 = new Panel();
            BillDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            BookDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            ContactUsLbl = new TextBox();
            UserNameLbl = new Label();
            UserIcon = new PictureBox();
            TotalLbl = new Label();
            label9 = new Label();
            label6 = new Label();
            PriceTb = new TextBox();
            label7 = new Label();
            ClientNameTb = new TextBox();
            PrintBtn = new Button();
            label3 = new Label();
            BqtyTb = new TextBox();
            label8 = new Label();
            AddToBillBtn = new Button();
            label2 = new Label();
            BTitleTb = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BillDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BookDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label10);
            panel7.Location = new Point(20, 533);
            panel7.Name = "panel7";
            panel7.Size = new Size(100, 50);
            panel7.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SlateGray;
            label10.Location = new Point(13, 12);
            label10.Name = "label10";
            label10.Size = new Size(77, 23);
            label10.TabIndex = 11;
            label10.Text = "Logout";
            label10.Click += label10_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(7, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 604);
            panel1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SlateGray;
            label5.Location = new Point(89, 69);
            label5.Name = "label5";
            label5.Size = new Size(129, 27);
            label5.TabIndex = 11;
            label5.Text = "Book Shop";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(20, 48);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SlateGray;
            label4.Location = new Point(16, 324);
            label4.Name = "label4";
            label4.Size = new Size(130, 34);
            label4.TabIndex = 24;
            label4.Text = "Book List";
            // 
            // ResetBillBtn
            // 
            ResetBillBtn.BackColor = Color.SlateGray;
            ResetBillBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResetBillBtn.ForeColor = Color.White;
            ResetBillBtn.Location = new Point(178, 254);
            ResetBillBtn.Name = "ResetBillBtn";
            ResetBillBtn.Size = new Size(117, 38);
            ResetBillBtn.TabIndex = 22;
            ResetBillBtn.Text = "Reset";
            ResetBillBtn.UseVisualStyleBackColor = false;
            ResetBillBtn.Click += ResetBillBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(BillDGV);
            panel2.Controls.Add(BookDGV);
            panel2.Controls.Add(ContactUsLbl);
            panel2.Controls.Add(UserNameLbl);
            panel2.Controls.Add(UserIcon);
            panel2.Controls.Add(TotalLbl);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(PriceTb);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(ClientNameTb);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(ResetBillBtn);
            panel2.Controls.Add(PrintBtn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(BqtyTb);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(AddToBillBtn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(BTitleTb);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(243, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(1035, 604);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // BillDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            BillDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            BillDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            BillDGV.ColumnHeadersHeight = 25;
            BillDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            BillDGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4, Column3, Column5 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            BillDGV.DefaultCellStyle = dataGridViewCellStyle3;
            BillDGV.GridColor = Color.White;
            BillDGV.Location = new Point(635, 150);
            BillDGV.Name = "BillDGV";
            BillDGV.RowHeadersVisible = false;
            BillDGV.RowHeadersWidth = 51;
            BillDGV.RowTemplate.Height = 24;
            BillDGV.Size = new Size(386, 280);
            BillDGV.TabIndex = 47;
            BillDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            BillDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            BillDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            BillDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            BillDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            BillDGV.ThemeStyle.BackColor = Color.White;
            BillDGV.ThemeStyle.GridColor = Color.White;
            BillDGV.ThemeStyle.HeaderStyle.BackColor = Color.SlateGray;
            BillDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            BillDGV.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BillDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            BillDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            BillDGV.ThemeStyle.HeaderStyle.Height = 25;
            BillDGV.ThemeStyle.ReadOnly = false;
            BillDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            BillDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            BillDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            BillDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            BillDGV.ThemeStyle.RowsStyle.Height = 24;
            BillDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            BillDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Column1
            // 
            Column1.FillWeight = 106.951859F;
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.FillWeight = 98.26203F;
            Column2.HeaderText = "Books";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column4
            // 
            Column4.FillWeight = 98.26203F;
            Column4.HeaderText = "Quantity";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column3
            // 
            Column3.FillWeight = 98.26203F;
            Column3.HeaderText = "Price";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column5
            // 
            Column5.FillWeight = 98.26203F;
            Column5.HeaderText = "Total";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // BookDGV
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            BookDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            BookDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            BookDGV.ColumnHeadersHeight = 25;
            BookDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            BookDGV.DefaultCellStyle = dataGridViewCellStyle6;
            BookDGV.GridColor = Color.White;
            BookDGV.Location = new Point(21, 372);
            BookDGV.Name = "BookDGV";
            BookDGV.RowHeadersVisible = false;
            BookDGV.RowHeadersWidth = 51;
            BookDGV.RowTemplate.Height = 24;
            BookDGV.Size = new Size(592, 211);
            BookDGV.TabIndex = 46;
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
            // ContactUsLbl
            // 
            ContactUsLbl.BorderStyle = BorderStyle.None;
            ContactUsLbl.Font = new Font("Century Gothic", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            ContactUsLbl.ForeColor = Color.SlateGray;
            ContactUsLbl.Location = new Point(758, 562);
            ContactUsLbl.Name = "ContactUsLbl";
            ContactUsLbl.Size = new Size(198, 21);
            ContactUsLbl.TabIndex = 17;
            ContactUsLbl.Text = "contact the help desk";
            ContactUsLbl.Click += ContactUsLbl_Click;
            ContactUsLbl.TextChanged += printPreviewDialog1_Load;
            // 
            // UserNameLbl
            // 
            UserNameLbl.AutoSize = true;
            UserNameLbl.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameLbl.ForeColor = Color.DarkGray;
            UserNameLbl.Location = new Point(89, 53);
            UserNameLbl.Name = "UserNameLbl";
            UserNameLbl.Size = new Size(111, 23);
            UserNameLbl.TabIndex = 36;
            UserNameLbl.Text = "UserName";
            UserNameLbl.Click += UsernameLbl_Click;
            // 
            // UserIcon
            // 
            UserIcon.Image = (Image)resources.GetObject("UserIcon.Image");
            UserIcon.Location = new Point(21, 19);
            UserIcon.Name = "UserIcon";
            UserIcon.Size = new Size(62, 63);
            UserIcon.SizeMode = PictureBoxSizeMode.Zoom;
            UserIcon.TabIndex = 35;
            UserIcon.TabStop = false;
            UserIcon.Click += UserIcon_Click;
            // 
            // TotalLbl
            // 
            TotalLbl.AutoSize = true;
            TotalLbl.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalLbl.ForeColor = Color.SlateGray;
            TotalLbl.Location = new Point(794, 447);
            TotalLbl.Name = "TotalLbl";
            TotalLbl.Size = new Size(79, 34);
            TotalLbl.TabIndex = 34;
            TotalLbl.Text = "Total";
            TotalLbl.Click += TotalLbl_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SlateGray;
            label9.Location = new Point(749, 94);
            label9.Name = "label9";
            label9.Size = new Size(159, 40);
            label9.TabIndex = 32;
            label9.Text = "Books Bill";
            label9.Click += label9_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SlateGray;
            label6.Location = new Point(202, 181);
            label6.Name = "label6";
            label6.Size = new Size(57, 23);
            label6.TabIndex = 30;
            label6.Text = "Price";
            // 
            // PriceTb
            // 
            PriceTb.BorderStyle = BorderStyle.FixedSingle;
            PriceTb.Enabled = false;
            PriceTb.Location = new Point(201, 209);
            PriceTb.Multiline = true;
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(93, 28);
            PriceTb.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SlateGray;
            label7.Location = new Point(22, 183);
            label7.Name = "label7";
            label7.Size = new Size(133, 23);
            label7.TabIndex = 28;
            label7.Text = "Client Name";
            // 
            // ClientNameTb
            // 
            ClientNameTb.BorderStyle = BorderStyle.FixedSingle;
            ClientNameTb.Location = new Point(22, 209);
            ClientNameTb.Multiline = true;
            ClientNameTb.Name = "ClientNameTb";
            ClientNameTb.Size = new Size(172, 28);
            ClientNameTb.TabIndex = 27;
            // 
            // PrintBtn
            // 
            PrintBtn.BackColor = Color.SlateGray;
            PrintBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrintBtn.ForeColor = Color.White;
            PrintBtn.Location = new Point(785, 496);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(123, 38);
            PrintBtn.TabIndex = 20;
            PrintBtn.Text = "Print";
            PrintBtn.UseVisualStyleBackColor = false;
            PrintBtn.Click += PrintBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SlateGray;
            label3.Location = new Point(202, 122);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 12;
            label3.Text = "Quantity";
            // 
            // BqtyTb
            // 
            BqtyTb.BorderStyle = BorderStyle.FixedSingle;
            BqtyTb.Location = new Point(200, 150);
            BqtyTb.Multiline = true;
            BqtyTb.Name = "BqtyTb";
            BqtyTb.Size = new Size(93, 28);
            BqtyTb.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(999, 11);
            label8.Name = "label8";
            label8.Size = new Size(22, 23);
            label8.TabIndex = 10;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // AddToBillBtn
            // 
            AddToBillBtn.BackColor = Color.SlateGray;
            AddToBillBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddToBillBtn.ForeColor = Color.White;
            AddToBillBtn.Location = new Point(22, 254);
            AddToBillBtn.Name = "AddToBillBtn";
            AddToBillBtn.Size = new Size(150, 38);
            AddToBillBtn.TabIndex = 8;
            AddToBillBtn.Text = "Add to bill";
            AddToBillBtn.UseVisualStyleBackColor = false;
            AddToBillBtn.Click += AddToBillBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SlateGray;
            label2.Location = new Point(22, 124);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 5;
            label2.Text = "Book Name";
            // 
            // BTitleTb
            // 
            BTitleTb.BorderStyle = BorderStyle.FixedSingle;
            BTitleTb.Enabled = false;
            BTitleTb.Location = new Point(22, 150);
            BTitleTb.Multiline = true;
            BTitleTb.Name = "BTitleTb";
            BTitleTb.Size = new Size(172, 28);
            BTitleTb.TabIndex = 3;
            BTitleTb.TextChanged += BTitleTb_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(474, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SlateGray;
            label1.Location = new Point(406, 11);
            label1.Name = "label1";
            label1.Size = new Size(190, 40);
            label1.TabIndex = 1;
            label1.Text = "Book Shop";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1298, 628);
            Controls.Add(panel1);
            Controls.Add(panel2);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Billing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Billing_Load;
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BillDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)BookDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel7;
        private Label label10;
        private Panel panel1;
        private Label label5;
        private PictureBox pictureBox2;
        private Label label4;
        public Button ResetBillBtn;
        private Panel panel2;
        public Button PrintBtn;
        private Label label3;
        private TextBox BqtyTb;
        private Label label8;
        public Button AddToBillBtn;
        private Label label2;
        private TextBox BTitleTb;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label6;
        private TextBox PriceTb;
        private Label label7;
        private TextBox ClientNameTb;
        private Label label9;
        private Label TotalLbl;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label UserNameLbl;
        private PictureBox UserIcon;
        private TextBox ContactUsLbl;
        private Guna.UI2.WinForms.Guna2DataGridView BillDGV;
        private Guna.UI2.WinForms.Guna2DataGridView BookDGV;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
    }
}