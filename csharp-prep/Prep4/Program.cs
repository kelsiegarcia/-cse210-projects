using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;

        while (number != 0)
        {
            Console.WriteLine("Enter Number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;

        }

        Console.WriteLine($"The sum is {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        int highestNumber = -1;

        foreach (int n in numbers)
        {
            if (n > highestNumber)
            {
                highestNumber = n;
            }
        }
        Console.WriteLine($"The highest number is {highestNumber}");
    }
}