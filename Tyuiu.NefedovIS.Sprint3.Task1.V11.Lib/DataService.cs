﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NefedovIS.Sprint3.Task1.V11.Lib
{
    public class DataService : ISprint3Task1V11
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double res = 1; 
            while (startValue <= stopValue)
            {
                res *= Math.Pow(value, startValue) + 1.0 / 2; 
                startValue++;
            }
            return Math.Round(res, 3);
        }
    }
}
