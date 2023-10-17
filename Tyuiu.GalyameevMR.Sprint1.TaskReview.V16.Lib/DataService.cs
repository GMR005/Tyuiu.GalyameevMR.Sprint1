using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GalyameevMR.Sprint1.TaskReview.V16.Lib
{
    public class DataService
    {
        public static double Calc (double x)
        { 
            double result;
            result = Math.Sin(x) +  Math.Cos(Math.Pow(x, 2)) / (3 * Math.Pow(x, 3)) - Math.Sin(Math.Sqrt(Math.Pow(x, 2) - 1));
            result = Math.Round(result, 3);
            return result;
        }
    }
}
