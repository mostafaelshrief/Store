namespace المخزن
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Category source = new Category();
            source.Show();
            this.Hide();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Source source = new Source();
            source.Show();
            this.Hide();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Search search= new Search();
            search.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            this.Hide();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bill bill= new Bill();
            bill.Show();
            this.Hide();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Indebtedness indebtedness=new Indebtedness();
            indebtedness.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            purchases purchases = new purchases();
            purchases.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            purchases purchases = new purchases();
            purchases.Show();
            this.Hide();
        }
    }
}