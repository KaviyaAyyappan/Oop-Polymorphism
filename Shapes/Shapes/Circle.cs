using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle :Shape
    {
        public double radius { get; private set; }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public override double CalculateArea()
        {
            return 3.14 * Radius * Radius;
        }
        public override double CalculatePerimeter()
        {
            return 2 * 3.14 * Radius;
        }
        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
