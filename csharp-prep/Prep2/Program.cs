using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade_percentage = Console.ReadLine();

        int grade_num = int.Parse(grade_percentage);
        string grade_letter;

        if (grade_num >= 90)
        {
            grade_letter = "A";
        }
        else if (grade_num >= 80)
        {
            grade_letter = "B";
        }
        else if (grade_num >= 70)
        {
            grade_letter = "C";
        }
        else if (grade_num >= 60)
        {
            grade_letter = "D";
        }
        else
        {
            grade_letter = "F";
        }
        Console.WriteLine($"Your grade is {grade_letter}");

        if (grade_num >= 70){
            Console.WriteLine($"Congrats, you passed with a {grade_num}%!");
        }
        else{
            Console.WriteLine($"I believe in you! Together you can pass this!");
        }
    }
}