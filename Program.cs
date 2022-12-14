using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Program
    {
        private static int f(int n)
        {
            if (n <= 0)
                return -1;
            else if (n == 1 || n == 2)
                return 1;
            else
                return f(n - 1) + f(n - 2);
        }
        static void Main(string[] args)   
        {
            Console.WriteLine("f(n):");
            string max = Console.ReadLine();
            int range = 0;
            int.TryParse(max, out range); 

            for (int i = 1; i <= range; i++)
                Console.WriteLine(f(i));
        }

    }
}