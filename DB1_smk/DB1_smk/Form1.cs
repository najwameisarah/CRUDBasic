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

namespace DB1_smk
{
    public partial class Form1 : Form
        { 
        DB_SisiwaEntities db = new DB_SisiwaEntities();
        student table = null;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void generateStudent()

        {
            studentBindingSource.ResumeBinding();
            studentBindingSource.ResetBindings(false);
            studentBindingSource.DataSource = db.students.ToList();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonAdd.Enabled = false;
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;

            buttonSave.Enabled = true;
            buttonCancel.Enabled = true;
            studentBindingSource.SuspendBinding(); table = null;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonAdd.Enabled = false;
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            buttonSave.Enabled = true;
            buttonCancel.Enabled = true;

            table = (student)studentBindingSource.Current;
            studentBindingSource.SuspendBinding();
            NamatextBox1.Text= table.nama;
            KelastextBox2.Text = table.kelas;
            Jenis_KelamintextBox3.Text = table.jenis_kelamin;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            table = (student)studentBindingSource.Current;
            db.students.Remove(table);
            db.SaveChanges();
            generateStudent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (table == null)
            {
                student s = new student()
                {
                    nama = NamatextBox1.Text,
                    kelas = KelastextBox2.Text,
                    jenis_kelamin = Jenis_KelamintextBox3.Text
                };
                db.students.Add(s);
            }
            else
            {
                student s = db.students.Find(table.id);
                s.nama = NamatextBox1.Text;
                s.kelas = KelastextBox2.Text;
                s.jenis_kelamin = Jenis_KelamintextBox3.Text;
            }
            db.SaveChanges();
            generateStudent();

            buttonAdd.Enabled = true;
            buttonEdit.Enabled = true;
            buttonDelete.Enabled = true;

            buttonSave.Enabled = false;
            buttonCancel.Enabled = false;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            studentBindingSource.ResumeBinding();

            buttonAdd.Enabled = true;
            buttonEdit.Enabled = true;
            buttonDelete.Enabled = true;

            buttonSave.Enabled = false;
            buttonCancel.Enabled = false;

        }
        private DataTable readCSV(string filepath)
        {
            // Membuat objek DataTable
            var dt = new DataTable();

            // Membuat kolom berdasarkan baris pertama di CSV
            File.ReadLines(filepath).Take(1)
                .SelectMany(x => x.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
                .ToList()
                .ForEach(x => dt.Columns.Add(x.Trim()));

            // Menambahkan data baris dari CSV
            File.ReadLines(filepath).Skip(1)
                .Select(x => x.Split(';'))
                .ToList()
                .ForEach(line => dt.Rows.Add(line));

            return dt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            studentBindingSource.SuspendBinding();
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dResult = ofd.ShowDialog();
            if (dResult == DialogResult.OK)
            {
                DataTable dt = new DataTable();
                dt = readCSV(ofd.FileName);
                foreach (DataRow row in dt.Rows)
                {
                    student s = new student();
                    s.nama = row["nama"].ToString();
                    s.kelas = row["kelas"].ToString();
                    s.jenis_kelamin = row["jenis kelamin"].ToString();
                    db.students.Add(s);
                }
                db.SaveChanges();
                generateStudent();
            }

        }
    }
}
