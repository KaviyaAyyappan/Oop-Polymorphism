using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(21.5,15.9);
            Console.WriteLine(rectangle.Draw());
            Console.WriteLine("RectangleArea\n" + rectangle.CalculateArea() + "\nRectanglePerimeter\n" + rectangle.CalculatePerimeter());
            Console.WriteLine("************************************");
            Circle circle = new Circle(8.1);
            Console.WriteLine(circle.Draw());
            Console.WriteLine("CircleArea\n" + circle.CalculateArea() +"\nCirclePerimeter\n" + circle.CalculatePerimeter());

            Console.ReadLine();


        }
    }
}
