public class BreathingActivity : Activity{
    public BreathingActivity(string name, string description): base(name, description){}

    public void Run(){
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        DateTime currentTime = DateTime.Now;
        Console.Write("Get Ready...");
        ShowSpinner(3);
        Console.Clear();
        while(currentTime < futureTime){
            Console.Write($"\nBreathe In ...");
            ShowCountDown(5);
    
            Console.Write("\nBreath out...");
            ShowCountDown(5);
            currentTime = DateTime.Now;
        }
        Console.Clear();
        DisplayEndingMessage();
    }
}