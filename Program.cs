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
            if (n == 1 || n == 0) //假設 n=1,0回傳n值。
                return n;
            else
                return f(n - 1) + f(n - 2);  //費式數列，數字為前兩個數相加。
        }
        static void Main(string[] args)   
        {
            Console.WriteLine("f(n):");
            string number = Console.ReadLine();
            int range = 0;
            int.TryParse(number, out range); 

            for (int i = 1; i <= range; i++)
                Console.WriteLine(f(i)+"(第"+i+"個數字)");
        }

    }
}
