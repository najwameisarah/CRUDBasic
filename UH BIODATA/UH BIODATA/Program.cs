using System;
using System.IO;
using System.Diagnostics;


namespace myProgram
{
    enum jenisKelamin {
         LakiLaki= 1,
         Perempuan = 2

    }
    enum yourKelas
    {
        X= 1,
        XI = 2,
        XII = 3
    }
    enum jurusan
    {
        RPL = 1,
        BR = 2,
        BD = 3,
        MP = 4,
        ML = 5,
        AK = 6
    }
    class Biodata
    {
        private string name;
        public string nama { get; set; }
        public jenisKelamin jenisKelamin { get; set; }
        public string Alamat { get; set; }
        public string Kelas { get; set; }
        public string Jurusan { get; set; }
        public string NoHp { get; set; }

        public void MunculkanBiodata()
        {
            Console.Write("nama Lengkap: " + nama);
            Console.WriteLine("Jenis Kelamin: " + jenisKelamin);
            Console.WriteLine("Alamat: " + Alamat);
            Console.WriteLine("Kelas: " + Kelas);
            Console.WriteLine("Jurusan: " + Jurusan);
            Console.WriteLine("no Hp: " + NoHp);

         }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Biodata formulir = new Biodata();
            Console.Write("Isi Biodata dibawah ini\n");
            Console.WriteLine("masukan nama");
            string  Nama = Console.ReadLine();
            Console.Write("Jenis Kelamin");
            Console.WriteLine("1. Laki - Laki");
            Console.WriteLine("2. Perempuan");
            Console.Write("Pilih salah satu");
            int pilihJenisKelamin = int.Parse(Console.ReadLine());
            switch (pilihJenisKelamin) {
                case 1:
                    formulir.jenisKelamin = jenisKelamin.LakiLaki;
                    break;
                case 2:
                    formulir.jenisKelamin = jenisKelamin.Perempuan;
                    break;
                default:
                    Console.WriteLine("Pilihan Tidak Valid");
                    return;

            }
            Console.Write("Alamat: ");
            formulir.Alamat = Console.ReadLine();

            Console.WriteLine("Kelas: ");
            Console.WriteLine("1. X");
            Console.WriteLine("2. XI");
            Console.WriteLine("3. XII");
            Console.Write("Masukkan pilihan (1, 2, atau 3): ");
            formulir.Kelas = Console.ReadLine() switch {
                "1" => "X",
                "2" => "XI",
                "3" => "XII",
                  _  => "Tidak ada"
            };

            string[] jurusanArray = { "RPL", "BR", "BD", "MP", "ML", "AK" };
            Console.WriteLine("jurusan: ");
            for (int i = 0; i < jurusanArray.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {jurusanArray[1]}");

            }
            Console.Write("Masukan pilihan(1, 2, 3, 4, 5 atau 6): ");
            int pilihanjurusan = int.Parse(Console.ReadLine());
            if (pilihanjurusan >= 1 && pilihanjurusan <= jurusanArray.Length)
            {
                formulir.Jurusan = jurusanArray[pilihanjurusan - 1];
            }
            else
            {
                Console.WriteLine("Pilihan Tidak ditemukan");
                return;
            }
            Console.Write("NO HP (Harap menggunakan 62 di depan nomor, bukan 0): ");
                formulir.NoHp = Console.ReadLine();
         
        }


    }

  }


