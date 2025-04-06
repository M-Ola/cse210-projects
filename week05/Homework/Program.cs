
//Author: Monsuru Oladipo. cse 210


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment = new Assignment("Mike  Loyd", "Literature  in review");


        Console.WriteLine(assignment.GetSummary());


        MathAssignment mathAssignment = new MathAssignment("John keys", "Trigonometry", "Sec 2", "Explain Sine and Cosine");


        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeWorkList());
   
        WritingAssignment writingAssignment= new WritingAssignment("James Byron", "Eng 500", "Literature of the world");

        Console.WriteLine(writingAssignment.GetSummary());

        Console.WriteLine(writingAssignment.GetWritingInformation());
   
   
    }








}