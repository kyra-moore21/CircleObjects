using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjects
{
    public class Circle
    {
        //properties
        private double Radius { get; set; }

        //constructor 
        public Circle(double _radius) 
        { 
            Radius = _radius;
        } 

        //methods 
        public double CalculateDiameter()
        {
            return 2 * Radius;
        }
        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public void Grow()
        {
            Radius *= 2;
        }
        public double GetRadius()
        {
            return Radius;
        }
    }
}
