using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop06 World!");

        SimpleGoal s1 = new SimpleGoal("test simple", "Testing Simple Goal", "5");
        Console.WriteLine($"{s1.GetDescription()}");
        Console.WriteLine($"{s1.GetDetailsSring()}, {s1.IsComplete()}");
        s1.RecordEvent();
        Console.WriteLine($"{s1.GetDescription()}: {s1.GetDetailsSring()}, {s1.IsComplete()}");


        ChecklistGoal c1 = new ChecklistGoal("test checklist", "testing checklist goal", "3", 3, 4, 600);
        Console.WriteLine($"{c1.GetDescription()}: {c1.GetDetailsSring()}, {c1.IsComplete()}");
        c1.RecordEvent();
        Console.WriteLine($"{c1.GetDescription()}: {c1.GetDetailsSring()}, {c1.IsComplete()}");
        

        EternalGoal e1 = new EternalGoal("test eternal goal", "testing eternal goals", "0");
        Console.WriteLine($"{e1.GetDescription()}: {e1.GetDetailsSring()}, {e1.IsComplete()}");
        e1.RecordEvent();
        Console.WriteLine($"{e1.GetDescription()}: {e1.GetDetailsSring()}, {e1.IsComplete()}");
    }
}