using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint1.Task2.V21.Lib;

namespace Tyuiu.GalyameevMR.Sprint1.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindArea()
        {
            DataService DataService = new DataService();
            double x = 2.0;
            double y = 3.0;
            var res = DataService.Calculate(x, y);
            Assert.AreEqual(6.0, res) ; 
        }
    }
}
