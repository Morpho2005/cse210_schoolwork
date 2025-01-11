using System;

class Program
{   

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        number = number * number;
        return number;
    }
    static void DisplayResult(string name, int Number)
    {
        Console.WriteLine($"{name}, the square of your number is {Number}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favorite = PromptUserNumber();
        int square = SquareNumber(favorite);
        DisplayResult(name, square);
    }
}