using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint1.TaskReview.V16.Lib;

 
namespace Tyuiu.GalyameevMR.Sprint1.TaskReview.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService =  new DataService();
            Console.Title = "Спринт 1. Выполнил: Галямеев М.Р. | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #1                                                     ");
            Console.WriteLine("* Тема: TaskReview      ");
            Console.WriteLine("* Задание Review                                                  ");
            Console.WriteLine("* Вариант #16                                                ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("*Написать программу, которая вычисляет математическое выражение по исходным значениям " +
                "данных, вводимых пользователем. Ответ округлите до 3 знаков после запятой..");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");

            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");

            Console.WriteLine(DataService.Calc(x));
            Console.ReadKey();

        }
    }
}
