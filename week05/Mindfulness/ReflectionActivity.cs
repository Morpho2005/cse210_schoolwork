class ReflectionActivity : Activity{
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();

    public ReflectionActivity(int duration) : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. this will help you recognize the power you have and how you can use it in other aspects of your life.", duration){}

    public void Run(){

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