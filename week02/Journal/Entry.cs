using System;

public class Entry {
    PromptGenerator _generator = new PromptGenerator();
    DateTime _currentTime = DateTime.Now;
    string _date;
    string _promptText;
    public string _entryText;

    public void FillEntry() {
        _date = _currentTime.ToShortDateString();
        _generator._prompts.Add("Who was the most interesting person I interacted with today?");
        _generator._prompts.Add("What was the best part of my day?");
        _generator._prompts.Add("How did I see the hand of the Lord in my life today?");
        _generator._prompts.Add("What was the strongest emotion I felt today?");
        _generator._prompts.Add("If I had one thing I could do over today, what would it be?");
        _promptText = _generator.GetRandomPrompt();
        Console.Write($"{_promptText} ");
        _entryText = $"{_date}: {_promptText} {Console.ReadLine()}";
    }

    public void Display() {
        Console.WriteLine(_entryText);
    }
}