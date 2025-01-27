using System;

class Program
{
    static void Main(string[] args)
    {
       
        const string correctUsername = "Alice";
        const string correctPassword = "Wonderland123";

        try
        {
         
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new Exception("username cannot be empty");
            }

          
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("password cannot be empty");
            }

           
            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine($"Welcome, {username}! You have successfully logged in.");
            }
            else
            {
                Console.WriteLine("Login failed. Please check your username and password.");
            }
        }
        catch (Exception ex)
        {
         
            Console.WriteLine($"Unhandled Exception: {ex.Message}");
        }
    }
}
