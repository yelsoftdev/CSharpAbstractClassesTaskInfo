using System;

namespace CSharpAbstractClassesTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine("*******Input*******");
            Console.Write("Enter the dog name: ");
            dog.SetName(Console.ReadLine());
            Console.WriteLine("\n*******Output*******");
            Console.WriteLine(String.Format($"Name: {dog.GetName()}"));
            dog.Eat();
        }
    }
    public abstract class Animal
    {
        private string Name;

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public abstract void Eat();
    }
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog is Eating");
        }
    }
}
