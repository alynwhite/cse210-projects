using System;
using System.IO.Enumeration;
using System.Net;
//Improvements I completed: I added interaction with the user after saving a file or saving an entry or uploading from a file by writing to the console that the action has been done. 
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop02 World!");
        string user_input = "";
        Journal journal1 = new Journal();
        do
        {
            DisplayMenu();
            user_input = Console.ReadLine();

            if (user_input == "1")
            {
                Write(journal1);
            }
            else if (user_input == "2")
            {
                journal1.DisplayAll();
            }
            else if (user_input == "3"){
                Console.Write("What is the file name?(Pleae include file extension): ");
                string filename = Console.ReadLine();
                LoadingFile(filename, journal1);
            }
            else if (user_input == "4")
            {
                Console.Write("What is the file name(please include extension, i.e. .txt): ");
                string filename = Console.ReadLine();
                SavingFile(filename, journal1);
            }

        } while (user_input != "5");

    }

    static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices by entering in the associated number: \n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
    }

    static void Write(Journal journal1)
    {
        //Create a new entry object;
        Entry entry1 = new Entry();
        PromptGenerator prompt1 = new PromptGenerator();
        entry1._promptText = prompt1.GetRandomPrompt();
        DateTime theCurrentTime = DateTime.Now;
        entry1._date = theCurrentTime.ToShortDateString();
        Console.Write($"{entry1._promptText}\n>");
        entry1._entryText = Console.ReadLine();
        journal1.AddEntry(entry1);
        Console.WriteLine("Saved entry");

    }

    static void LoadingFile(string filename, Journal journal1){
        journal1.LoadFromFile(filename);
        Console.WriteLine($"Uploaded from {filename}");
    }
    static void SavingFile(string filename, Journal journal1)
    {
        journal1.SaveToFile(filename);
        Console.WriteLine($"Saved to {filename}");
    }
}