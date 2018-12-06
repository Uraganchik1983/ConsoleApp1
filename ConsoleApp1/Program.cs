using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world ");
            Calculator.Add(2, 3);
            Console.ReadLine();
        }
    }

    class Calculator
    {
        public static void Add(int a, int b)
        {
            int summ = a + b;

            Console.WriteLine($"Сумма {a} и {b} равна: {summ}");
            Console.WriteLine("hi");
        }
    }
}