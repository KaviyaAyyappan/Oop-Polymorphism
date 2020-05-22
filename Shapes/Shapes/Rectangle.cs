using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle :Shape
    {
        public double height { get; private set; }
        public double width { get; private set; }

        public Rectangle(double height,double width)
        {
            this.Height = height;
            this.Width = width;
        }
        
        public double Height
        {
            get { return height; }
            set { height=value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public override double CalculateArea()
        {
            return Width * Height;
        }
        public override double CalculatePerimeter()
        {
            return 2 * Width + 2 * Height; 
                }
        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
