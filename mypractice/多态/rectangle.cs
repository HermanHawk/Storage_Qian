using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    public  class  rectangle:Shape  
    {


        private double _height;

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }



        private double _width;

        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public rectangle(double height,double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override double perimeter()
        {
            return (this.Height + this.Width) * 2;
        }

        public override double area()
        {
            return Height * Width;
        }
    }
}
