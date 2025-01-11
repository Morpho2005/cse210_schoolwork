using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string userinput = Console.ReadLine();
        int usergrade = int.Parse(userinput);
        char letter;

        if (usergrade >= 90) {
            letter = 'A';
        } else if (usergrade >= 80) {
            letter = 'B';
        } else if (usergrade >= 70) {
            letter = 'C';
        } else if (usergrade >= 60) {
            letter = 'D';
        } else {
            letter = 'F';
        }

        if (usergrade >= 70) {
            Console.WriteLine($"You got a {letter}, that means you pass!");
        } else {
            Console.WriteLine($"You got a {letter}, this means you failed, too bad.");
        }
    }
}