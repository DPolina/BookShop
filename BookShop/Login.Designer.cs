namespace BookShop
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            NewHereLbl = new Label();
            AdminLoginLbl = new Label();
            label8 = new Label();
            LoginBtn = new Button();
            UPassTb = new TextBox();
            label3 = new Label();
            label2 = new Label();
            UnameTb = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 426);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SlateGray;
            label7.Location = new Point(18, 248);
            label7.Name = "label7";
            label7.Size = new Size(244, 34);
            label7.TabIndex = 12;
            label7.Text = "Excellent Service";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SlateGray;
            label6.Location = new Point(21, 181);
            label6.Name = "label6";
            label6.Size = new Size(241, 34);
            label6.TabIndex = 11;
            label6.Text = "Large Collection";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SlateGray;
            label5.Location = new Point(64, 117);
            label5.Name = "label5";
            label5.Size = new Size(148, 34);
            label5.TabIndex = 10;
            label5.Text = "Nice Staff";
            label5.Click += label5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(NewHereLbl);
            panel2.Controls.Add(AdminLoginLbl);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(LoginBtn);
            panel2.Controls.Add(UPassTb);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(UnameTb);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(304, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(484, 426);
            panel2.TabIndex = 1;
            // 
            // NewHereLbl
            // 
            NewHereLbl.AutoSize = true;
            NewHereLbl.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            NewHereLbl.ForeColor = Color.DimGray;
            NewHereLbl.Location = new Point(322, 174);
            NewHereLbl.Name = "NewHereLbl";
            NewHereLbl.Size = new Size(118, 23);
            NewHereLbl.TabIndex = 12;
            NewHereLbl.Text = "New here?";
            NewHereLbl.Click += NewHereLbl_Click;
            // 
            // AdminLoginLbl
            // 
            AdminLoginLbl.AutoSize = true;
            AdminLoginLbl.Font = new Font("Century Gothic", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            AdminLoginLbl.ForeColor = Color.DimGray;
            AdminLoginLbl.Location = new Point(264, 390);
            AdminLoginLbl.Name = "AdminLoginLbl";
            AdminLoginLbl.Size = new Size(68, 21);
            AdminLoginLbl.TabIndex = 9;
            AdminLoginLbl.Text = "Admin";
            AdminLoginLbl.Click += AdminLoginLbl_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(457, 6);
            label8.Name = "label8";
            label8.Size = new Size(22, 23);
            label8.TabIndex = 10;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.SlateGray;
            LoginBtn.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(158, 335);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(282, 49);
            LoginBtn.TabIndex = 8;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // UPassTb
            // 
            UPassTb.BorderStyle = BorderStyle.FixedSingle;
            UPassTb.Location = new Point(158, 269);
            UPassTb.Multiline = true;
            UPassTb.Name = "UPassTb";
            UPassTb.PasswordChar = '*';
            UPassTb.Size = new Size(282, 39);
            UPassTb.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(23, 277);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 6;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(23, 216);
            label2.Name = "label2";
            label2.Size = new Size(111, 23);
            label2.TabIndex = 5;
            label2.Text = "UserName";
            label2.Click += label2_Click;
            // 
            // UnameTb
            // 
            UnameTb.BorderStyle = BorderStyle.FixedSingle;
            UnameTb.Location = new Point(158, 207);
            UnameTb.Multiline = true;
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(282, 41);
            UnameTb.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(187, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(173, 14);
            label1.Name = "label1";
            label1.Size = new Size(129, 27);
            label1.TabIndex = 1;
            label1.Text = "Book Shop";
            label1.Click += label1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox UnameTb;
        private PictureBox pictureBox1;
        private TextBox UPassTb;
        private Button LoginBtn;
        private Label AdminLoginLbl;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label NewHereLbl;
    }
}