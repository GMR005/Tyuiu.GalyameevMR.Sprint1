using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint1.Task7.V10.Lib;

namespace Tyuiu.GalyameevMR.Sprint1.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calc()
        {
            DataService DataService = new DataService();
            double x = 1.5;          
            double result = DataService.Calculate(x);
            Assert.AreEqual(2.679, result);
        }
    }
}
