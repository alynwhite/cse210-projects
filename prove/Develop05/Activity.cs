public class Activity{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration){
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage(){
        Console.WriteLine($"Welcome to the {_name} Activity\n");
        Console.WriteLine($"{_description}");
    }

    public void DisplayEndingMessage(){
        Console.WriteLine("Well Done!\n");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity");
    }
    public void ShowSpinner(int seconds){
        
    }
}