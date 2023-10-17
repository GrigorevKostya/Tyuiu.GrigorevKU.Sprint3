using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GrigorevKU.Sprint3.Task2.V6.Lib
{
    public class DataService : ISprint3Task2V6
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 1;
            double stv = Convert.ToDouble(startValue);
            Convert.ToDouble(stopValue);
            do
            {
                sumSeries = sumSeries * ((Math.Pow(0.25, stv) + 1) * Math.Cos(4));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(sumSeries, 3);

        }
    }
}
