using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace المخزن
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Leader\Downloads\Soter-master\المخزن\Database1.mdf;Integrated Security=True");

        private void FeatchData1()
        {
            if (ItemName.Text == "")
            {
                MessageBox.Show("ادخل اسم العنصر");
            }
            else
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
                    RealAmount.Text = dr["الكميه"].ToString();


                }

                Con.Close();
            }

        }
        private void populate()
        {
            Con.Open();
            String query = "select * from HistoryTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populate1()
        {
            Con.Open();
            String query = "select * from [Table]";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FeatchData1();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            populate();
            populate1();
        }

        double TotalAmount, TotalPrice, Currenttotal, totalOut;
        string TotalRealAmount, TotalRealPrice, TotalItemOut;
        string StrTotalOut, StrTotalPrice;
        double TotalStrOut, TotalStrPrice;
        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ItemName.Text == "")
                {
                    MessageBox.Show("ادخل اسم العنصر");
                }
                else
                {

                    Con.Open();
                    String query = "delete from [Table] where الاسم=N'" + ItemName.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تم الحذف");
                    Con.Close();
                    populate1();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                String query = "delete from HistoryTable where الاسم=N'" + ItemName.Text + "' AND الفاتورة=N'" + BillSelectedlist.SelectedItem.ToString() + "' AND خروج=N'" + itemOut.Text + "' AND الوقت='" + dateTimePicker1.Value.Date + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("تم الحذف");
                Con.Close();
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        double current;
        string Current;


        private void CountTotal_Click(object sender, EventArgs e)
        {

        }

        private void Total_Click(object sender, EventArgs e)
        {
            double tot = 0.0;
            CountTotal.Text = "0";

            CountTotal.Text = tot.ToString();

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                tot += Convert.ToDouble(dataGridView2.Rows[i].Cells[5].Value);
            }
            CountTotal.Text = tot.ToString();


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DGVPrinter dgvprinter = new DGVPrinter();
            dgvprinter.Title = "الفاتورة";
            dgvprinter.SubTitle = string.Format(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
            dgvprinter.Footer = "الاجمالى" + CountTotal.Text;
            dgvprinter.PageNumbers = true;
            dgvprinter.PrintDataGridView(dataGridView2);
            populate();

        }

        private void button6_Click(object sender, EventArgs e)
        {

            DGVPrinter dgvprinter = new DGVPrinter();
            dgvprinter.Title = "الفاتورة";
            dgvprinter.SubTitle = string.Format(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
            dgvprinter.Footer = "بينجوين";
            dgvprinter.PageNumbers = true;
            dgvprinter.PrintDataGridView(dataGridView1);
            populate1();

        }


        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            String query = "delete from [Table] where الفاتورة=N'" + BillSelectedlist.SelectedItem.ToString() + "'; ";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("تم الحذف");
            Con.Close();
            populate1();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Bill_Load_1(object sender, EventArgs e)
        {
            populate();
            populate1();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            /*
             *      Con.Open();
                    String query = "insert into ItemTbl values(N'" + ItemName.Text + "','" + itemEnter.Text + "','" + lastMonthItem.Text + "','" + label10.Text + "','" + itemPrice.Text + "','" + label7.Text + "')";
                SqlCommand cmd = new SqlCommand("INSERT INTO ItemTbl (الاسم,دخول,الباقى,الكميه,السعر,الاجمالى) VALUES " +
                    "(@الاسم,@دخول,@الباقى,@الكميه,@السعر,@الاجمالى)", Con);
                cmd.Parameters.AddWithValue("@الاسم",  ItemName.Text);
                cmd.Parameters.AddWithValue("@دخول", itemEnter.Text);
                cmd.Parameters.AddWithValue("@الباقى", lastMonthItem.Text);
                cmd.Parameters.AddWithValue("@الكميه", label10.Text);
                cmd.Parameters.AddWithValue("@السعر", itemPrice.Text);
                cmd.Parameters.AddWithValue("@الاجمالى", label7.Text);
                cmd.ExecuteNonQuery();
               
             */

            if (itemOut.Text == "" || ItemName.Text == "" || BillSelectedlist.SelectedItem.ToString() == "")
            {
                MessageBox.Show("ادخل كل امعلومات");
            }
            else
            {
                current = Convert.ToDouble(itemPrice.Text) * Convert.ToDouble(itemOut.Text);
                Current = Convert.ToString(current);
                Con.Open();
                String query = "insert into HistoryTable values(N'" + BillSelectedlist.SelectedItem.ToString() + "','" + ItemName.Text + "','" + itemPrice.Text + "','" + itemOut.Text + "','" + dateTimePicker1.Value.Date + "','" + CountTotal.Text + "')";
                SqlCommand cmd = new SqlCommand("INSERT INTO HistoryTable(الفاتورة,الاسم,السعر,خروج,الوقت,الاجمالى) VALUES" + "(@الفاتورة,@الاسم,@السعر,@خروج,@الوقت,@الاجمالى)", Con);
                cmd.Parameters.AddWithValue("@الفاتورة", BillSelectedlist.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@الاسم", ItemName.Text);
                cmd.Parameters.AddWithValue("@السعر", itemPrice.Text);
                cmd.Parameters.AddWithValue("@خروج", itemOut.Text);
                cmd.Parameters.AddWithValue("@الوقت", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@الاجمالى", Current);
                String newquery = "insert into [Table] values(N'" + BillSelectedlist.SelectedItem.ToString() + "','" + ItemName.Text + "','" + itemPrice.Text + "','" + itemOut.Text + "','" + dateTimePicker1.Value.Date + "','" + CountTotal.Text + "')";
                SqlCommand cmd1 = new SqlCommand("INSERT INTO [Table](الفاتورة,الاسم,السعر,خروج,الوقت,الاجمالى) VALUES" + "(@الفاتورة,@الاسم,@السعر,@خروج,@الوقت,@الاجمالى)", Con);
                cmd1.Parameters.AddWithValue("@الفاتورة", BillSelectedlist.SelectedItem.ToString());
                cmd1.Parameters.AddWithValue("@الاسم", ItemName.Text);
                cmd1.Parameters.AddWithValue("@السعر", itemPrice.Text);
                cmd1.Parameters.AddWithValue("@خروج", itemOut.Text);
                cmd1.Parameters.AddWithValue("@الوقت", dateTimePicker1.Value.Date);
                cmd1.Parameters.AddWithValue("@الاجمالى", Current);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("تم الاضافه " +
                    " اضعط على زرار عدل");
                Con.Close();
                populate();
                populate1();
                //RealAmount
                TotalAmount = Convert.ToDouble(RealAmount.Text) - Convert.ToDouble(itemOut.Text);
                TotalRealAmount = Convert.ToString(TotalAmount);
                TotalAmount += TotalAmount;
                //TotalPrice
                Currenttotal = Convert.ToDouble(itemPrice.Text) * Convert.ToDouble(itemOut.Text);


                Con.Open();
                string query1 = "select * from ItemTbl where الاسم=N'" + ItemName.Text + "'";
                SqlCommand cmd12 = new SqlCommand(query1, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd12);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    StrTotalOut = dr["خروج"].ToString();
                    StrTotalPrice = dr["totalOut"].ToString();

                }
                TotalStrOut = Convert.ToDouble(StrTotalOut) + Convert.ToDouble(itemOut.Text);
                TotalStrPrice = Convert.ToDouble(StrTotalPrice) + Currenttotal;
                string query4 = "update ItemTbl set خروج='" + TotalStrOut + "',الكميه='" + TotalRealAmount + "',totalOut='" + TotalStrPrice + "' where الاسم=N'" + ItemName.Text + "';";
                SqlCommand cmd4 = new SqlCommand(query4, Con);
                cmd4.ExecuteNonQuery();
                cmd12.ExecuteNonQuery();
                MessageBox.Show("Data updateed successfully");
                Con.Close();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
