using System;

// I added a function to keep going through the same scripture until they decide they are finished completely. It doesn't end unless they want to.
class Program
{
    static void Main(string[] args)
    {
        Random rng = new Random();
        int random_number = 0;
        string user_input = "";
        Reference r1 = new Reference("Proverbs", 3, 5, 6);
        Scripture s1 = new Scripture(r1, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        Console.WriteLine(s1.GetDisplayText());
        

        do{
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            user_input = Console.ReadLine();
            if (user_input == "quit"){
                user_input = "quit";
            }
            else{
                Console.Clear();
                if(s1.GetWordsLength() > 1){
                    random_number = s1.GetWordsLength();
                    int numberToHide = rng.Next(random_number);
                    s1.HideRandomWords(numberToHide);
                    Console.WriteLine(s1.GetDisplayText());
                }
                else if(s1.GetWordsLength() == 1){
                    s1.HideRandomWords(1);
                    Console.WriteLine(s1.GetDisplayText());
                }
                else{
                    Console.WriteLine("You finished! \n type enter to start over and 'quit' to end.");
                    user_input = Console.ReadLine();
                    if(user_input != "quit"){
                        s1.ClearWordsSlate();
                    }
                }
            }
        }while(user_input != "quit");

        Console.WriteLine($"I hope you were able to memorize your scripture: {r1.GetDisplayText()}");
    
    }
}