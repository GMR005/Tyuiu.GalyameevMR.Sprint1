using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint1.Task1.V19.Lib;

namespace Tyuiu.GalyameevMR.Sprint1.Task1.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.Title = "Спринт 1. Выполнил: Галямеев М.Р. | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #1                                                     ");
            Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях            ");
            Console.WriteLine("* Задание #1                                                 ");
            Console.WriteLine("* Вариант #19                                                  ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат ");
            Console.WriteLine("по формуле (x+10*y)/(x*y) и печатает его на экране. ");                                       
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");

            double x, y;
            Console.WriteLine("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine(DataService.Calculate(x,y));
            Console.ReadKey();
        }
    }
}
