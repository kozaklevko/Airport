using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachka1
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Age { get; protected set; }
        public abstract int AgeCoef { get; }

        public Animal (string name)
        {
            this.Name = name;
        }

        public abstract void Voice();
        public abstract void AddAge(int age);

    }
    class Dog : Animal
    {
        public Dog(string name):base(name)
        {

        }
        public override int AgeCoef { get; } = 10;

        public override void AddAge(int age)
        {
            this.Age = age * this.AgeCoef;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void Voice()
        {
            Console.WriteLine("Gav-Gav"); 
        }
    }
    class Cat : Animal
    {
        public Cat(string name):base(name)
        {

        }
        public override int AgeCoef { get; } = 7;

        public override void AddAge(int age)
        {
            this.Age = age * this.AgeCoef;
        }

        public override void Voice()
        {
            Console.WriteLine("Meow-Meow"); 
        }
    }

    class Bird : Animal
    {
        public override int AgeCoef { get; }=100;

        public override void AddAge(int age)
        {
            this.Age = age / this.AgeCoef;
        }

        public override void Voice()
        {
            Console.WriteLine("Car-car"); 
        }
    }
    class Parrot : Bird
    {
        public Parrot(string name):base(name)
        {
        }
        public override void Voice()
        {
            Console.WriteLine("Parrot"); ;
        }
    }
    class Cenery : Bird
    {
        public Cenery(string name):base(name)
        {
        }
        public override void Voice()
        {
            Console.WriteLine("Canery"); 
        }
       // public new void AddAge();

    }


}
