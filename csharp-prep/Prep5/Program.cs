using System;

class Program
{
    static void Main(string[] args)
    {
        DsiplayWelcome();
        string user_name = PromptUserName();
        int user_number = PromptUserNumber();
        int squared_number = SquareNumber(user_number);
        DisplayResult(user_name, squared_number);
    }
    
    static void DsiplayWelcome(){
        Console.WriteLine("Hello Prep5 World!");
    }

    static string PromptUserName(){
        Console.WriteLine("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber(){
        Console.WriteLine("Please enter you favorite number: ");
        string user_input = Console.ReadLine();
        int fav_num = int.Parse(user_input);
        return fav_num;
    }

    static int SquareNumber(int non_squared_num){
        int squared_num = (non_squared_num * non_squared_num);
        return squared_num;
    }
    
    static void DisplayResult(string userName, int squared_number){
        Console.WriteLine($"{userName}, the square of your number is {squared_number}");
    }
}