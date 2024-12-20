using System;
//I created user response when saving file and when loading file. I also added Thread to show saving and loading of files.
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop06 World!");
        GoalManager gm = new GoalManager();
        gm.Start();
    }
}