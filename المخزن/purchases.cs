using DGVPrinterHelper;
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

namespace المخزن
{
    public partial class purchases : Form
    {
        public purchases()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Leader\Downloads\Soter-master\المخزن\Database1.mdf;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void purchases_Load(object sender, EventArgs e)
        {
            populate();     
        }
        double tot;
        private void button1_Click(object sender, EventArgs e)
        {
            tot=Convert.ToDouble(Amount.Text)*Convert.ToDouble(Price.Text);
            totalLBL.Text = tot.ToString();
            Con.Open();
            String query = "insert into m4triat values(N'" + dateTimePicker1.Value.ToString() + "','" + Amount.Text + "','" + ItemName.Text + "','" + Price.Text + "','"+totalLBL.Text+"')";
            SqlCommand cmd = new SqlCommand("INSERT INTO m4triat (الصنف,الكميه,السعر,التاريخ,الاجمالى) VALUES " +
                "(@الصنف,@الكميه,@السعر,@التاريخ,@الاجمالى)", Con);
            cmd.Parameters.AddWithValue("@الصنف", ItemName.Text);
            cmd.Parameters.AddWithValue("@الكميه", Amount.Text);
            cmd.Parameters.AddWithValue("@السعر", Price.Text);
            cmd.Parameters.AddWithValue("@التاريخ", dateTimePicker1.Value.ToString());
            cmd.Parameters.AddWithValue("@الاجمالى", totalLBL.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("تمت الاضافه");

            Con.Close();
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DGVPrinter dgvprinter = new DGVPrinter();
            dgvprinter.Title = " جدول المشتريات";
            dgvprinter.SubTitle = string.Format(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
            dgvprinter.PorportionalColumns = true;
            dgvprinter.Footer = TotalPrice.Text;
            dgvprinter.FooterSpacing = 20;
            dgvprinter.PageNumbers = true; ;
            dgvprinter.PrintDataGridView(dataGridView1);
            populate();
        }
        double totin;
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[0].Cells[4].Value == "Null")
            {
                label11.Text = totin.ToString();

            }
            else
            {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                totin += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }
            TotalPrice.Text = totin.ToString();
            }
        }
        private void populate()
        {
            Con.Open();
            String query = "select * from m4triat";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
