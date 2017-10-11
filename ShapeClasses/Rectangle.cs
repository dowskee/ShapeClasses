using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{
    class Rectangle:Shape
    {
        private double width;
        private double length;

        public double Width
        {
            set { width = value; }
            get { return width; }
        }
        
        public double Length
        {
            set { length = value; }
            get { return length; }
        }

        public Rectangle()
        {
            Length = 0;
            Width = 0;
        }

        public Rectangle(double l, double w)
        {
            Length = l;
            Width = w;
        }

        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle!");
        }

        public override double GetArea()
        {
            return Width * Length;
        }
    }
}
