using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.Sprint1.Task7.V22.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint1.Task7.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Жиренбаева И.И | ИСТНб-23-1";

            Console.WriteLine("");
            Console.WriteLine(" Спринт #1                                                               ");
            Console.WriteLine(" Тема:  Алгоритмы линейной структуры                                     ");
            Console.WriteLine(" Задание #7                                                              ");
            Console.WriteLine(" Вариант #22                                                             ");
            Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                     ");
            Console.WriteLine("");
            Console.WriteLine("* УСЛОВИЕ:                                                               ");
            Console.WriteLine(" Написать программу, которая вычисляет математическое выражение по исходным значениям данных, вводимых пользователем  ");
            Console.WriteLine(" и печатает его на экране.                                               ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       ");
            Console.WriteLine("");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("Введите число текст: ");
            double x, y;
            Console.WriteLine("Введите число х");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число y");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                ");
            Console.WriteLine("**");
            Console.WriteLine(ds.Calculate(x, y));

        }
    }
}

   
