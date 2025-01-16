using System;
using System.IO;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice = "1";
        while (choice != "0"){
            Console.WriteLine("Press 1 to create a new entry");
            Console.WriteLine("Press 2 to display the all pages of the journal");
            Console.WriteLine("Press 3 to save the journal file");
            Console.WriteLine("Press 4 to load a journal file");
            Console.WriteLine("Press 0 to close out the program");
            Console.Write("Enter: ");
            choice = Console.ReadLine();
            if (choice == "1") {
                journal.AddEntry();
            } else if (choice == "2") {
                journal.DisplayAll();
            } else if (choice == "3") {
                journal.SaveToFile();
            } else if (choice == "4") {
                journal.LoadFromFile();
            } else if (choice != "0") {
                Console.WriteLine("invalid option");
            }
        }
    }
}