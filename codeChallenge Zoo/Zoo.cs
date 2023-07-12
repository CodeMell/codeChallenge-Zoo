using System;

namespace ZooConsoleApp
{
   public class Animal
    {
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }
        public string Color { get; set; }

        public Animal(string name, int numberOfLegs, string color)
        {
            Name = name;
            NumberOfLegs = numberOfLegs;
            Color = color;
        }

        public string Eat()
        {
            return $"{Name} is eating.";
        }

        public string Sleep()
        {
            return $"{Name} is sleeping.";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Animal lion = new Animal("Lion", 4, "Yellow");
            Animal elephant = new Animal("Elephant", 4, "Gray");
            Animal snake = new Animal("Snake", 0, "Green");

            Console.WriteLine("Welcome to the Zoo!");
            Console.WriteLine();

            Console.WriteLine($"Animal: {lion.Name}");
            Console.WriteLine($"Number of Legs: {lion.NumberOfLegs}");
            Console.WriteLine($"Color: {lion.Color}");
            Console.WriteLine(lion.Eat());
            Console.WriteLine(lion.Sleep());
            Console.WriteLine();

            Console.WriteLine($"Animal: {elephant.Name}");
            Console.WriteLine($"Number of Legs: {elephant.NumberOfLegs}");
            Console.WriteLine($"Color: {elephant.Color}");
            Console.WriteLine(elephant.Eat());
            Console.WriteLine(elephant.Sleep());
            Console.WriteLine();

            Console.WriteLine($"Animal: {snake.Name}");
            Console.WriteLine($"Number of Legs: {snake.NumberOfLegs}");
            Console.WriteLine($"Color: {snake.Color}");
            Console.WriteLine(snake.Eat());
            Console.WriteLine(snake.Sleep());
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
