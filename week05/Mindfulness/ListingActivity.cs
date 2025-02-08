class ListingActivity : Activity{
    int _count;
    List<string> _prompts = new List<string>();

    public ListingActivity () : base("Listing activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."){
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run(){
        Console.Clear();
        DisplayStartingMessage();

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(8);
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(8);

        _count=GetListFromUser().Count;
        
        Console.WriteLine($"Well done!! you listed {_count} items");
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

    public List<string> GetListFromUser(){
        List<string> strings = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        Console.WriteLine("List as many items as possible");

        do {
            strings.Add(Console.ReadLine());
        } while ( (DateTime.Now < endTime));

        return strings;
    }
}