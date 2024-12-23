namespace BookShop
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            panel1 = new Panel();
            CancelLbl = new Label();
            LoginBtn = new Button();
            UPassTb = new TextBox();
            AdminPassLbl = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(CancelLbl);
            panel1.Controls.Add(LoginBtn);
            panel1.Controls.Add(UPassTb);
            panel1.Controls.Add(AdminPassLbl);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(26, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 426);
            panel1.TabIndex = 0;
            // 
            // CancelLbl
            // 
            CancelLbl.AutoSize = true;
            CancelLbl.Font = new Font("Century Gothic", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            CancelLbl.ForeColor = Color.DimGray;
            CancelLbl.Location = new Point(346, 378);
            CancelLbl.Name = "CancelLbl";
            CancelLbl.Size = new Size(75, 21);
            CancelLbl.TabIndex = 12;
            CancelLbl.Text = "Cancel";
            CancelLbl.Click += CancelLbl_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.SlateGray;
            LoginBtn.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(243, 326);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(282, 49);
            LoginBtn.TabIndex = 11;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // UPassTb
            // 
            UPassTb.BorderStyle = BorderStyle.FixedSingle;
            UPassTb.Location = new Point(243, 260);
            UPassTb.Multiline = true;
            UPassTb.Name = "UPassTb";
            UPassTb.PasswordChar = '*';
            UPassTb.Size = new Size(282, 39);
            UPassTb.TabIndex = 10;
            // 
            // AdminPassLbl
            // 
            AdminPassLbl.AutoSize = true;
            AdminPassLbl.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminPassLbl.ForeColor = Color.DimGray;
            AdminPassLbl.Location = new Point(108, 268);
            AdminPassLbl.Name = "AdminPassLbl";
            AdminPassLbl.Size = new Size(103, 23);
            AdminPassLbl.TabIndex = 9;
            AdminPassLbl.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(293, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(284, 27);
            label1.Name = "label1";
            label1.Size = new Size(199, 37);
            label1.TabIndex = 3;
            label1.Text = "Admin Login";
            label1.Click += label1_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLog";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button LoginBtn;
        private TextBox UPassTb;
        private Label AdminPassLbl;
        private Label CancelLbl;
    }
}