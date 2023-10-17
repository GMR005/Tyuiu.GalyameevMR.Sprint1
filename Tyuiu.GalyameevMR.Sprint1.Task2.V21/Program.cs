using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint1.Task2.V21.Lib;

namespace Tyuiu.GalyameevMR.Sprint1.Task2.V21
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
            Console.WriteLine("* Задание #2                                               ");
            Console.WriteLine("* Вариант #21                                                 ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные, выполняет");
            Console.WriteLine("указанные расчёты и печатает результат на экране.*");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");

            int x, y;
            Console.WriteLine("Введите значение первой стороны : ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение второй стороны: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine(DataService.Calculate(x,y));
            Console.ReadKey();
        }
    }
}
