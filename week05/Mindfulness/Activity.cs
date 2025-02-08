class Activity{
    string _name;
    string _description;
    int _duration;

    public Activity(string name, string description){
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage(){
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
    }

    public void DisplayEndingMessage(){
        Console.WriteLine("Well Done!\n");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void ShowSpinner(int seconds){
        string spinner = "|";
        Console.Write(spinner);
        Console.Write("\b \b");
        while(seconds>0){
            Thread.Sleep(1000);
            seconds--;
            if (spinner == "|"){
                spinner = "/";
            } else if (spinner == "/"){
                spinner = "-";
            } else if (spinner == "-"){
                spinner = "\\";
            } else {
                spinner = "|";
            }
            Console.Write(spinner);
            Console.Write("\b \b");
        }
        Console.WriteLine("");
    }

    public void ShowCountdown(int seconds){
        Console.Write(seconds);
        Console.Write("\b \b");
        while(seconds>0){
            Thread.Sleep(1000);
            seconds--;
            Console.Write(seconds);
            Console.Write("\b \b");
        }
        Console.WriteLine("");
    }

    public int GetDuration(){
        return _duration;
    }
}