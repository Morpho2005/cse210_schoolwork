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
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage(){
        Console.WriteLine("Well Done!\n");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.\n");
    }

    public void ShowSpinner(int seconds){
        string spinner = "|";
        for (int i=0;i<seconds;i++){
            Console.Write(spinner);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            if (spinner == "|"){
                spinner = "/";
            } else if (spinner == "/"){
                spinner = "-";
            } else if (spinner == "-"){
                spinner = "\\";
            } else {
                spinner = "|";
            }
        }
        Console.WriteLine("");
    }

    public void ShowCountdown(int seconds){
        while(seconds>0){
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds--;
        }
        Console.WriteLine("");
    }

    public int GetDuration(){
        return _duration;
    }
}