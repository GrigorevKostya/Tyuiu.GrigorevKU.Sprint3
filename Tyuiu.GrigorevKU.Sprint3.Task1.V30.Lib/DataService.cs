using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GrigorevKU.Sprint3.Task1.V30.Lib
{
    public class DataService : ISprint3Task1V30
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multSeries = 0;
            while (startValue <= stopValue)
            {
                multSeries = multSeries + (((Math.Pow(0.5, startValue)) + (5.0 / (startValue + 4.0))) * Math.Sin(0.5));
                startValue++;
            }
            return Math.Round(multSeries, 3);
        }
    }
}
