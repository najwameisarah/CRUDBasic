using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace loginkuy
{
    public partial class Temperatur : Form
    {
        public Temperatur()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Temperatur_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Ensure that a valid input is entered
            double inputValue;
            if (double.TryParse(tbnilai.Text, out inputValue))
            {
                if (Pilihan.SelectedItem != null)
                {
                    if (Button1.Checked)
                    {
                        // Celcius ke unit lain
                        if (Pilihan.SelectedItem.ToString() == "Fahrenheit")
                            textBox3.Text = ((inputValue * 9 / 5) + 32).ToString();
                        else if (Pilihan.SelectedItem.ToString() == "Kelvin")
                            textBox3.Text = (inputValue + 273.15).ToString();
                        else if (Pilihan.SelectedItem.ToString() == "Reamur")
                            textBox3.Text = (inputValue * 4 / 5).ToString();
                        else
                            textBox3.Text = inputValue.ToString(); // Celcius ke Celcius
                    }
                    else if (button2.Checked)
                    {
                        // Fahrenheit ke unit lain
                        if (Pilihan.SelectedItem.ToString() == "Celcius")
                            textBox3.Text = ((inputValue - 32) * 5 / 9).ToString();
                        else if (Pilihan.SelectedItem.ToString() == "Kelvin")
                            textBox3.Text = ((inputValue - 32) * 5 / 9 + 273.15).ToString();
                        else if (Pilihan.SelectedItem.ToString() == "Reamur")
                            textBox3.Text = ((inputValue - 32) * 4 / 9).ToString();
                        else
                            textBox3.Text = inputValue.ToString(); // Fahrenheit ke Fahrenheit
                    }
                    else if (button4.Checked)
                    {
                        // Reamur ke unit lain
                        if (Pilihan.SelectedItem.ToString() == "Celcius")
                            textBox3.Text = (inputValue * 5 / 4).ToString();
                        else if (Pilihan.SelectedItem.ToString() == "Kelvin")
                            textBox3.Text = ((inputValue * 5 / 4) + 273.15).ToString();
                        else if (Pilihan.SelectedItem.ToString() == "Fahrenheit")
                            textBox3.Text = ((inputValue * 9 / 4) + 32).ToString();
                        else
                            textBox3.Text = inputValue.ToString(); // Reamur ke Reamur
                    }
                    else if (button2.Checked)
                    {
                        // Kelvin ke unit lain
                        if (Pilihan.SelectedItem.ToString() == "Celcius")
                            textBox3.Text = (inputValue - 273.15).ToString();
                        else if (Pilihan.SelectedItem.ToString() == "Fahrenheit")
                            textBox3.Text = ((inputValue - 273.15) * 9 / 5 + 32).ToString();
                        else if (Pilihan.SelectedItem.ToString() == "Reamur")
                            textBox3.Text = ((inputValue - 273.15) * 4 / 5).ToString();
                        else
                            textBox3.Text = inputValue.ToString(); // Kelvin ke Kelvin
                    }

                    else
                    {
                        MessageBox.Show("Masukkan nilai yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FUtama FUTAMA = new FUtama();
            FUTAMA.Show();
            this.Hide();
        }
    }
}

