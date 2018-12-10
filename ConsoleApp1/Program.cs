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

            Console.WriteLine();
            Console.WriteLine("Пример использования условных конструкций в С#: ");

            if (x>=y)
            {
                Console.WriteLine($"{x} больше или равен чем {y}");
            }
            else
            {
                Console.WriteLine($"{x} меньше чем {y}");
            }

            Console.WriteLine("Example тернарный оператор: ");
            Console.WriteLine("Введите + или -");
            string ss = Console.ReadLine();

            int rez = ss == "+" ? rez = (x + y) : rez = x - y;
            Console.WriteLine($" Получим {rez}");

            Console.WriteLine("Циклы: ");
            for(int i = 1; i < 10; i++)
            {
                Console.WriteLine($"i = {i},  i*i= {i * i}");
            }
            int j= 6;
            while (j>0)
            {
                Console.WriteLine($"j= {j}");
                j--;
            }

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