// can we create a object of class having Private Constructor. Show it with the help of program how we can access the fields & that class.

using System;

class MyClass
{
    private MyClass()
    {
        Console.WriteLine("Private constructor called.");
    }

    public static MyClass CreateInstance()
    {
        return new MyClass();
    }

    public string Name { get; set; }

    public void DisplayMessage()
    {
        Console.WriteLine($"Hello, {Name}!");
    }
}
class Program
{
    static void Main()
    {
        MyClass myObject = MyClass.CreateInstance();

        myObject.Name = "John";
        myObject.DisplayMessage();  
    }
}




