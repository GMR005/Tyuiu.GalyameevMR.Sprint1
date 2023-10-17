using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint1.Task0.V0.Lib;

namespace Tyuiu.GalyameevMR.Sprint1.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 5;
            int y = 1;
            int z = 3;
            int p = 5;
            float g = DataService.Calc(x, y, z, p);
            Assert.AreEqual(g, 3);

        }
    }
}
