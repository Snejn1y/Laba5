using System;
using System.ComponentModel;
using System.Diagnostics;

namespace SeriesSumComponent
{
    public class SeriesSumCalculator : Component
    {
        public static double CalculateSumIteratively(double x, double tolerance = 0.000001)
        {
            double sum = (-1) * (-1) * Math.Cos(x);
            double previousSum = 0.0;
            int i = 2;

            while(Math.Abs(sum - previousSum) > tolerance)
            {
                previousSum = sum;
                double term = Math.Pow(-1, i + 1) * (Math.Cos(i * x) / (i * i));
                sum += term;
                i++;
            }

            return sum;
        }

        public static double RecursiveSeriesSum(double x, int i, double tolerance)
        {
            double term = Math.Pow(-1, i + 1) * (Math.Cos(i * x) / (i * i));
            if (i != 1 && Math.Abs(term) < tolerance)
                return 0;

            return term + RecursiveSeriesSum(x, i + 1, tolerance);
        }

    }
}
