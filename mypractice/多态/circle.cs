using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    public class circle:Shape
    {

        private double _r;

        public double R
        {
            get { return _r; }
            set { _r = value; }
        }


        public circle (double r)
        {
            this.R = r;
        }
        public override double perimeter()
        {
            return 2 * Math.PI * this.R;
        }

        public override double area()
        {
            return Math.PI * this.R * this.R;
        }
    }
}
