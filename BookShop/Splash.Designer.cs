namespace BookShop
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            label2 = new Label();
            Myprogress = new ProgressBar();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            Percentage = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(12, 362);
            label2.Name = "label2";
            label2.Size = new Size(148, 34);
            label2.TabIndex = 10;
            label2.Text = "Loading...";
            // 
            // Myprogress
            // 
            Myprogress.ForeColor = Color.SlateGray;
            Myprogress.Location = new Point(12, 409);
            Myprogress.Name = "Myprogress";
            Myprogress.Size = new Size(776, 31);
            Myprogress.TabIndex = 9;
            Myprogress.Click += Myprogress_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(283, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(306, 11);
            label1.Name = "label1";
            label1.Size = new Size(157, 34);
            label1.TabIndex = 7;
            label1.Text = "Book Shop";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Percentage
            // 
            Percentage.AutoSize = true;
            Percentage.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Percentage.ForeColor = Color.DimGray;
            Percentage.Location = new Point(166, 362);
            Percentage.Name = "Percentage";
            Percentage.Size = new Size(38, 33);
            Percentage.TabIndex = 11;
            Percentage.Text = "%";
            Percentage.Click += label3_Click;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(Percentage);
            Controls.Add(label2);
            Controls.Add(Myprogress);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ProgressBar Myprogress;
        private PictureBox pictureBox1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label Percentage;
    }
}