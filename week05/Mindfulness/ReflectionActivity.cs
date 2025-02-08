class ReflectionActivity : Activity{
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. this will help you recognize the power you have and how you can use it in other aspects of your life."){
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run(){
        Console.Clear();
        DisplayStartingMessage();

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(8);
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        Console.WriteLine(GetRandomPrompt());
        
        do {
            Console.WriteLine(GetRandomQuestion());
            Console.ReadLine();
            ShowSpinner(5);
        } while ( (DateTime.Now < endTime));
        
        Console.WriteLine("Well done!!");
        ShowSpinner(8);

        Console.Clear();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt(){
        Random random = new Random();
        int promptsnumber = random.Next(0, _prompts.Count());
        string prompt = _prompts[promptsnumber];
        return prompt;
    }

    public string GetRandomQuestion(){
        Random random = new Random();
        int questionnumber = random.Next(0, _questions.Count());
        string question = _questions[questionnumber];
        return question;
    }
}