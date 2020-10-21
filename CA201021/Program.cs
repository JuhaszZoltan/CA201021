using System;

namespace CA201021
{
    class Program
    {
        static Random rnd = new Random();
        static void Main()
        {
            var t = new int[10];
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rnd.Next(10, 100);
                Console.Write($"{t[i]}, ");
            }
            Console.ReadKey();
        }
    }
}
