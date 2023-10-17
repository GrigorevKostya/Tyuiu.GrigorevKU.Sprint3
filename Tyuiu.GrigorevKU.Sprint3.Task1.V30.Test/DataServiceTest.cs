using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorevKU.Sprint3.Task1.V30.Lib;
namespace Tyuiu.GrigorevKU.Sprint3.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 12;

            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 3.589;
            Assert.AreEqual(wait, res);
        }
    }
}
