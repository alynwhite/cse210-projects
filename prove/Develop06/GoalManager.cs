using System;
using System.IO;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void DisplayMenu()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("\t1. Create New Goals");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Event");
        Console.WriteLine("\t6. Quit");
        Console.Write("Select a choice from the menu: ");
    }
    public void Start()
    {
        bool go = true;
        while (go)
        {
            DisplayPlayerInfo();
            DisplayMenu();
            string user_input = Console.ReadLine();
            if (user_input == "1" || user_input == "Create")
            {
                CreateGoal();
            }
            else if (user_input == "2" || user_input == "List")
            {
                ListGoalDetails();
            }
            else if (user_input == "3" || user_input == "Save")
            {
                SaveGoals();
            }
            else if (user_input == "4" || user_input == "Load")
            {
                LoadGoals();
            }
            else if (user_input == "5" || user_input == "Record")
            {
                RecordEvent();
            }
            else
            {
                go = false;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }
    public void ListGoalNames()
    {
        if(_goals.Count != 0){
            for (int i = 0; i < _goals.Count; i++)
            {
                if (_goals[i].IsComplete() != true)
                {
                    Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
                }
            }
        }
        
    }
    public void ListGoalDetails()
    {
        if(_goals.Count < 1){
            Console.WriteLine("You have no goals currently.");
        }
        else{
            for (int i = 0; i < _goals.Count; i++)
            {
                if (_goals[i].IsComplete())
                {
                    Console.WriteLine($"[X] {_goals[i].GetName()} ({_goals[i].GetDescription()})");
                }
                else
                {
                    Console.WriteLine($"[ ] {_goals[i].GetName()} ({_goals[i].GetDescription()})");
                }

            }
        }
        
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string user_input = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string short_name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string short_description = Console.ReadLine();

        Console.Write("What is the amount of points you want associated with your goal? ");
        string points = Console.ReadLine();
        if (user_input == "1" || user_input == "Simple Goal" || user_input == "simple goal" || user_input == "simple")
        {
            SimpleGoal s1 = new SimpleGoal(short_name, short_description, points);
            _goals.Add(s1);
        }
        else if (user_input == "2" || user_input == "Eternal Goal" || user_input == "eternal goal" || user_input == "eternal")
        {
            EternalGoal e1 = new EternalGoal(short_name, short_description, points);
            _goals.Add(e1);
        }
        else if (user_input == "3" || user_input == "Checklist Goal" || user_input == "checklist goal" || user_input == "checklist")
        {
            Console.Write("How many times do you want to do this goal before its complete? ");
            string turn_to_int_input = Console.ReadLine();
            int target = int.Parse(turn_to_int_input);
            Console.Write("How much bonus points do you want, once the goal is completed? ");
            turn_to_int_input = Console.ReadLine();
            int bonus = int.Parse(turn_to_int_input);
            ChecklistGoal c1 = new ChecklistGoal(short_name, short_description, points, 0, target, bonus);
            _goals.Add(c1);
        }
    }
    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string user_input = Console.ReadLine();
        int index = int.Parse(user_input);
        _goals[index - 1].RecordEvent();
        Console.WriteLine($"Congrats! You earned {_goals[index - 1].GetPoints()} ");
        _score += _goals[index - 1].GetPoints();
        Console.WriteLine($"Your score is {_score}");
    }
    public void SaveGoals()
    {
        Console.Write("What file name do you want your goals saved to(include .txt)? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_score}");
            for (int i = 0; i < _goals.Count; i++)
            {
                outputFile.WriteLine($"{_goals[i].GetStringRepresentation()}~{_goals[i].GetDetailsString()}");
            }
        }
        List<String> animationStrings = new List<string> { "|", "/", "-", "\\", "|", "/", "-", "\\" };
        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
        Console.WriteLine("Saved file");
        Thread.Sleep(1000);
    }

    public void LoadGoals()
    {
        Console.Write("What file name did you want uploaded? (include .txt):  ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        bool isFirstLine = true;

        foreach (string line in lines)
        {
            if (isFirstLine)
            {
                _score = int.Parse(line);
                isFirstLine = false;
            }
            else
            {
                string[] parts = line.Split("~");
                string goal_object = parts[0];
                string goal_details = parts[1];
                CreateObject(goal_object, goal_details);
            }
        }
        List<String> animationStrings = new List<string> { "|", "/", "-", "\\", "|", "/", "-", "\\" };
        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
        Console.WriteLine("Files loaded");
        Thread.Sleep(1000);
    }
    public void CreateObject(string goal_object, string goal_details)
    {
        string[] details = goal_details.Split("|");
        if (goal_object != "ChecklistGoal")
        {
            string shortname = details[0];
            string description = details[1];
            string completedStatus = details[2];
            string points = details[3];
            if (goal_object == "SimpleGoal")
            {
                SimpleGoal s2 = new SimpleGoal(shortname, description, points);
                if (completedStatus == "True")
                {
                    s2.RecordEvent();
                }
                _goals.Add(s2);
            }
            else
            {
                EternalGoal e2 = new EternalGoal(shortname, description, points);
                _goals.Add(e2);
            }
        }
        else
        {
            string shortname = details[0];
            string description = details[1];
            string points = details[2];
            string target = details[3];
            string complete = details[4];
            string bonus = details[5];

            ChecklistGoal c2 = new ChecklistGoal(shortname, description, points, int.Parse(complete), int.Parse(target), int.Parse(bonus));
            _goals.Add(c2);
        }
    }
}