using System;

public class Entry {
    public PromptGenerator _generator = new PromptGenerator();
    public string _date;
    string _promptText;
    string _entryText;

    public void FillEntry() {
        _promptText = _generator.GetRandomPrompt();
        Console.Write(_promptText);
        _entryText = $"{_date}: {_promptText} {Console.ReadLine()}";
    }

    public void Display() {
        Console.WriteLine(_entryText);
    }
}