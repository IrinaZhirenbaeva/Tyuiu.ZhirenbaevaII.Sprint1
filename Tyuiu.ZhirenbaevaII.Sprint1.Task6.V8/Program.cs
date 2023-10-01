using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.Sprint1.Task6.V8.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint1.Task6.V8
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
            Console.WriteLine(" Задание #6                                                            ");
            Console.WriteLine(" Вариант #8                                                          ");
            Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                       ");
            Console.WriteLine("");
            Console.WriteLine("* УСЛОВИЕ:                                                                ");
            Console.WriteLine(" Написать программу: пользователь вводит текст. Напечатать все слова, перенеся их первую букву в конец   ");
            Console.WriteLine(" и печатает его на экране.                                         ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        ");
            Console.WriteLine("");
            Console.WriteLine("                                                             ");
            Console.WriteLine("Введите число текст: ");
            string value = Console.ReadLine();


            Console.WriteLine("**");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("**");

            Console.WriteLine(ds.MoveLetterToEnd(value));
            Console.ReadLine();
        }
    }
    }
