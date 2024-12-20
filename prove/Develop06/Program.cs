using System;
//I created user response when saving file and when loading file. I also added Thread to show saving and loading of files.
//Created a repsonse when displaying goals for either record event or listing goals that if goal.Count was empty, that they needed to create more goals
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop06 World!");
        GoalManager gm = new GoalManager();
        gm.Start();
    }
}