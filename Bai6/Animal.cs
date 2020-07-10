using System;
using System.Collections.Generic;
using System.Text;

namespace Bai6
{
    abstract class Animal
    {
        //public static void Main(string[] args)
        //{
        //    Animal[] animals = new Animal[2];
        //    animals[0] = new Tiger();
        //    animals[1] = new Chicken();

        //    foreach (Animal animal in animals)
        //    {
        //        Console.WriteLine(animal.makeSound());


        //        if (animal is Chicken)
        //        {
        //            IEdible edibler = (Chicken)animal;
        //            Console.WriteLine(edibler.Howtoeat());
        //        }
        //    }
        //}
        public abstract string makeSound();
    }
    class Chicken : Animal, IEdible
    {
        public string Howtoeat()
        {
            return " ";
        }

        public override string makeSound()
        {
            return "Chicken: chick - chick !";
        }
    }
    class Tiger : Animal
    {

        public override string makeSound()
        {
            return "Tiger: Roarrrrrrrrr !";
        }
    }
    interface IEdible
    {
        public string Howtoeat();
    }
    public abstract class Fruit : IEdible
    {
        public abstract string HowToeat();

        public string Howtoeat()
        {
            throw new NotImplementedException();
        }
    }
    public class Orange : Fruit
    {
        public override string HowToeat()
        {
            return "Orange could be juiced";
        }
    }
    public class Apple : Fruit
    {
        public override string HowToeat()
        {
            return "Apple could be slided";
        }
    }

}
