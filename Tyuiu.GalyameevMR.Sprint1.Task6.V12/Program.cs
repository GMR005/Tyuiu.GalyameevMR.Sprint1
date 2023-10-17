using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint1.Task6.V12.Lib;

namespace Tyuiu.GalyameevMR.Sprint1.Task6.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.Title = "Спринт 1. Выполнил: Галямеев М.Р. | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #1                                                     ");
            Console.WriteLine("* Тема: Работа со строками класс String          ");
            Console.WriteLine("* Задание #6                                                   ");
            Console.WriteLine("* Вариант #12                                                ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("*Написать программу: пользователь вводит текст. Проверить, что последнее слово " +
                "строки входит в нее еще раз.");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");

            string phrase = Console.ReadLine();

            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            
            bool isLastWordRepeated = DataService.CheckLastWordRepetiton(phrase);

            if (isLastWordRepeated)
            {
                Console.WriteLine("Последнее слово повторно встречается в тексте.");
            }
            else
            {
                Console.WriteLine("Последнее слово повторно не встречается в тексте.");
            }


        }
    }
}
