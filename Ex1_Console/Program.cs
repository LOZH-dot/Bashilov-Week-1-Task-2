using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Координаты точки в координатной плоскости
            double x = 0;
            double y = 0;

            while (true)
            {
                try
                {
                    Console.Write("Введите первую координату точки: ");
                    x = double.Parse(Console.ReadLine());

                    Console.Write("Введите вторую координату точки: ");
                    y = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine(ex.Message);
                }
            }

            Console.Write($"\nТочка [x: {x}][y: {y}] находится: ");

            if (x * x + y * y < 9 * 9 && x > 0)
                Console.WriteLine("внутри окружности");
            else if (x * x + y * y > 9 * 9 || x < 0)
                Console.WriteLine("вне окружности");
            else
                Console.WriteLine("на границе окружности");
        }
    }
}
