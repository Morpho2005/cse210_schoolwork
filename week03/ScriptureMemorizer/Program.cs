using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference();
        Console.Write("book in the scripture: ");
        string book = Console.ReadLine();
        Console.Write("chapter number: ");
        int chapter = int.Parse(Console.ReadLine());
        Console.Write("more than one verse? y/n ");
        string choice = Console.ReadLine();
        if (choice == "y"){
            Console.Write("start verse: ");
            int startVerse = int.Parse(Console.ReadLine());
            Console.Write("end verse: ");
            int endVerse = int.Parse(Console.ReadLine());
            reference.SetReference(book, chapter, startVerse, endVerse);
        } else if (choice == "n"){
            Console.Write("verse number: ");
            int ver = int.Parse(Console.ReadLine());
            reference.SetReference(book, chapter, ver);
        }
        Console.Write("scripture text: ");
        string script = Console.ReadLine();
        Scripture scripture = new Scripture(reference, script);
        string input = "";
        while (input != "quit"){
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.Write("enter quit to exit: ");
            input = Console.ReadLine();
            if (scripture.IsAllHidden()){
                input = "quit";
            }
            scripture.HideRandomWords(1);
        }
        Console.Clear();
    }
}