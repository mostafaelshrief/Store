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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace المخزن
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Leader\Downloads\Soter-master\المخزن\Database1.mdf;Integrated Security=True");

        private void FeatchData()
        {
            Con.Open();
            string query = "select * from ItemTbl where الاسم=N'" + ItemName.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ItemIdlbl.Text = dr["الاسم"].ToString();
                ItemEnterlbl.Text = dr["دخول"].ToString();
                amountOutItem.Text = dr["خروج"].ToString();
                ItemAmountlbl.Text = dr["الباقى"].ToString();
                ItemReallbl.Text = dr["الكميه"].ToString();
                ItemPricelbl.Text = dr["السعر"].ToString();
                ItemTotallbl.Text = dr["الاجمالى"].ToString();
                totalItemOut.Text = dr["totalOut"].ToString();

                ItemIdlbl.Visible = true;
                ItemEnterlbl.Visible = true;
                amountOutItem.Visible = true;
                ItemAmountlbl.Visible = true;
                ItemReallbl.Visible = true;
                ItemPricelbl.Visible = true;
                ItemTotallbl.Visible = true;
                totalItemOut.Visible=true;
            }
            Con.Close();
        }
        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FeatchData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void ItemName_TextChanged(object sender, EventArgs e)
        {
            this.ItemName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ItemName.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchHistory searchHistory = new SearchHistory();
            searchHistory.Show();
            this.Hide();

        }
    }
}
