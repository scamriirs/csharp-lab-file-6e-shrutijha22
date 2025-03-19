using System;

class AttendanceCalculator
{
    static void Main()
    {
        Console.Write("Enter the number of lectures held per week: ");
        int totalLectures = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of lectures attended by the student: ");
        int attendedLectures = int.Parse(Console.ReadLine());
        Console.Write("Enter the required attendance percentage: ");
        double requiredPercentage = double.Parse(Console.ReadLine());
        double currentPercentage = ((double)attendedLectures / totalLectures) * 100;

        Console.WriteLine("\nCurrent Attendance Percentage: {currentPercentage:F2}%");

        if (currentPercentage >= requiredPercentage)
        {
            Console.WriteLine("You already meet the required attendance percentage.");
        }
        else
        {
            int requiredLectures = (int)Math.Ceiling((requiredPercentage / 100) * totalLectures);

            int lecturesToAttend = requiredLectures - attendedLectures;
            Console.WriteLine($"You need to attend {lecturesToAttend} more lecture(s) to meet the required attendance.");
        }
    }
}


