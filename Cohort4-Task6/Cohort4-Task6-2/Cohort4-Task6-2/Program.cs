using System;

namespace Cohort4_Task6_2
{
    public interface ISound
    {
        void MakeSound();
    }

    public abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Eat();

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
    }

    public class Dog : Animal, ISound
    {
        public Dog(string Name) : base(Name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} Eat a Dog Food");
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} Say : Woof!");
        }
    }

    public class Cat : Animal, ISound
    {
        public Cat(string Name) : base(Name)
        {

        }
        public void MakeSound()
        {
            Console.WriteLine($"{Name} Say : Meow!");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} Eat a Cat Food");
        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Rottwiller");
            dog.Eat();
            dog.Sleep();
            dog.MakeSound();

            Console.WriteLine();
            Console.WriteLine("**********************");
            Console.WriteLine();

            Cat cat = new Cat("Kitty");
            cat.Eat();
            cat.Sleep();
            cat.MakeSound();
            Console.WriteLine();

            //Animal A = new Cat("Hello");
            //A.Eat();
            //A.Sleep();
            //if (Animal is ISound soundAnimal)
            //{
            //    soundAnimal.MakeSound();
            //}
        }
    }
}
