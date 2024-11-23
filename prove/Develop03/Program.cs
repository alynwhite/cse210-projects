using System;

class Program
{
    static void Main(string[] args)
    {
        bool continue_scripture = true;
        Random rng = new Random();
        int random_number = 0;
        Reference r1 = new Reference("Proverbs", 3, 5, 6);
        Scripture s1 = new Scripture(r1, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
         Console.WriteLine(s1.GetDisplayText());

        do{
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string user_input = Console.ReadLine();
            continue_scripture = false;
            if (user_input == "quit" || s1.IsCompletelyHidden() == true){
                continue_scripture = false;
            }
            else{
                Console.Clear();
                random_number = s1.GetWordsLength();
                int numberToHide = rng.Next(random_number);
                s1.HideRandomWords(numberToHide);
                Console.WriteLine(s1.GetDisplayText());
                continue_scripture = true;
                Console.WriteLine(s1.IsCompletelyHidden());
            }
        }while(continue_scripture == true);

        Console.WriteLine($"I hope you were able to memorize your scripture, {r1.GetDisplayText()}");
    
    }
}