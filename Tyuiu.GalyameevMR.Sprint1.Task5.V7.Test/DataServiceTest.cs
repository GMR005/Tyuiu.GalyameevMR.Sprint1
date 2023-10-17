using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint1.Task5.V7.Lib;


namespace Tyuiu.GalyameevMR.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckHours()
        {
            DataService DataService =  new DataService();
            double f = 62.3;
            int p = DataService.AngleToHoursMinutes(f);
            Assert.AreEqual(2, p);
        }
    }
}
