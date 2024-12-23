using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dapol\OneDrive\Документы\BookShopDb.mdf;Integrated Security=True;Connect Timeout=30");

        public static string username = Login.UserName;
        public static string password = Login.Password;
        public static string phone = SignUp.UserName;
        public static string address = SignUp.Password;
        private void UserInfo_Load(object sender, EventArgs e)
        {
            UserNameLbl.Text = username;
            PasswordLbl.Text = password;
            PhoneLbl.Text = phone;
            AddressLbl.Text = address;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Billing Obj = new Billing();
            Obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete your account?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM UserTbl WHERE UName = @username";
                using (SqlCommand command = new SqlCommand(query, Con))
                {
                    command.Parameters.AddWithValue("@username", username);
                    Con.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Account Deleted Successfully");
                }

                Login Obj = new Login();
                Obj.Show();
                this.Hide();
            }
        }

        private void UEditBtn_Click(object sender, EventArgs e)
        {
            ChangeInfo Obj = new ChangeInfo();
            Obj.Show();
            this.Hide();
        }
    }
}
