using System;
// Author: Monsuru Oladipo. CSE 210
// Exercise 4 Core requirement

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise4 Project.");



        List<int> numbers = [];



        int number = -1;

        while (number != 0)
        {

            Console.Write("Enter number: Type 0 when done ");
            number = int.Parse(Console.ReadLine());




            if (number != 0)
            {

                numbers.Add(number);


            }

        }



        int sum = 0;
        int average = 0;
        int largest = 0;

        foreach (int num in numbers)
        {
            sum += num;

            average = sum / numbers.Count;
            if (num > largest)
            {
                largest = num;

            }


        }



        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The Average is: {average}");
        Console.WriteLine($"The Largest numbrer is: {largest}");







    }
}