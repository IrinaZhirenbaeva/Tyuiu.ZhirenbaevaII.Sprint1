using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.Sprint1.Task4.V7.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint1.Task4.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Жиренбаева И.И | ИСТНб-23-1";

            Console.WriteLine("");
            Console.WriteLine(" Спринт #1                                                               ");
            Console.WriteLine(" Тема:  Алгоритмы линейной структуры                                       ");
            Console.WriteLine(" Задание #4                                                             ");
            Console.WriteLine(" Вариант #7                                                            ");
            Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                       ");
            Console.WriteLine("");
            Console.WriteLine("* УСЛОВИЕ:                                                                ");
            Console.WriteLine(" Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по формуле ");
            Console.WriteLine(" и печатает его на экране.                                         ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        ");
            Console.WriteLine("");
            Console.WriteLine("                                                             ");
            double x, y;

            Console.WriteLine("Введите число x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("**");

            Console.WriteLine("1+xy√(x−3y)2 = " + ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}



