// Create a program to Show the usage of static constructor.
using System;

public class Example
{
    static Example()
    {
        Console.WriteLine("static Constructor");
    }

    public Example()
    {
        Console.WriteLine("No - static Constructor");
    }

    public static void Main()
    {
        Example e1 = new Example(); 
        Example e2 = new Example(); 
    }
}
