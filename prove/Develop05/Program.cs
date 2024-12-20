using System;
using System.Runtime.InteropServices;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");
        //Breathing Activity: "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
        // Reflection Description: "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
        // Listing Description: "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        List<string> prompts = new List<string>{"How does the concept of time shape our lives?", "What is the nature of consciousness?", "Can we ever truly know someone else?", "Is there a purpose to suffering?", "What would a perfect society look like?", "Do we have free will, or is everything predestined?", "What is the meaning of life?", "How does memory shape our identity?", "What is the role of art in human experience?", "Is technology making us more or less human?", "Can happiness be a choice?", "What happens after we die?", "What defines true intelligence?", "How much control do we have over our emotions?", "What does it mean to live authentically?", "Do we create our own reality?", "What does it mean to be truly free?", "Can love be unconditional?", "How do we know what's real?", "What is the relationship between perception and truth?", "Who are the people that you appreciate?", "Waht are personal strengths of yours?", "When have you felt the Holy Ghose this month?", "Who are some of your personal heroes?"};

        List<string> questions = new List<string>{"How did I feel during this experience?", "What did I learn from this situation?", "What would I do differently next time?", "What was my initial reaction and how did it change?", "What assumptions did I make?", "What could I have done to improve the outcome?", "How does this relate to my past experiences?", "What strengths did I demonstrate?", "What challenges did I face and how did I overcome them?", "What am I proud of in this situation?", "What could I have done to prepare better?", "What feedback did I receive and how did I respond?", "How does this experience align with my goals?", "What new perspectives have I gained?", "What did I learn about myself?", "How can I apply this learning in the future?", "What emotions did I experience, and why?", "What is the most important takeaway from this?", "How has my thinking changed?", "How will this experience impact my next steps?","Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};
      
        string user_input = "";
        bool go = true;
        do{
            DisplayMenu();
            user_input = Console.ReadLine();
            if(user_input == "1"){
                BreathingActivity b1 = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                b1.Run();
            }
            else if(user_input == "2"){
                RelflectingActivity r1 = new RelflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", prompts, questions);
                r1.Run();
            }
            else if(user_input == "3"){
                ListingActivity l1 = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",0, prompts);
                l1.Run();
            }
            else{
                go = false;
            }
            Thread.Sleep(2000);
            Console.Clear();
        }while(go);
    }
     static void DisplayMenu(){
        List<string> _menu = new List<string>{"1. Start breathing activity", "2. Start reflecting activity", "3. Start listing activity", "4. Quit"};
        Console.WriteLine("Menu Options:");
        foreach (string m in _menu){
            Console.WriteLine($"\t{m}");
        }
        Console.Write("Select a choice form the menu: ");
    }
}