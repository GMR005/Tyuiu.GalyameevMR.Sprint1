using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint1.Task3.V2.Lib;

namespace Tyuiu.GalyameevMR.Sprint1.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckPurchase()
        {
            DataService DataService = new DataService ();
            double priceNotebook = 230.2;
            int amountNotebook = 5;
            double pricePencil = 78.4;
            int amountPencil = 9;
            var res = DataService.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);
            Assert.AreEqual(res, 1856.6);
        }
    }
}
