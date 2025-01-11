using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = 0;

        do{
            Console.Write("What is your guess for the magic number? ");
            string input = Console.ReadLine();
            guess = int.Parse(input);

            if (guess > magicNumber) {
                Console.WriteLine("lower");
            } else if (guess < magicNumber) {
                Console.WriteLine("higher");
            } else {
                Console.WriteLine("You Got It!");
            }
        } while (guess != magicNumber);
    }
}