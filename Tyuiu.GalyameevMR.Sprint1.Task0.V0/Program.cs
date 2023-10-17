using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint1.Task0.V0.Lib;

namespace Tyuiu.GalyameevMR.Sprint1.Task0.V0 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 7. Выполнил: Галямеев М.Р. | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #1                                                     ");
            Console.WriteLine("* Тема: Базовые навыки работы в С#             ");
            Console.WriteLine("* Задание #0                                                    ");
            Console.WriteLine("* Вариант #1 0                                                  ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("*Написать программу, которая вычисляет выражение (6/2*3)/9 и печатает ");
            Console.WriteLine("результат на экране.                                            *");
            Console.WriteLine("*                                                               ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");
            int x = 8;
            int y = 2;
            int z = 4;
            int p = 2;
            Console.WriteLine("x = " + x + ", " + "y = " + y + ", " + "z = " + z + ", " + "p = " + p);
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine(DataService.Calc(8, 2, 4, 2));
            Console.ReadKey();
        }
    }
}
