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

namespace UJIAN13_1
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            siswaBindingSource.SuspendBinding();
            table = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            table = (siswa)siswaBindingSource.Current;
            db.siswas.Remove(table);
            db.SaveChanges();
            generateSiswa();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            table = (siswa)siswaBindingSource.Current;
            siswaBindingSource.SuspendBinding();
            tbNama.Text = table.nama;
            tbKelas.Text = table.kelas;
            tbJenisKelamin.Text = table.jenis_kelamin;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (table == null)
            {
                siswa s = new siswa()
                {
                    nama = tbNama.Text,
                    kelas = tbKelas.Text,
                    jenis_kelamin = tbJenisKelamin.Text,
                };
                db.siswas.Add(s);
            }
            else
            {
                siswa s = db.siswas.Find(table.id);
                s.nama = tbNama.Text;
                s.kelas = tbKelas.Text;
                s.jenis_kelamin = tbJenisKelamin.Text;
            }
            db.SaveChanges();
            generateSiswa();

            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            siswaBindingSource.ResumeBinding();

            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;
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
        private void btnImport_Click(object sender, EventArgs e)
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
