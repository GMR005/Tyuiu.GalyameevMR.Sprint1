using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint1.Task4.V15.Lib;

namespace Tyuiu.GalyameevMR.Sprint1.Task4.V15
{
    class Program
    {
        static void Main(string[] args )
        {
            DataService DataService = new DataService();
            Console.Title = "Спринт 1. Выполнил: Галямеев М.Р. | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #1                                                     ");
            Console.WriteLine("* Тема:  Операторы составного присваивания           ");
            Console.WriteLine("* Задание #4                                                    ");
            Console.WriteLine("* Вариант #15                                                   ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные, выполняет");
            Console.WriteLine("указанные расчёты и печатает результат на экране.*");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");

            double x, y;
            Console.WriteLine("Введите первое число: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            y = Convert.ToDouble(Console.ReadLine());

           
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            double rounding = DataService.Calculate(x,y);
            double roundedAmount = Math.Round(rounding, 3);
            Console.WriteLine(roundedAmount);
            Console.ReadKey();
        }
    }
    
}
