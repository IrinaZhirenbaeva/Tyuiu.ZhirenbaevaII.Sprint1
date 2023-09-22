using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.Sprint1.Task2.V15.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprunt1.Task2.V15
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
            Console.WriteLine(" Задание #2                                                              ");
            Console.WriteLine(" Вариант #15                                                            ");
            Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                    ");
            Console.WriteLine("");
            Console.WriteLine("* УСЛОВИЕ:                                                                ");
            Console.WriteLine(" Написать программу, которая запрашивает у пользователя исходные данные   ");
            Console.WriteLine(" выполняет расчеты и печатает результат на экране.                        ");
            Console.WriteLine("                                                                          ");
            Console.WriteLine("");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        ");
            Console.WriteLine("");
            int x;

            Console.WriteLine("Введите сторону куба");
            x = Convert.ToInt32(Console.ReadLine());

          
            

            Console.WriteLine("**");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("Объем куба =" + ds.CalculateCubeVolume(x));

            Console.WriteLine("**");
            Console.ReadLine();





        }
    }
}
