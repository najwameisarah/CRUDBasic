using System;

class Program
{
    static void Main()
    {
        // Nilai tukar dari Rupiah ke Yen (contoh nilai, bisa diubah sesuai nilai tukar saat ini)
        double exchangeRate = 0.008;

        // Input nilai dalam Rupiah
        Console.Write("Masukkan jumlah dalam Rupiah: ");
        double rupiah = Convert.ToDouble(Console.ReadLine());

        // Konversi ke Yen
        double yen = ConvertRupiahToYen(rupiah, exchangeRate);

        // Output hasil konversi
        Console.WriteLine($"{rupiah} Rupiah sama dengan {yen} Yen");
    }

    static double ConvertRupiahToYen(double rupiah, double exchangeRate)
    {
        return rupiah * exchangeRate;
    }
}
