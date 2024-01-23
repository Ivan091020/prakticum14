using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakticum14
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Задание 1
            // Цикл с условием (while)
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            // Цикл с параметром (for)
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(j);
            }
            ///Задание 2
            int n = 17; 

            for (int q = 1; q <= n; q++)
            {
                Console.WriteLine(q);
            }
            ///Задание 3
            int w = 1;
            while (w <= 5)
            {
                Console.WriteLine("Привет!");
                w++;
            }
            ///Задание 4
            ///а) Горизонтальная строка из 18 символов:
            Console.ForegroundColor = ConsoleColor.Green; // Установка цвета текста
            for (int e = 0; e < 18; e++)
            {
                Console.Write("*"); // Вывод символа
            }
            Console.ResetColor(); // Сброс цвета текста
            Console.WriteLine(); // Переход на новую строку
            ///б) Вертикальная строка из 25 символов:
            Console.ForegroundColor = ConsoleColor.Red; // Установка цвета текста
            for (int r = 0; r < 25; r++)
            {
                Console.WriteLine("*"); // Вывод символа и переход на новую строку
            }
            Console.ResetColor(); // Сброс цвета текста










        }
    }
}
