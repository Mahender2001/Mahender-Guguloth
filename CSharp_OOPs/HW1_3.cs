using System;
using System.Collections.Generic;

abstract class Animal
{
    public string Name { get; set; }

    public abstract void MakeSound();

    public virtual void Describe()
    {
        Console.WriteLine($"This is an animal named {Name}.");
    }
}

interface IPet
{
    void Play();
}

class Dog : Animal, IPet
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }

    public override void Describe()
    {
        Console.WriteLine($"{Name} is a friendly and loyal dog.");
    }

    public void Play()
    {
        Console.WriteLine($"{Name} loves fetching the ball!");
    }
}

class Cat : Animal, IPet
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }

    public override void Describe()
    {
        Console.WriteLine($"{Name} is a curious and independent cat.");
    }

    public void Play()
    {
        Console.WriteLine($"{Name} enjoys playing with a ball of yarn!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog { Name = "Buddy" };
        Cat cat = new Cat { Name = "Whiskers" };

        Console.WriteLine("Individual Demonstration:");
        Console.WriteLine("--------------------------");
        dog.MakeSound();
        dog.Describe();
        dog.Play();

        Console.WriteLine();

        cat.MakeSound();
        cat.Describe();
        cat.Play();

        Console.WriteLine();

        Console.WriteLine("Polymorphism Demonstration:");
        Console.WriteLine("----------------------------");
        List<Animal> animals = new List<Animal> { dog, cat };

        foreach (Animal animal in animals)
        {
            animal.MakeSound();
            animal.Describe();

            if (animal is IPet pet)
            {
                pet.Play();
            }

            Console.WriteLine();
        }
    }
}
