using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UHPAK_ARROH1
{
    public partial class Form1 : Form
    {
        db_siswaEntities db = new db_siswaEntities();
        siswa table = null;

        private void generateSiswa()
        {
            siswaBindingSource.ResumeBinding();
            siswaBindingSource.ResetBindings(false);
            siswaBindingSource.DataSource = db.siswas.ToList();
        }
        public Form1()
        {
            InitializeComponent();
            generateSiswa();
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
            if (table == null)
            {
                siswa s = new siswa()
                {
                    nama = namaTextBox.Text,
                    kelas = kelasTextBox.Text,
                    jenis_kelamin = jenis_kelaminTextBox.Text
                };
                db.siswas.Add(s);
            }
            else
            {
                siswa s = db.siswas.Find(table.id);
                s.nama = namaTextBox.Text;
                s.kelas = kelasTextBox.Text;
                s.jenis_kelamin = jenis_kelaminTextBox.Text;
            }
            db.SaveChanges();
            generateSiswa();

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;

            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            siswaBindingSource.ResumeBinding();

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;

            button4.Enabled = false;
            button5.Enabled = false;
        }
        private DataTable readCSV(String filepath)
        {
            var dt = new DataTable();
            File.ReadLines(filepath).Take(1)
                .SelectMany(x => x.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
                .ToList()
                .ForEach(x => dt.Columns.Add(x.Trim()));
            File.ReadLines(filepath).Skip(1)
                .Select(x => x.Split(';'))
                .ToList()
                .ForEach(line => dt.Rows.Add(line));
            return dt;

        }
        private void button6_Click(object sender, EventArgs e)
        {
            siswaBindingSource.SuspendBinding();
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                DataTable dt = new DataTable();
                dt = readCSV(ofd.FileName);

                foreach (DataRow row in dt.Rows)
                {
                    siswa s = new siswa();
                    s.nama = row["nama"].ToString();
                    s.kelas = row["kelas"].ToString();
                    s.jenis_kelamin = row["jenis kelamin"].ToString();
                    db.siswas.Add(s);

                }
                db.SaveChanges();
                generateSiswa();
            }
            else
            {
                siswaBindingSource.ResumeBinding();
            }
        }
    }
}
