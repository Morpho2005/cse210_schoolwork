using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity = new ListingActivity();
        int choice = 0;
        while (choice != 4){
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            Console.Clear();
            if (choice == 1){
                breathingActivity.Run();
            } else if (choice == 2){
                reflectionActivity.Run();
            } else if (choice == 3){
                listingActivity.Run();
            }
            Thread.Sleep(2000);
        }
    }
}