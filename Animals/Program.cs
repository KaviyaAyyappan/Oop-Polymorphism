using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals cat = new Cat("Peter", "Whiskas");
            Animals dog = new Dog("Gunnar", "Meat");
            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
            Console.ReadLine();
        }
    }
}
