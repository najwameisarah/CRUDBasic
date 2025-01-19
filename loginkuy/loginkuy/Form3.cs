using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginkuy
{
    public partial class shape : Form
    {
        public shape()
        {
            InitializeComponent();
        }

        private void shape_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double nilai = Convert.ToDouble(textBox1.Text);
                double luas = nilai * nilai;
                double keliling = 4 * nilai;

                textBox2.Text = luas.ToString();
                textBox3.Text = keliling.ToString();
            }
            catch
            {
                MessageBox.Show("Input tidak valid");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double panjang = Convert.ToDouble(textBox4.Text);
                double lebar = Convert.ToDouble(textBox5.Text);
                double luas = panjang * lebar;
                double keliling = 2 * (panjang + lebar);

                textBox6.Text = luas.ToString();
                textBox7.Text = keliling.ToString();
            }
            catch
            {
                MessageBox.Show("Input tidak valid");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double alas = Convert.ToDouble(textBox8.Text);
                double tinggi = Convert.ToDouble(textBox9.Text);
                double luas = 0.5 * alas * tinggi;
                double keliling = alas + tinggi + Math.Sqrt(alas * alas + tinggi * tinggi); // Assuming a right triangle

                textBox10.Text = luas.ToString();
                textBox11.Text = keliling.ToString();
            }
            catch
            {
                MessageBox.Show("Input tidak valid");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FUtama FUTAMA = new FUtama();
            FUTAMA.Show();
            this.Hide();

        }
    }
 }

