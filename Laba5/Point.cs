using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    public class Point
    {
        double x, y, y_for, y_rek;
        public Point(double x, double y, double y_for, double y_rek)
        {
            this.x = x;
            this.y = y;
            this.y_for = y_for;
            this.y_rek = y_rek;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Y_for
        {
            get { return y_for; }
            set { y_for = value; }
        }

        public double Y_rek
        {            
            get { return y_rek; }
            set { y_rek = value; }
        }
    }
}
