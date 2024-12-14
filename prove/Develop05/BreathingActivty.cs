public class BreathingActivity : Activity{
    public BreathingActivity(string name, string description): base(name, description){}

    public void Run(){
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime){
            Console.Write($"Breathe In ...");
            ShowCountDown(5);
    
            Console.Write("\nBreath out...");
            ShowCountDown(5);
            currentTime = DateTime.Now;
        }
        DisplayEndingMessage();
    }
}