using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.Sprint1.Task1.V5.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint1.Task1.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Жиренбаева И.И | ИСТНб-23-1";

            Console.WriteLine("");
            Console.WriteLine(" Спринт #1                                                               ");
            Console.WriteLine(" Тема: Базовые навыки работы в С#                                        ");
            Console.WriteLine(" Задание #1                                                              ");
            Console.WriteLine(" Вариант #5                                                            ");
            Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                       ");
            Console.WriteLine("");
            Console.WriteLine("* УСЛОВИЕ:                                                                ");
            Console.WriteLine(" Написать программу, которая вычисляет выражение (5+(x*y/3))            ");
            Console.WriteLine(" и печатает результат на экране.                                         ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        ");
            Console.WriteLine("");
            double x, y;

            Console.WriteLine("Введите число х");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число у");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine(ds.Calculate(x, y));
            
            Console.WriteLine("**");
            Console.ReadLine();

            


            
        }
    }
}
