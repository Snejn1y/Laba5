using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeriesSumComponent;



namespace Laba5
{
    public class Tabul
    {
        public List<Point> tabul = new List<Point>();

        public void add(Point p)
        {
            tabul.Add(p);
        }

        public void GetList(double xn, double xk, double h)
        {
            try
            {
                double x = xn;
                double y = 0, y_for = 0, y_rek = 1;
                while (x < xk)
                {
                    y = (Math.PI * Math.PI - 3 * x * x) / 12;
                    y_for = SeriesSumCalculator.CalculateSumIteratively(x);
                    y_rek = SeriesSumCalculator.RecursiveSeriesSum(x, 1, 0.000001);
                    var point = new Point(x, y, y_for, y_rek);
                    tabul.Add(point);
                    x += h;
                }
            }
            catch (Exception e) { }
        }
    }
}
