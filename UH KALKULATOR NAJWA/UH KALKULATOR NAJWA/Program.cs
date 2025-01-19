using System;
using System.IO;
using System.Transactions;

enum{
    penjumlahan = 1,
    pengurangan = 2,
    perkalian = 3,
    pembagian = 4 }

namespace UhProgram
{
    class Kalkulator
    {
         
        static void Main(string[] args)
        {
            bool Menghitungkalkulator = true;
            while (Menghitungkalkulator) {
                double angka1 = 0;
                double angka2 = 0;
                double operasiResult = 0;
                Console.Clear();
                Console.Write("Pilih Operasi: ");
                Console.WriteLine("1. penjumlahan");
                Console.WriteLine("2. Pengurangan");
                Console.WriteLine("3. perkalian");
                Console.WriteLine("4. Pembagian");
                Console.Write("pilih salah satu untuk menginput");
                Console.ReadLine();

                Console.WriteLine("Masukkan angka pertama");
                angka1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Masukkan angka kedua");
                angka2 = Convert.ToDouble(Console.ReadLine());

                string input = Console.ReadLine();

                switch(input)
                {
                    case "1":
                        operasiResult = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + operasiResult);
                        break;
                    case "2":
                        operasiResult = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + operasiResult);
                        break;
                    case "3":
                        operasiResult = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + operasiResult);
                        break;
                    case "4":
                    default:
                        Console.WriteLine("Tidak bisa menghasilkan");
                        return;

                }
               
                Console.ReadKey();
            }
        }
    }
}