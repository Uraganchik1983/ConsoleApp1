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
            Console.WriteLine("Арифметические операции: ");
            Console.WriteLine("Введите X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Calculator.Add(x, y);

            Console.WriteLine();
            Console.WriteLine("Поразрядные операции: ");
            Razryad.Sum(x, y);

            Console.WriteLine();
            Console.WriteLine("Преобразование типов бывает: расширение, сужение. Пример byte x = (byte)(5+70)");

            Console.ReadLine();
        }
    }

    class Calculator
    {
        public static void Add(int a, int b)
        {
            int summ = a + b;
            Console.WriteLine($"Сумма {a} и {b} равна: {summ}");
        }
    }

    class Razryad
    {
        public static void Sum (int x, int y)
        {
            Console.WriteLine($"Двоичный код {x} = " + Convert.ToString(x, 2));
            Console.WriteLine($"Двоичный код {y} = " + Convert.ToString(y, 2));
            Console.WriteLine("x & y =  " + (x & y));
            Console.WriteLine("x | y = " + (x | y));
            Console.WriteLine("x ^ y = " + (x ^ y));
            Console.WriteLine("x << y = " + (x << y));
            Console.WriteLine("x >> y = " + (x >> y));
        }
    }
}