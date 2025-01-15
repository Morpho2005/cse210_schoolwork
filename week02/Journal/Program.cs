using System;

class Program
{
    static void Main(string[] args)
    {
        Entry entry = new Entry();
        entry._generator._prompts.Add("Who was the most interesting person I interacted with today?");
        entry._generator._prompts.Add("What was the best part of my day?");
        entry._generator._prompts.Add("How did I see the hand of the Lord in my life today?");
        entry._generator._prompts.Add("What was the strongest emotion I felt today?");
        entry._generator._prompts.Add("If I had one thing I could do over today, what would it be?");

        entry._date = "1/15/2025";
        entry.FillEntry();
        entry.Display();
    }
}