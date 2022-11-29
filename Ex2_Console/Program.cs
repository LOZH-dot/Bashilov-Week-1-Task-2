using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Переменная для порядкового номера месяца
            int month;

            while (true)
            {
                try
                {
                    Console.Write("Введите порядковый номер месяца: ");
                    month = int.Parse(Console.ReadLine());

                    if (month < 1 || month > 12) throw new Exception("Порядковый номер месяца указан неверно! Порядковый номер должен быть от 1 до 12!");
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

            Console.Write($"Количество месяцев до конца года: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(12 - month);
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
