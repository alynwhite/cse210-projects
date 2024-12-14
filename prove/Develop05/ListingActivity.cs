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
            ShowCountDown(10);
            Console.Write("Please list items here, press enter on empty line once finished: \n>");
            currentTime = DateTime.Now;
        }
        _count = GetListFromUser().Count;
        Console.WriteLine($"You wrote {_count} in your list today.");
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
            Console.Write("> ");
        }
        return userInput;
    }
}