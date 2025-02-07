class BreathingActivity : Activity{
    public BreathingActivity(int duration) : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. clear your mind and focus on your breathing.", duration){}

    public void Run(){
        DisplayStartingMessage();

        ShowSpinner(8);
    }
}