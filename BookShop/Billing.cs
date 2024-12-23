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

namespace BookShop
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dapol\OneDrive\Документы\BookShopDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from BookTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        int key = 0, stock = 0;
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (BookDGV.SelectedRows.Count > 0)
            {
                BTitleTb.Text = BookDGV.SelectedRows[0].Cells[1].Value.ToString();
                //BqtyTb.Text = BookDGV.SelectedRows[0].Cells[2].Value.ToString();
                PriceTb.Text = BookDGV.SelectedRows[0].Cells[5].Value.ToString();
            }
            else
            {
                MessageBox.Show("Error: SelectedRows = " + BookDGV.SelectedRows.Count.ToString());
            }

            if (BTitleTb.Text == "")
            {
                key = 0;
                stock = 0;
            }
            else
            {
                key = Convert.ToInt32(BookDGV.SelectedRows[0].Cells[0].Value.ToString());
                stock = Convert.ToInt32(BookDGV.SelectedRows[0].Cells[4].Value.ToString());
            }
        }

        private void Reset()
        {
            BTitleTb.Text = "";
            BqtyTb.Text = "";
            PriceTb.Text = "";
            ClientNameTb.Text = "";
        }

        private void ResetBillBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void UpdateBook()
        {
            int newQty = stock - Convert.ToInt32(BqtyTb.Text);
            try
            {
                Con.Open();
                string query = "update BookTbl set BQty = " + newQty + " where BId=" + key + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Book Updated Successfully");
                Con.Close();
                populate();
                //Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int n = 0;
        int Grdtotal = 0;
        private void AddToBillBtn_Click(object sender, EventArgs e)
        {
            if (BqtyTb.Text == "" || Convert.ToInt32(BqtyTb.Text) > stock)
            {
                MessageBox.Show("Empty stock");
            }
            else
            {
                int total = Convert.ToInt32(BqtyTb.Text) * Convert.ToInt32(PriceTb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = BTitleTb.Text;
                newRow.Cells[2].Value = BqtyTb.Text;
                newRow.Cells[3].Value = PriceTb.Text;
                newRow.Cells[4].Value = total;
                BillDGV.Rows.Add(newRow);
                n++;
                UpdateBook();
                Grdtotal = Grdtotal + total;
                TotalLbl.Text = "$" + Grdtotal;
            }
        }

        private void TotalLbl_Click(object sender, EventArgs e)
        {

        }

        int prodid, prodqty, prodprice, total, pos = 60;
        string prodname;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Book shop", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(80));
            e.Graphics.DrawString("ID PRODUCT PRICE QUANTITY TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(26, 40));
            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                prodname = "" + row.Cells["Column2"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                total = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(26, pos));
                e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(45, pos));
                e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(120, pos));
                e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(170, pos));
                e.Graphics.DrawString("" + total, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(235, pos));
                pos = pos + 20;
            }
            e.Graphics.DrawString("Grand Total: $" + Grdtotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(60, pos + 50));
            e.Graphics.DrawString("***********Book Store***********", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(40, pos + 85));
            BillDGV.Rows.Clear();
            BillDGV.Refresh();
            pos = 100;
            Grdtotal = 0;
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (ClientNameTb.Text == "" || BTitleTb.Text == "")
            {
                MessageBox.Show("Select Client Name");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BillTbl values('" + UserNameLbl.Text + "','" + ClientNameTb.Text + "'," + Grdtotal + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Saved Successfully");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            UserNameLbl.Text = Login.UserName;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BTitleTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void ContactUsLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can contact us by phone: +375-44-533-43-38");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void UserIcon_Click(object sender, EventArgs e)
        {

        }

        private void UsernameLbl_Click(object sender, EventArgs e)
        {
            UserInfo Obj = new UserInfo();
            Obj.Show();
            this.Hide();
        }
    }
}
