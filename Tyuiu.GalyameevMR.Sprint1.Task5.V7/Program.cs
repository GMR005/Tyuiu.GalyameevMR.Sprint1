using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint1.Task5.V7.Lib;

namespace Tyuiu.GalyameevMR.Sprint1.Task5.V7
{
    class Program
    {
        static void Main(string[] args )
        {
            DataService DataService = new DataService ();
            Console.Title = "Спринт 1. Выполнил: Галямеев М.Р. | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #1                                                     ");
            Console.WriteLine("* Тема:  Операторы составного присваивания           ");
            Console.WriteLine("* Задание #5                                                   ");
            Console.WriteLine("* Вариант #7                                                  ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные, выполняет");
            Console.WriteLine("указанные расчёты и печатает результат на экране.*");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");

            double f;
            Console.WriteLine("Введите необходимый угол: ");
            f = Convert.ToDouble(Console. ReadLine());

            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine(DataService.AngleToHoursMinutes(f));
            Console.ReadKey();
        }
    }
}
