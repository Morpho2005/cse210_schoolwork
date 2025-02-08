class BreathingActivity : Activity{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. clear your mind and focus on your breathing."){}

    public void Run(){
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(8);

        bool firstBreath=true;
        while (startTime < endTime){
            if (firstBreath){
                Console.Write("Breathe in...");
                ShowCountdown(2);
                Console.Write("\nNow breathe out...");
                ShowCountdown(3);
                firstBreath=false;
            } else {
                Console.Write("Breathe in...");
                ShowCountdown(4);
                Console.Write("\nNow breathe out...");
                ShowCountdown(6);
            }
            Console.WriteLine();
            startTime=DateTime.Now;
        }
        Console.WriteLine("Well done!!");
        ShowSpinner(8);
        Console.WriteLine("\n");
        DisplayEndingMessage();
    }
}