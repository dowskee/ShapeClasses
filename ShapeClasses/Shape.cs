using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{
    abstract class Shape//mark class as abstract
    { //all abstract methods are virtual by default
        public abstract void Draw(); //finish with semicolon instead of putting code below, as they are also abstract (like the class)

        public abstract double GetArea(); //if you only have abstract methods, than this would be an interface, not an abstract class

        public override string ToString() //this method has code, so our class will remain abstract instead of interface. 
        {
            return "The area of this shape is" + GetArea();
        }
    }
}
