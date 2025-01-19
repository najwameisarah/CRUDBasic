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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LabelUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbpassword.Text;
            
            //validasi login
            if (username == "admin" && password == "12345")
            {
                //login berhasil, buka form calculator
                FUtama fUtama = new FUtama();
                fUtama.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("username atau password salah!!", "login gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void form1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
    }

