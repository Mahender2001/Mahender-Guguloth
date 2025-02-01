using System;

class Person
{
    
    public string Name { get; set; }

    
    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            if (value <= 0) 
            {
                throw new ArgumentException("Age must be a positive number.");
            }
            age = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
           
            Person person = new Person();

            Console.Write("Enter your name: ");
            person.Name = Console.ReadLine();

         
            Console.Write("Enter your age: ");
            int ageInput = int.Parse(Console.ReadLine()); 
            person.Age = ageInput; 

           
            Console.WriteLine($"Name: {person.Name} Age: {person.Age}");
        }
        catch (ArgumentException ex)
        {
            
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException)
        {
          
            Console.WriteLine("Error: Age must be a valid number.");
        }
        catch (Exception ex)
        {
            
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
