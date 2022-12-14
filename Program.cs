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
            if (n == 1 || n == 0) 
                return n;
            else
                return f(n - 1) + f(n - 2);  //費式數列，前兩數相加為後一數。
        }
        static void Main(string[] args)   
        {
            Console.WriteLine("Input : ");
            string number = Console.ReadLine();
            int range = 0;
            int.TryParse(number, out range); 

            for (int n = 1; n <= range; n++)
                Console.WriteLine(f(n)+"(第"+n+"個數字)");
        }

    }
}
