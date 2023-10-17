using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint1.Task6.V12.Lib;

namespace Tyuiu.GalyameevMR.Sprint1.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckWord()
        {
            DataService DataService = new DataService() ;
            string phrase = "hello world world world";
            bool result = DataService.CheckLastWordRepetiton(phrase);
            Assert.AreEqual(result, true);

            phrase = "hello world planet universe";
            result = DataService.CheckLastWordRepetiton(phrase);
            Assert.AreEqual(result,false );

        }
    }
}
