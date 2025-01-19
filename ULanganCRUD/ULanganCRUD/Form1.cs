using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ULanganCRUD
{
    public partial class Form1 : Form
    {
        db_siswaEntities db = new db_siswaEntities();
        siswa table = null;
        public Form1()
        {
            InitializeComponent();
            generateSiswa();
        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void namaLabel_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void jenis_kelaminTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kelasLabel_Click(object sender, EventArgs e)
        {

        }

        private void jenis_kelaminLabel_Click(object sender, EventArgs e)
        {

        }

        private void namaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kelasTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            button4.Enabled = true;
            button5.Enabled = true;

            siswaBindingSource.SuspendBinding();
            table = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            button4.Enabled = true;
            button5.Enabled = true;

            table = (siswa)siswaBindingSource.Current;
            siswaBindingSource.SuspendBinding();

            namaTextBox.Text = table.nama;
            kelasTextBox.Text = table.kelas;
            jenis_kelaminTextBox.Text = table.jenis_kelamin;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            table = (siswa)siswaBindingSource.Current;

            db.siswas.Remove(table);
            db.SaveChanges();
            generateSiswa();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(table == null)
            {
                siswa s = new siswa();

                nama = namaTextBox.Text;
                kelas = kelasTextBox.Text;
                jenis_kelamin = 


















































































































































































































































































































































































                    \
            }
        }
    }
}
