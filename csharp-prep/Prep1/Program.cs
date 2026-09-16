using System;

class Program
{
    static void Main(string[] args)
    {
        string firstName;
        string lastName;
        Console.Write("Please Enter your first name:");
        firstName = Console.ReadLine();
        Console.Write("Please Enter your last name");
        lastName = Console.ReadLine();
        Console.Write ($"{firstName} {lastName}");
    }
}