using System;

namespace ReadWriteProperties
{
    class Student
    {
        private string studentName;
        public string StudentName
        {
            get
            {
                return studentName; 
            }
            set
            {
                studentName = value; 
            }
        }
        public int Age { get; }
        public Student(int age)
        {
            Age = age; 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(20);
            student.StudentName = "John Doe";

            Console.WriteLine("Student Name: " + student.StudentName);
            Console.WriteLine("Student Age: " + student.Age);
        }
    }
}
