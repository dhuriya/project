using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops
{
    static class Question
    {
        public static void Fibonacci()
        {
            int i, count, f1 = 0, f2 = 1, f3 = 0;
            Console.WriteLine("Enter the Limit :");
            count = int.Parse(Console.ReadLine());
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (i = 0; i < count; i++)
            {
                f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2  = f3;
            }
        }
        public static void Fibonacci_Recusrion()
        {
            Console.WriteLine("Enter the limit to generate the fibonacci Series:");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Fibonacci Series:");
            for (int i = 0; i < count; i++)
            {
                Console.Write(Finonacci(i) + " ");
            }
        }
        static int Finonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return Finonacci(n - 1) + Finonacci(n - 2);
        }
    }
}
