using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UHCRUD
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

        private void generateSiswa()
        {
            siswaBindingSource.ResumeBinding();
            siswaBindingSource.ResetBindings(false);
            siswaBindingSource.DataSource = db.siswas.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            button4.Enabled = true;
            button5.Enabled = true;
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

            namaTextBox = table.nama;
            kelasTextBox = table.kelas;
        }
    }
}
