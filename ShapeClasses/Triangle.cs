using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{
    class Triangle:Shape
    {
        private double tbase;

        private double height;

        public double Base
        {
            set { tbase = value; }
            get { return tbase; }
        }

        public double Height
        {
            set { height = value; }
            get { return height; }
        }

        public Triangle()
        {
            Base = Height = 0;

        }

         public Triangle(double b, double h)
        {
            Base = b;
            Height = h;

        }

        public override void Draw()
        {
            Console.WriteLine("Draw a Triangle!");
        }

        public override double GetArea()
        {
            return Height * Base / 2;
        }

    }
}
