﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GrigorevKU.Sprint3.Task0.V26.Lib
{
    public class DataService : ISprint3Task0V26
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries * (((Math.Pow(2, i)) / (i + 1)) * Math.Cos(value));
            }
            return Math.Round(sumSeries, 3);
        }
    }
}