
using System;
using System.IO;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool KeepRuning = true;
            while (KeepRuning)
            {
                Console.Clear();
                Console.WriteLine("Pilih Bangun datar seperti apa");
                Console.WriteLine("1. Persegi");
                Console.WriteLine("2. Persegi Panjang");
                Console.WriteLine("3. threangle");
                Console.WriteLine("4. Back");
                Console.WriteLine("berikan input 1-4 :");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        hitungPersegi();
                        break;
                    case "2":
                        hitungPersegiPanjang();
                        break;
                    case "3":
                        hitungSegiTiga();
                        break;
                    case "4":
                        KeepRuning = false;
                        break;
                    default:
                        Console.WriteLine("pilih 1-4");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void hitungPersegi()
        {
            Console.Write("masukan angka sisi persegi untuk di hitung : ");
            double sisi = Convert.ToDouble(Console.ReadLine());
            double luasPersegi = sisi * sisi;
            double kelilingPersegi = 4 * sisi;
            Console.WriteLine($"luas persegi adalah : {luasPersegi}");
            Console.WriteLine($"keliling persegi adalah : {kelilingPersegi}");
            Console.ReadKey();
        }

        static void hitungPersegiPanjang()
        {
            Console.Write("masukan panjang persegi panjang untuk di hitung : ");
            double panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("masukan lebar persegi panjang untuk di hitung : ");
            double lebar = Convert.ToDouble(Console.ReadLine());
            double luasPersegiPanjang = panjang * lebar;
            double kelilingPersegiPanjang = 2 * (panjang + lebar);

            Console.WriteLine($"luas persegi panjang adalah : {luasPersegiPanjang}");
            Console.WriteLine($"keliling persegi panjang adalah : {kelilingPersegiPanjang}");
            Console.ReadKey();
        }

        static void hitungSegiTiga()
        {
            Console.Write("masukan alas segitiga untuk di hitung : ");
            double alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("masukan tinggi segitiga untuk di hitung : ");
            double tinggi = Convert.ToDouble(Console.ReadLine());

            double luasSegiTiga = 0.5 * alas * tinggi;
            double kelilingSegiTiga = 3 * alas;

            Console.WriteLine($"luas persegi panjang adalah : {luasSegiTiga}");
            Console.WriteLine($"keliling persegi panjang adalah : {kelilingSegiTiga}");
            Console.ReadKey();
        }
    }
}
