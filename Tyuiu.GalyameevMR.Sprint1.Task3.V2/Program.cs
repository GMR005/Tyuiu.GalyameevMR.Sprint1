using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint1.Task3.V2.Lib;

namespace Tyuiu.GalyameevMR.Sprint1.Task3.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService ();
            Console.Title = "Спринт 1. Выполнил: Галямеев М.Р. | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #1                                                     ");
            Console.WriteLine("* Тема:  Операторы составного присваивания           ");
            Console.WriteLine("* Задание #3                                               ");
            Console.WriteLine("* Вариант #21                                                 ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные, выполняет");
            Console.WriteLine("указанные расчёты и печатает результат на экране.*");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");

            double priceNotebook, pricePencil;
            int amountNotebook, amountPencil;

            Console.WriteLine("Введите цену одной тетради : ");
            priceNotebook = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество тетрадей : ");
            amountNotebook = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите цену одного карандаша: ");
            pricePencil = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество карандашей: ");
            amountPencil = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            double rounding = DataService.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);
            double roundedAmount = Math.Round(rounding, 3);
            Console.WriteLine(roundedAmount);
            Console.ReadKey();
        }
    }
}
