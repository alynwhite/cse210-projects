using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");
        Reference r1 = new Reference("John", 3, 16);
        Console.WriteLine(r1.GetDisplayText());

        Reference r2 = new Reference("Proverbs", 3, 5, 6);
        Console.WriteLine(r2.GetDisplayText());

        Words w1 = new Words("pickles");
        Console.WriteLine(w1.IsHidden());
        Console.WriteLine(w1.GetDisplayText());

        w1.Hide();
        Console.WriteLine(w1.IsHidden());
        Console.WriteLine(w1.GetDisplayText());

        
        Words w2 = new Words("John");
        Console.WriteLine(w2.IsHidden());
        Console.WriteLine(w2.GetDisplayText());

        w2.Hide();
        Console.WriteLine(w2.IsHidden());
        Console.WriteLine(w2.GetDisplayText());
    
    }
}