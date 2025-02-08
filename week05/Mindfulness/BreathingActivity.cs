class BreathingActivity : Activity{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. clear your mind and focus on your breathing."){}

    public void Run(){
        Console.Clear();
        DisplayStartingMessage();

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(8);
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        bool firstBreath=true;
        do {
            if (firstBreath){
                Console.Write("Breathe in...");
                ShowCountdown(2);
                Console.Write("Now breathe out...");
                ShowCountdown(3);
                firstBreath=false;
            } else {
                Console.Write("Breathe in...");
                ShowCountdown(4);
                Console.Write("Now breathe out...");
                ShowCountdown(6);
            }
            Console.WriteLine();
        } while ( (DateTime.Now < endTime));

        Console.WriteLine("Well done!!");
        ShowSpinner(8);

        Console.Clear();
        DisplayEndingMessage();
    }
}