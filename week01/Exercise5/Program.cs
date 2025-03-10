using System;
using System.Globalization;
// Author: Monsuru Oladipo. CSE 210
// Exercise 5 Core requirement
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();

        string name = PromptUserName();

        PromptUserNumber();


        int square = SquareNumber(5);


        DisplayResult(name, square);


    }

    static void DisplayWelcome()
    {

        Console.WriteLine("Welcome to the program!");

    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        //Console.Write($"My name is {name}");



        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());

        return number;



    }

    static int SquareNumber(int number) {

        int square = number * number;

        return square;


    }

    static void DisplayResult(string name, int squreNumber)
    {

        Console.Write($"My name is {name}, the square of your number is {squreNumber} ");

    }






}