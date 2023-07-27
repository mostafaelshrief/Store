using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace المخزن
{
    public partial class Indebtedness : Form
    {
        public Indebtedness()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Indebtedness_Hotel hotel = new Indebtedness_Hotel();
            hotel.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Indebtedness_Hotel hotel = new Indebtedness_Hotel();
            hotel.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Indebtedness_Ketchen indebtedness_Ketchen = new Indebtedness_Ketchen();
            indebtedness_Ketchen.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Indebtedness_Ketchen indebtedness_Ketchen = new Indebtedness_Ketchen();
            indebtedness_Ketchen.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Indebtedness_Resturant resturant = new Indebtedness_Resturant();
            resturant.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Indebtedness_Resturant resturant = new Indebtedness_Resturant();
            resturant.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Indebtedness_Stuff_Resturant _Stuff_Resturant = new Indebtedness_Stuff_Resturant();
            _Stuff_Resturant.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Indebtedness_Stuff_Resturant _Stuff_Resturant = new Indebtedness_Stuff_Resturant();
            _Stuff_Resturant.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Indebtedness_yacht _Yacht = new Indebtedness_yacht();
            _Yacht.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Indebtedness_yacht _Yacht = new Indebtedness_yacht();
            _Yacht.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            OutSide_IndetednessFrame outSide = new OutSide_IndetednessFrame();
            outSide.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            OutSide_IndetednessFrame outSide = new OutSide_IndetednessFrame();
            outSide.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Indebtedness_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
