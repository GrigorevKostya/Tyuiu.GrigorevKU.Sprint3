using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorevKU.Sprint3.Task0.V26.Lib;
namespace Tyuiu.GrigorevKU.Sprint3.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 1.8;
            int startValue = 1;
            int stopValue = 2;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 0.069;
            Assert.AreEqual(wait, res);
        }
    }
}
