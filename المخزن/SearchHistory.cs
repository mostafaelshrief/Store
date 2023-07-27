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
    public partial class SearchHistory : Form
    {
        public SearchHistory()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Leader\Downloads\Soter-master\المخزن\Database1.mdf;Integrated Security=True");
        private void SearchHistory_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void FeatchData()
        {
            Con.Open();
            string query = "select * from HistoryTbl Where الفاتورة=N'" + BillSelectedlist.SelectedItem.ToString() + "' ";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            listBox1.DataSource = dt;
            listBox2.DataSource = dt;
            listBox3.DataSource = dt;
            listBox4.DataSource = dt;
            listBox5.DataSource = dt;
            listBox1.DisplayMember = "الاسم";
            listBox2.DisplayMember = "السعر";
            listBox3.DisplayMember = "خروج";
            listBox4.DisplayMember = "الوقت";
            listBox5.DisplayMember = "الاجمالى";
            listBox1.ValueMember = "الاسم";
            listBox2.ValueMember = "السعر";
            listBox3.ValueMember = "خروج";
            listBox4.ValueMember = "الوقت";
            listBox5.ValueMember = "الاجمالى";


            Con.Close();
        }
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FeatchData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            this.Hide();
        }
    }
}
