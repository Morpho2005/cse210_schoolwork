using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int newNumber = 1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (newNumber != 0) {
            Console.Write("enter number: ");
            newNumber = int.Parse(Console.ReadLine());
            numbers.Add(newNumber);
        }

        int totalSum = 0;
        foreach ( int number in numbers)
        {
            totalSum = totalSum + number;
        }
        Console.WriteLine($"The sum is: {totalSum}");

        float numAverage = totalSum/numbers.Count();
        Console.WriteLine($"The average is: {numAverage}");

        int largestNum = 0;
        foreach ( int number in numbers)
        {
            if (number > largestNum){
                largestNum = number;
            }
        }
        Console.WriteLine($"The largest number is: {largestNum}");
    }
}