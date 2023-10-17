using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GalyameevMR.Sprint1.Task6.V12.Lib
{
    public class DataService : ISprint1Task6V12
    {
        public bool CheckLastWordRepetiton(string value)
        {

            char[] separators = { ' ', ',', ';', '.', ':' };
            string[] words =  value.Split(separators);
            string lastWord = words[words.Length - 1];

            int countOfRepeating = 0;
            foreach (string word in words)
            {
                if (word == lastWord)
                {
                    countOfRepeating++;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return countOfRepeating > 1;
        }


    }
    
}
