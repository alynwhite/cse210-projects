using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number_input;
        int sum_nums = 0;
        int largest_num;
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        string string_number;
        do
        {
            Console.WriteLine("Enter number: ");
            string_number = Console.ReadLine();
            number_input = int.Parse(string_number);
            if (number_input != 0)
            {
                numbers.Add(number_input);
            }

        } while (number_input != 0);
        largest_num = numbers[0];
        for (int i = 0; i < numbers.Count; i++)
        {
            sum_nums += numbers[i];
            if (numbers[i] > largest_num)
            {
                largest_num = numbers[i];
            }
        }
        float avg_num = ((float)sum_nums) / numbers.Count;

        Console.WriteLine($"Sum: {sum_nums}\nAverage Num: {avg_num} \nLargest: {largest_num}");
    }
}