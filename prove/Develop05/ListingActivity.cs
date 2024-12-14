using Microsoft.VisualBasic;

public class ListingActivity : Activity{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int count, List<string> prompts) :base(name, description){
        _count = count;
        _prompts = prompts;
    }

    public void Run(){
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        DateTime currentTime = DateTime.Now;
        GetRandomPrompt();
        while(currentTime < futureTime){
            GetListFromUser();
        }
        DisplayEndingMessage();
    }

    public void GetRandomPrompt(){
        Random r1 = new Random();
        int index = r1.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }

    public List<string> GetListFromUser(){
        string line;
        List<string> userInput = new List<string>();
        while((line = Console.ReadLine()) != null && line != ""){
            userInput.Add(line);
        }
        return userInput;
    }
}