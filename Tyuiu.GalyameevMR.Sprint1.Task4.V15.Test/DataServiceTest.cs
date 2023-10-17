using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint1.Task4.V15.Lib;

namespace Tyuiu.GalyameevMR.Sprint1.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcValid()
        {
            DataService DataService = new DataService(); 
            double x = 1.0;
            double y = 0.5;
            double p = DataService.Calculate(x, y);
            Assert.AreEqual(1.25, p);
        }
    }
}
