/
    using System;

class BitwiseNot
{
    public static void Main(String[] args)
    {
        int a = 6;

        // menggunakan operator bitwise not (~)
        int hasil = ~a;

        Console.WriteLine($"~a = {hasil}");
    }
}