using System;
using System.Globalization;


//Author: Monsuru Oladipo. cse 210
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");


        Square square = new Square("Blue", 4.0);
        Rectangle rectangle = new Rectangle("Red", 5.0, 4.0);
        Circle circle = new Circle("Pink", 3.0);


        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());



        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());


        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        List<Shape> shapes = new();

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();

            Console.WriteLine($"{color}: {area}");





        }




    }













}