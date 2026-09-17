using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
    string userinput;
    int percentage;
    string letter;
    bool Pass;
     Console.Write("What is your percentage in your class?: ");
     userinput = Console.ReadLine();
      percentage  =int.Parse(userinput);
    Console.WriteLine($"Your Percentage in your class is {percentage}%");
    if (percentage <= 93 && percentage >= 100)
        {
            //Console.Write("A");
            letter = "A";
            Pass =true;
        }
    else if  (percentage <= 90 && percentage >= 92.99)
        {
            //Console.Write("A-");
            letter = "A-";
            Pass =true;
        }
     else if  (percentage <= 87 && percentage >= 89.99)
        {
            //Console.Write("B+");
            letter = "B+";
            Pass =true;
        }
    else if  (percentage <= 83 && percentage >= 86.99)
        {
            //Console.Write("B");
             letter = "B";
             Pass =true;
        }
        else if  (percentage <= 80 && percentage >= 82.99)
        {
            //Console.Write("B-");
            letter = "B-";
            Pass =true;
        }
            else if  (percentage <= 77 && percentage >= 79.99)
        {
            //Console.Write("C+");
            letter = "C+";
            Pass =true;
        }
            else if  (percentage <= 73 && percentage >= 76.99)
        {
            //Console.Write("C");
            letter = "C";
            Pass =true;
        }
            else if  (percentage <= 70 && percentage >= 72.99)
        {
            //Console.Write("C-");
            letter = "C=";
            Pass =true;
        }
            else if  (percentage <= 67 && percentage >= 69.99)
        {
            //Console.Write("D+");
            letter = "D+";
             Pass = false;
        }
            else if  (percentage <= 65 && percentage >= 66.99)
        {
            //Console.Write("D");
            letter = "D";
             Pass = false;
        }
        else
        {
            //Console.Write("F");
            letter = "F";
            Pass = false;
        }
        Console.WriteLine($"Your Letter grade from the course is {letter}.");
        if (Pass == true)
        {
            Console.WriteLine($"You passed your course congrats!!");
        }
        else
        {
            Console.WriteLine($" You failed your course, next time put in more effort!");
        }

    
    }
}