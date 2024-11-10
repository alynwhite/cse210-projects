using System;

class Program
{
    static void Main(string[] args)
    {
        string response;
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 12);
        int kount = 0;

        do{
            Console.WriteLine("What is the magic number? ");
            string mNum = Console.ReadLine();
            int magic_num = int.Parse(mNum);

            if (magic_num == number)
            {
                 response = "You guessed it!";
            }
            else if (magic_num < number){
                response = "Higher";
            }
            else{
                response ="Lower";
            }
            Console.WriteLine($"{response}");
            kount ++;
        }while (response != "You guessed it!");
        
    }
}