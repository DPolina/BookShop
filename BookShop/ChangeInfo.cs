using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookShop
{
    public partial class ChangeInfo : Form
    {
        public ChangeInfo()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dapol\OneDrive\Документы\BookShopDb.mdf;Integrated Security=True;Connect Timeout=30");
        public static string username = Login.UserName;

        private void button4_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || AddTb.Text == "" || PassTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into UserTbl values('" + UnameTb.Text + "','" + PhoneTb.Text + "','" + AddTb.Text + "','" + PassTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Info Edited Successfully");

                    string query1 = "DELETE FROM UserTbl WHERE UName = @username";
                    using (SqlCommand cmd1 = new SqlCommand(query1, Con))
                    {
                        cmd1.Parameters.AddWithValue("@username", username);

                        //MessageBox.Show("User Info Deleted Successfully");
                        //Con.Open();
                        cmd1.ExecuteNonQuery();
                    }
                    Con.Close();
                    Reset();

                    UserInfo Obj = new UserInfo();
                    Obj.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CancelLbl_Click(object sender, EventArgs e)
        {
            UserInfo Obj = new UserInfo();
            Obj.Show();
            this.Hide();
        }

        private void Reset()
        {
            UnameTb.Text = "";
            PassTb.Text = "";
            PhoneTb.Text = "";
            AddTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
