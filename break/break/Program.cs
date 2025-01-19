using System;

namespace MyApplication
{
    class Program
    {
        static int PlusMethodInt(int x, int y)
        {
            return x + y;
        }

        static float PlusMethodFloat(float x, float y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int myNum1 = PlusMethodInt(8, 5);
            float myNum2 = PlusMethodFloat(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Float: " + myNum2);
        }
    }
}