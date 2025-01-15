using System;

public class PromptGenerator {
    public List<String> _prompts = new List<string>();

    public string GetRandomPrompt() {
        Random random = new Random();
        int _promptsnumber = random.Next(0, _prompts.Count()-1);
        string _prompt = _prompts[_promptsnumber];
        return _prompt;
    }
}