using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint1.Task1.V19.Lib;
namespace Tyuiu.GalyameevMR.Sprint1.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DataService = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = DataService.Calculate(x, y);
            Assert.AreEqual(10.5, res);
        }
    }
}
