
namespace BookShop
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label4 = new Label();
            UDeleteBtn = new Button();
            UEditBtn = new Button();
            label13 = new Label();
            PassTb = new TextBox();
            label12 = new Label();
            AddTb = new TextBox();
            label3 = new Label();
            PhoneTb = new TextBox();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel7 = new Panel();
            label10 = new Label();
            panel6 = new Panel();
            label9 = new Label();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            label8 = new Label();
            USaveBtn = new Button();
            label2 = new Label();
            UnameTb = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            ResetBtn = new Button();
            UserDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SlateGray;
            label4.Location = new Point(415, 290);
            label4.Name = "label4";
            label4.Size = new Size(118, 34);
            label4.TabIndex = 24;
            label4.Text = "User List";
            label4.Click += label4_Click;
            // 
            // UDeleteBtn
            // 
            UDeleteBtn.BackColor = Color.SlateGray;
            UDeleteBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UDeleteBtn.ForeColor = Color.White;
            UDeleteBtn.Location = new Point(482, 225);
            UDeleteBtn.Name = "UDeleteBtn";
            UDeleteBtn.Size = new Size(147, 38);
            UDeleteBtn.TabIndex = 21;
            UDeleteBtn.Text = "Delete";
            UDeleteBtn.UseVisualStyleBackColor = false;
            UDeleteBtn.Click += UDeleteBtn_Click;
            // 
            // UEditBtn
            // 
            UEditBtn.BackColor = Color.SlateGray;
            UEditBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UEditBtn.ForeColor = Color.White;
            UEditBtn.Location = new Point(329, 226);
            UEditBtn.Name = "UEditBtn";
            UEditBtn.Size = new Size(147, 38);
            UEditBtn.TabIndex = 20;
            UEditBtn.Text = "Edit";
            UEditBtn.UseVisualStyleBackColor = false;
            UEditBtn.Click += UEditBtn_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.SlateGray;
            label13.Location = new Point(718, 143);
            label13.Name = "label13";
            label13.Size = new Size(103, 23);
            label13.TabIndex = 19;
            label13.Text = "Password";
            label13.Click += label13_Click;
            // 
            // PassTb
            // 
            PassTb.BorderStyle = BorderStyle.FixedSingle;
            PassTb.Location = new Point(718, 169);
            PassTb.Multiline = true;
            PassTb.Name = "PassTb";
            PassTb.Size = new Size(210, 28);
            PassTb.TabIndex = 18;
            PassTb.TextChanged += PassTb_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.SlateGray;
            label12.Location = new Point(485, 143);
            label12.Name = "label12";
            label12.Size = new Size(88, 23);
            label12.TabIndex = 17;
            label12.Text = "Address";
            label12.Click += label12_Click;
            // 
            // AddTb
            // 
            AddTb.BorderStyle = BorderStyle.FixedSingle;
            AddTb.Location = new Point(485, 169);
            AddTb.Multiline = true;
            AddTb.Name = "AddTb";
            AddTb.Size = new Size(210, 28);
            AddTb.TabIndex = 16;
            AddTb.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SlateGray;
            label3.Location = new Point(260, 143);
            label3.Name = "label3";
            label3.Size = new Size(72, 23);
            label3.TabIndex = 12;
            label3.Text = "Phone";
            label3.Click += label3_Click;
            // 
            // PhoneTb
            // 
            PhoneTb.BorderStyle = BorderStyle.FixedSingle;
            PhoneTb.Location = new Point(260, 169);
            PhoneTb.Multiline = true;
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(210, 28);
            PhoneTb.TabIndex = 11;
            PhoneTb.TextChanged += PhoneTb_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SlateGray;
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
            panel1.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label10);
            panel7.ForeColor = Color.Silver;
            panel7.Location = new Point(21, 537);
            panel7.Name = "panel7";
            panel7.Size = new Size(100, 50);
            panel7.TabIndex = 21;
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
            panel6.Controls.Add(label9);
            panel6.Location = new Point(21, 310);
            panel6.Name = "panel6";
            panel6.Size = new Size(259, 63);
            panel6.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SlateGray;
            label9.Location = new Point(17, 12);
            label9.Name = "label9";
            label9.Size = new Size(200, 40);
            label9.TabIndex = 11;
            label9.Text = "Dashboard";
            label9.Click += label9_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SlateGray;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(21, 225);
            panel5.Name = "panel5";
            panel5.Size = new Size(259, 63);
            panel5.TabIndex = 18;
            panel5.Paint += panel5_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(11, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 43;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(62, 14);
            label7.Name = "label7";
            label7.Size = new Size(96, 40);
            label7.TabIndex = 11;
            label7.Text = "Users";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SlateGray;
            label6.Location = new Point(17, 10);
            label6.Name = "label6";
            label6.Size = new Size(111, 40);
            label6.TabIndex = 11;
            label6.Text = "Books";
            label6.Click += label6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(935, 7);
            label8.Name = "label8";
            label8.Size = new Size(22, 23);
            label8.TabIndex = 10;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // USaveBtn
            // 
            USaveBtn.BackColor = Color.SlateGray;
            USaveBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            USaveBtn.ForeColor = Color.White;
            USaveBtn.Location = new Point(176, 226);
            USaveBtn.Name = "USaveBtn";
            USaveBtn.Size = new Size(147, 38);
            USaveBtn.TabIndex = 8;
            USaveBtn.Text = "Save";
            USaveBtn.UseVisualStyleBackColor = false;
            USaveBtn.Click += USaveBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SlateGray;
            label2.Location = new Point(33, 143);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 5;
            label2.Text = "User Name";
            label2.Click += label2_Click;
            // 
            // UnameTb
            // 
            UnameTb.BorderStyle = BorderStyle.FixedSingle;
            UnameTb.Location = new Point(33, 169);
            UnameTb.Multiline = true;
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(210, 28);
            UnameTb.TabIndex = 3;
            UnameTb.TextChanged += UnameTb_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(437, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SlateGray;
            label1.Location = new Point(393, 19);
            label1.Name = "label1";
            label1.Size = new Size(157, 34);
            label1.TabIndex = 1;
            label1.Text = "Book Shop";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(ResetBtn);
            panel2.Controls.Add(UserDGV);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(UDeleteBtn);
            panel2.Controls.Add(UEditBtn);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(PassTb);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(AddTb);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(PhoneTb);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(USaveBtn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(UnameTb);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(320, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(965, 604);
            panel2.TabIndex = 5;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.SlateGray;
            ResetBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResetBtn.ForeColor = Color.White;
            ResetBtn.Location = new Point(635, 225);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(147, 38);
            ResetBtn.TabIndex = 47;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // UserDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            UserDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            UserDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            UserDGV.ColumnHeadersHeight = 25;
            UserDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            UserDGV.DefaultCellStyle = dataGridViewCellStyle3;
            UserDGV.GridColor = Color.White;
            UserDGV.Location = new Point(15, 338);
            UserDGV.Name = "UserDGV";
            UserDGV.RowHeadersVisible = false;
            UserDGV.RowHeadersWidth = 51;
            UserDGV.RowTemplate.Height = 24;
            UserDGV.Size = new Size(931, 249);
            UserDGV.TabIndex = 46;
            UserDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            UserDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            UserDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            UserDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            UserDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            UserDGV.ThemeStyle.BackColor = Color.White;
            UserDGV.ThemeStyle.GridColor = Color.White;
            UserDGV.ThemeStyle.HeaderStyle.BackColor = Color.SlateGray;
            UserDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            UserDGV.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            UserDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            UserDGV.ThemeStyle.HeaderStyle.Height = 25;
            UserDGV.ThemeStyle.ReadOnly = false;
            UserDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            UserDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            UserDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            UserDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            UserDGV.ThemeStyle.RowsStyle.Height = 24;
            UserDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            UserDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            UserDGV.CellContentClick += UserDGV_CellContentClick;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(15, 18);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 41;
            pictureBox4.TabStop = false;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1298, 628);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        private void PhoneTb_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void PassTb_TextChanged(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        #endregion
        private Label label4;
        //public Button ResetBtn;
        public Button UDeleteBtn;
        public Button UEditBtn;
        private Label label13;
        private TextBox PassTb;
        private Label label12;
        private TextBox AddTb;
        private Label label3;
        private TextBox PhoneTb;
        private Label label5;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label8;
        public Button USaveBtn;
        private Label label2;
        private TextBox UnameTb;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Panel panel6;
        private Label label9;
        private Panel panel5;
        private Label label7;
        private Panel panel3;
        private Label label6;
        private Panel panel7;
        private Label label10;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2DataGridView UserDGV;
        public Button ResetBtn;
    }
}