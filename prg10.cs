using System;
class Person
{
    public string Name;

    public void DisplayPersonInfo()
    {
        Console.WriteLine("Name: " + Name);
    }
}
class Employee : Person
{
    public string EmployeeID;

    public void DisplayEmployeeInfo()
    {
        DisplayPersonInfo(); 
        Console.WriteLine("Employee ID: " + EmployeeID);
    }
}

class Programmer : Employee
{
    public string ProgrammingLanguage;

    public void DisplayProgrammerInfo()
    {
        DisplayEmployeeInfo(); 
        Console.WriteLine("Programming Language: " + ProgrammingLanguage);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Programmer programmer = new Programmer();
        programmer.Name = "Alice";
        programmer.EmployeeID = "E123";
        programmer.ProgrammingLanguage = "C#";

        programmer.DisplayProgrammerInfo(); 
    }
}
