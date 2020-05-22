using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animals
    {
        public string name { get; protected set; }
        public string favoriteFood { get; protected set; }

        protected Animals(string name, string favoriteFood)
        {
            this.name = name;
            this.favoriteFood = favoriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am  { this.name} and my favorite food is { this.favoriteFood}";
        }
    }
    public class Cat : Animals
    {
        public Cat(string name, string favoriteFood) : base(name, favoriteFood)
        {

        }


        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "Meow";
        }


    }
    public class Dog : Animals
    {
        public Dog(string name, string favoriteFood) : base(name, favoriteFood)
        {

        }


        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "Whoof";
        }

    }
}