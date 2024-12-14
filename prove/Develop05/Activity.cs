using Microsoft.VisualBasic;

public class Activity{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description){
        _name = name;
        _description = description;
        //Set duration of activity
        Console.Write($"How long in seconds do you want your {_name} session to be? ");
        string user_duration = Console.ReadLine();
        int duration = int.Parse(user_duration);
        _duration = duration;
    }
    public int GetDuration(){
        return _duration;
    }
    public void DisplayStartingMessage(){
        Console.WriteLine($"Welcome to the {_name} Activity\n");
        Console.WriteLine($"{_description}");
    }

    public void DisplayEndingMessage(){
        Console.WriteLine("\nWell Done!\n");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity");
    }
    public void ShowSpinner(int seconds){
        List<String> animationStrings = new List<string>{"|","/","-", "\\", "|", "/", "-", "\\"};
        foreach(string s in animationStrings){
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds){
        for(int i = seconds; i > 0; i--){
            if(i > 9){
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b\b \b\b");
            }
            else if(i == 9){
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b\b");
            }
            else{
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
}