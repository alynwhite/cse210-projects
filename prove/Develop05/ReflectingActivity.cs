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
        DisplayPrompt();
        while(currentTime < futureTime){
            DisplayQuestions();
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
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions(){
        Console.WriteLine(GetRandomQuestion());
    }
}