
using System;
using System.IO;
using System.Diagnostics;
    
// Enum untuk jenis kelamin
enum Gender
{
    LakiLaki = 1,
    Perempuan = 2
}

// Class Biodata
class Biodata
{
    // Properties dengan get dan set
    public string Nama { get; set; }
    public Gender JenisKelamin { get; set; }
    public string Alamat { get; set; }
    public string Kelas { get; set; }
    public string Jurusan { get; set; }
    public string NoHP { get; set; }

    // Method untuk menampilkan biodata
    public void TampilkanBiodata()
    {
        Console.WriteLine("Nama Lengkap: " + Nama);
        Console.WriteLine("Jenis Kelamin: " + JenisKelamin);
        Console.WriteLine("Alamat: " + Alamat);
        Console.WriteLine("Kelas: " + Kelas);
        Console.WriteLine("Jurusan: " + Jurusan);
        Console.WriteLine("NO HP: " + NoHP);
    }
}

class Program
{
    static void Main(string[] args)
    {
            // Inisialisasi objek Biodata
            Biodata biodata = new Biodata();

            // Pengisian data dengan input pengguna
            Console.WriteLine("SILAHKAN ISI DATA DIBAWAH\n");

            // Nama Lengkap
            Console.Write("Nama Lengkap: ");
            biodata.Nama = Console.ReadLine();

            // Jenis Kelamin dengan enum dan switch case
            Console.WriteLine("Jenis Kelamin: ");
            Console.WriteLine("1. Laki-Laki");
            Console.WriteLine("2. Perempuan");
            Console.Write("Masukkan pilihan (1 atau 2): ");
            int genderChoice = int.Parse(Console.ReadLine());
            switch (genderChoice)
            {
                case 1:
                    biodata.JenisKelamin = Gender.LakiLaki;
                    break;
                case 2:
                    biodata.JenisKelamin = Gender.Perempuan;
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    return;
            }

            // Alamat
            Console.Write("Alamat: ");
            biodata.Alamat = Console.ReadLine();

            // Kelas
            Console.WriteLine("Kelas: ");
            Console.WriteLine("1. X");
            Console.WriteLine("2. XI");
            Console.WriteLine("3. XII");
            Console.Write("Masukkan pilihan (1, 2, atau 3): ");
            biodata.Kelas = Console.ReadLine() switch
            {
                "1" => "X",
                "2" => "XI",
                "3" => "XII",
                _ => "Tidak valid"
            };
                        
            // Jurusan dengan array
            string[] jurusanArray = { "RPL", "AK", "MP", "ML", "BD", "BR" };
            Console.WriteLine("Jurusan: ");
            for (int i = 0; i < jurusanArray.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {jurusanArray[i]}");
            }
            Console.Write("Masukkan pilihan (1, 2, 3, 4, 5, atau 6): ");
            int jurusanChoice = int.Parse(Console.ReadLine());
            if (jurusanChoice >= 1 && jurusanChoice <= jurusanArray.Length)
            {
                biodata.Jurusan = jurusanArray[jurusanChoice - 1];
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid.");
                return;
            }

            // Nomor HP dengan validasi menggunakan perbandingan
            while (true) // Perulangan while
            {
                Console.Write("NO HP (Harap menggunakan 62 di depan nomor, bukan 0): ");
                biodata.NoHP = Console.ReadLine();
                if (biodata.NoHP.StartsWith("62"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nomor HP harus dimulai dengan 62.");
                }
            }

            // Menampilkan hasil biodata
            biodata.TampilkanBiodata();

            // Menyimpan data ke file .txt
            string fileName = "biodata.txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("Nama Lengkap: " + biodata.Nama);
                writer.WriteLine("Jenis Kelamin: " + biodata.JenisKelamin);
                writer.WriteLine("Alamat: " + biodata.Alamat);
                writer.WriteLine("Kelas: " + biodata.Kelas);
                writer.WriteLine("Jurusan: " + biodata.Jurusan);
                writer.WriteLine("NO HP: " + biodata.NoHP);
            }
            try
            {
            // Membuka file txt di Notepad setelah disimpan
                Console.WriteLine($"\nTerima kasih! Datamu telah disimpan! Di {fileName}");
                Process.Start("notepad.exe", fileName); // Membuka file di Notepad

            // Menampilkan pesan akhir
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
        catch (Exception ex) // Try-Catch untuk menangani error
        {
            Console.WriteLine("Terjadi kesalahan: " + ex.Message);
        }
    }
}

