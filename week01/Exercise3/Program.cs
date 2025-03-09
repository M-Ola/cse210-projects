using System;
// Author: Monsuru Oladipo. CSE 210
// Exercise 3 Core requirement

class Program
{
    static void Main(string[] args)
    {


        //Console.Write("What is your magic number? ");

        // Console.Write("What is your guess  number? ");

        Random random = new();
        int magicNumber = random.Next(1, 101);


        int guess = -1;
       
       
       
       // Console.Write("What is your magic number? ");
      //  magicNumber = int.Parse(Console.ReadLine());

        while (guess != magicNumber)
        {


            Console.Write("What is your guess number? ");
            guess = int.Parse(Console.ReadLine());


            if (guess > magicNumber)
            {

                Console.WriteLine("Lower");

            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");

            }
            else
            {
                Console.WriteLine("You guesed it!");
            }



        }


        
    }
}