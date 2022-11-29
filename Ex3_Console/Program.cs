using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывод чисел 10, 12, 14 ... 60 с использованием цикла for\n");
            for (int i = 60; i >= 10; i -= 2)
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine("Вывод чисел 10, 12, 14 ... 60 с использованием цикла while\n");
            int number = 60;
            while (number >= 10)
            {
                Console.WriteLine(number);
                number -= 2;
            }

            Console.WriteLine("Вывод чисел 10, 12, 14 ... 60 с использованием цикла do...while\n");
            number = 60;
            do
            {
                Console.WriteLine(number);
                number -= 2;
            } while (number >= 10);

            Console.WriteLine();
        }
    }
}
