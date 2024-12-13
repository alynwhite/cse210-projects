using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");
       

        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");

        MathAssignment m1 = new MathAssignment("Section 7.3", "Problems 8-19", "Roberto Rodriquez", "Fractions");

        WritingAssignment w1 = new WritingAssignment("The Causes of World War II", "Mary Waters", "European History");

        Console.WriteLine(a1.GetSummary());
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());

    }
}