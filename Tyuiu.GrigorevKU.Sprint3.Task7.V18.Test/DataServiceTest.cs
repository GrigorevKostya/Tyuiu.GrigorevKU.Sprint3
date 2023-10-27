using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorevKU.Sprint3.Task7.V18.Lib;
namespace Tyuiu.GrigorevKU.Sprint3.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -45.83;
            valueWaitArray[1] = 17.83;
            valueWaitArray[2] = 11.09;
            valueWaitArray[3] = 19.82;
            valueWaitArray[4] = -5.25;
            valueWaitArray[5] = 2;
            valueWaitArray[6] = 4.15;
            valueWaitArray[7] = 4.60;
            valueWaitArray[8] = 4.97;
            valueWaitArray[9] = 1.35;
            valueWaitArray[10] = 34.68;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
