using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{
    class Circle:Shape 
    {
        //We can implement the override methods for Circle from the Shape class
        private double radius; 

        public double Radius
        {
            set { radius = value; }
            get { return radius; }
        }

        public Circle()
        {
            radius = 0; //base conductor
        }

        public Circle(double r)
        {
            Radius = r; //initialze radius to user input
        }

        public override void Draw() //having both of these overrides now makes this a concrete class
        {
            Console.WriteLine("Draw a Circle!");
        }

        public override double GetArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
