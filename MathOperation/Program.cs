using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            mathOperation math = new mathOperation();
            Console.WriteLine(math.Add(10, 10));
            Console.WriteLine(math.Add(10.2, 10.3, 10.4));
            Console.WriteLine(math.Add(10.2m, 10.3m, 10.3m));
            Console.ReadLine();
                
        }
    }
}
