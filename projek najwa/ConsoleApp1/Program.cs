using System;
class PendaftaranPenduduk
{
    static void Main(String[] args)
    {
        // membuat variabel kosong
        string nama;
        int umur;
        bool isPerempuan = true;

        Console.WriteLine("=== PROGRAM PENDAFTARAN PENDUDUK ===");
        Console.Write("Masukan nama: ");
        nama = Console.ReadLine();
        Console.Write("Masukan alamat: ");
        var alamat = Console.ReadLine();
        Console.Write("Masukan umur: ");
        umur = int.Parse(Console.ReadLine());
        Console.Write("Jenis kelamin Perempuan (t/f):");
        isPerempuan = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Terima kasih!");
        Console.WriteLine("Data Berikut");
        Console.WriteLine($"Nama: {nama}");
        Console.WriteLine($"Alamat: {alamat}");
        Console.WriteLine($"Umur: {umur} tahun");
        if (isPerempuan)
        {
            Console.WriteLine("Jenis kelamin: Perempuan");
        }
        else if (!isPerempuan)
        {
            Console.WriteLine("Jenis kelamin: Laki-laki");
        }
        Console.WriteLine("SUDAH DISIMPAN!");
    }
}