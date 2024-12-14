public class RelflectingActivity : Activity{
    private List<string> _prompts;
    private List<string> _questions;

    public RelflectingActivity(string name, string description, List<string> prompts, List<string> questions) :base(name, description){
        _prompts = prompts;
        _questions = questions;
    }

    public void Run(){
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        DateTime currentTime = DateTime.Now;
        Console.WriteLine("Get Ready...");
        ShowSpinner(4);
        Console.WriteLine("Consider the following prompt: ");
        DisplayPrompt();
        Console.Write("You may begin in: ");
        ShowSpinner(5);
        while(currentTime < futureTime){
            // Console.Write("---");
            Console.Clear();
            DisplayQuestions();
            ShowSpinner(10);
            currentTime = DateTime.Now;
        }
        DisplayEndingMessage();
    }

    public string GetRandomPrompt(){
        Random r1 = new Random();
        int index = r1.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion(){
        Random r1 = new Random();
        int index = r1.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt(){
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestions(){
        Console.Write($"> {GetRandomQuestion()}");
    }
}