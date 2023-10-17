using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint1.TaskReview.V16.Lib;
namespace Tyuiu.GalyameevMR.Sprint1.TaskReview.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod] 
        public void CheckCalc()
        {
            DataService DataService = new DataService();
            double x = 1.0;
            double p = DataService.Calc (x);
            Assert.AreEqual(p, 1.022);
        }
    }
}
