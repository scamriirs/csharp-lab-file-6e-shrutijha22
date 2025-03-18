using System;

class Person
{
    // Parameterless constructor
    public Person()
    {
        Name = "Shruti";
        Age = 0;
    }

    // Parameterized constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // parameterless constructor
        Person person1 = new Person();
        person1.DisplayInfo();

        // parameterized constructor
        Person person2 = new Person("John", 30);
        person2.DisplayInfo();
    }
}
Output
Name: Shruti, Age: 0
Name: John, Age: 30

