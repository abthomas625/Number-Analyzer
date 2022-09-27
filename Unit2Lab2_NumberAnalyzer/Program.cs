// See https://aka.ms/new-console-template for more information

using System.Collections.Concurrent;

Console.WriteLine("What would you like to be called?");
string name = Console.ReadLine();

bool goOn = true;

while (goOn)
{
    Console.WriteLine("Enter a number between 1 and 100.");
    int num = int.Parse(Console.ReadLine());

    bool pos = num > 0;

    if (pos)
    {
        if (num > 0)
        {
            Console.WriteLine("Good job, " + name + "! This is a positive number.");
        }

        if (num < 60 && num % 2 != 0)
        {
            Console.WriteLine("This number is odd and less than 60.");
        }
        else if (num > 60 && num % 2 != 0)
        {
            Console.WriteLine("This number is odd and greater than 60.");
        }
        else if (num < 60 && num % 2 == 0)
        {
            Console.WriteLine("This number is even and less than 60.");
        }
        else if (num > 60 && num % 2 == 0)
        {
            Console.WriteLine("This number is even and greater than 60.");
        }

        if (num % 2 == 0 && num >= 2 && num <= 24)
        {
            Console.WriteLine("This number is even and less than 25.");
        }
        else if (num % 2 == 0 && num <= 2 && num <= 24)
        {
            Console.WriteLine("This number is even and greater than 25.");
        }
        else if (num % 2 == 0 && num >= 2 && num >= 24)
        {
            Console.WriteLine("This number is even and greater than 25.");
        }
        else if (num % 2 != 0 && num >= 2 && num <= 24)
        {
            Console.WriteLine("This number is odd and less than 25.");
        }

        if (num % 2 == 0 && num >= 26 && num <= 60)
        {
            Console.WriteLine("This number is even and between 26 and 60, inclusively.");
        }
        else if (num % 2 == 0 && num >= 26 && num >= 60)
        {
            Console.WriteLine("This number is even and greater than 60");
        }
        else if (num % 2 != 0 && num >= 26 && num <= 60)
        {
            Console.WriteLine("This number is odd and between 26 and 60, inclusively.");
        }
        else if (num % 2 != 0 && num >= 26 && num >= 60)
        {
            Console.WriteLine("This number is odd and greater than 60.");
        }
    }
    else
    {
        Console.WriteLine(name + ", this is a negative number. Please don't disappoint me again.");
    }

    bool restart = true;
    while (restart)
    {
        Console.WriteLine("Would you like to input another number? Y/N");
        string input = Console.ReadLine().ToLower();

        if(input == "y")
        {
            goOn = true;
            restart = false;
        }
        else if(input == "n")
        {
            goOn = false;
            restart = false;
        }
        else
        {
            Console.WriteLine("Sorry, " + name + ". I couldn't understand that. Please try again.");
            restart = true;
        }
    }
}   