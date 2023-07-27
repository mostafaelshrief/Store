using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using Microsoft.Data.SqlClient.DataClassification;
using DGVPrinterHelper;
using DGVPrinterHelper;
using System.Net.NetworkInformation;

namespace المخزن
{
    public partial class Source : Form
    {

        public Source()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Leader\Downloads\Soter-master\المخزن\Database1.mdf;Integrated Security=True");


        private void label9_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void Source_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Category form = new Category();
            form.Show();
            this.Hide();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ItemName.Text == "" || itemEnter.Text == "" || lastMonthItem.Text == "" ||
               label10.Text == "" || itemPrice.Text == "")
            {
                MessageBox.Show("يجب اكمال المعلومات الناقصه");
            }

            else
            {
                try
                {
                    Con.Open();
                    String query = "insert into ItemTbl values(N'" + ItemName.Text + "','" + itemEnter.Text + "','" + lastMonthItem.Text + "','" + label10.Text + "','" + itemPrice.Text + "','" + label7.Text + "')";
                    SqlCommand cmd = new SqlCommand("INSERT INTO ItemTbl (الاسم,دخول,الباقى,الكميه,السعر,الاجمالى) VALUES " +
                        "(@الاسم,@دخول,@الباقى,@الكميه,@السعر,@الاجمالى)", Con);
                    cmd.Parameters.AddWithValue("@الاسم", ItemName.Text);
                    cmd.Parameters.AddWithValue("@دخول", itemEnter.Text);
                    cmd.Parameters.AddWithValue("@الباقى", lastMonthItem.Text);
                    cmd.Parameters.AddWithValue("@الكميه", label10.Text);
                    cmd.Parameters.AddWithValue("@السعر", itemPrice.Text);
                    cmd.Parameters.AddWithValue("@الاجمالى", label7.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تمت الاضافه");

                    Con.Close();
                    populate();
                }
                catch (Exception)
                {
                    throw;
                }



            }
        }
        private void populate()
        {
            Con.Open();
            String query = "select * from ItemTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (ItemName.Text == "")
            {
                MessageBox.Show(" اسم العنصر مفقود");
            }
            else
            {
                try
                {
                    Con.Open();
                    String query = "delete from ItemTbl where الاسم=N'" + ItemName.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تم مسح العنصر");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        double total, lastMonth;
        String totalPrice, totalLastMonth;

        private void button5_Click(object sender, EventArgs e)
        {
            DGVPrinter dgvprinter = new DGVPrinter();
            dgvprinter.Title = "المخزن جرد";
            dgvprinter.Footer = "بضاعه المخزن";
            dgvprinter.PageNumbers = true;
            dgvprinter.PrintDataGridView(dataGridView1);
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double totin = 0.0;
            double totout = 0.0;
            double profit = 0.0;
            string TotalProfit = "";



            if (dataGridView1.Rows[0].Cells[6].Value == "Null")
            {
                label11.Text = totin.ToString();

            }

            else if (dataGridView1.Rows[0].Cells[7].Value == "Null")
            {
                label13.Text = totout.ToString();
            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    totin += Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
                    totout += Convert.ToDouble(dataGridView1.Rows[i].Cells[8].Value);
                }
                label11.Text = totin.ToString();
                label13.Text = totout.ToString();
            }
            profit = Convert.ToDouble(label11.Text) - Convert.ToDouble(label13.Text);
            TotalProfit = profit.ToString();
            label15.Text = TotalProfit.ToString();

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5 & e.Value != null)
            {
                int sum1 = Convert.ToInt32(e.Value);
                if (sum1 < 5)
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                else if (sum1 < 15)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Featchdata();
        }

        private void Featchdata()
        {
            Con.Open();
            string query = "select * from ItemTbl where الاسم=N'" + ItemName.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ItemName.Text = dr["الاسم"].ToString();
                itemPrice.Text = dr["السعر"].ToString();
                label10.Text = dr["الكميه"].ToString();
                lastMonthItem.Text = dr["الباقى"].ToString();


            }
            Con.Close();
        }
        double real, newEnter, updateTotal;
        string STrEnter, STrTotal;
        private void button2_Click(object sender, EventArgs e)
        {
            real = Convert.ToInt16(itemEnter.Text) + Convert.ToInt16(label10.Text);
            label10.Text = real.ToString();
            Con.Open();
            string query1 = "select * from ItemTbl where الاسم=N'" + ItemName.Text + "'";
            SqlCommand cmd1 = new SqlCommand(query1, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                STrEnter = dr["دخول"].ToString();
                STrTotal = dr["الاجمالى"].ToString();
            }
            newEnter = Convert.ToDouble(STrEnter) + Convert.ToDouble(itemEnter.Text);
            updateTotal = Convert.ToDouble(STrTotal) + (Convert.ToDouble(itemPrice.Text) * Convert.ToDouble(itemEnter.Text));
            string query = "update ItemTbl set الاسم=N'" + ItemName.Text + "',دخول='" + newEnter + "',الباقى='" + lastMonthItem.Text + "',الكميه='" + label10.Text + "',السعر='" + itemPrice.Text + "',الاجمالى='" + updateTotal + "' where الاسم=N'" + ItemName.Text + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            MessageBox.Show("تم التعديل بنجاح");
            Con.Close();
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lastMonth = Convert.ToDouble(itemEnter.Text) + Convert.ToDouble(lastMonthItem.Text);
            totalLastMonth = Convert.ToString(lastMonth);
            total = Convert.ToDouble(label10.Text) * Convert.ToDouble(itemPrice.Text);
            totalPrice = Convert.ToString(total);
            label7.Text = totalPrice;
            label10.Text = totalLastMonth;
            populate();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
