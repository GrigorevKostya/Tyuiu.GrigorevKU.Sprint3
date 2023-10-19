using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorevKU.Sprint3.Task0.V26.Lib;
namespace Tyuiu.GrigorevKU.Sprint3.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 2;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            double wait = 0.069;
            Assert.AreEqual(wait, res);
        }
    }
}
