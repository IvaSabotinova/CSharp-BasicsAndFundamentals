using System;

namespace T04Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            int students1 = 0;
            int students2 = 0;
            int students3 = 0;
            int students4 = 0;
            double percentStudents1 = 0.00;
            double percentStudents2 = 0.00;
            double percentStudents3 = 0.00;
            double percentStudents4 = 0.00;
            double sumGrades = 0;


            for (int i = 1; i <= numberOfStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 5)
                {
                    students1++;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    students2++;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    students3++;
                }
                else if (grade >= 2 && grade <= 2.99)
                {
                    students4++;
                }
                sumGrades += grade;
            }
            percentStudents1 = 1.0 * students1 / numberOfStudents * 100;
            percentStudents2 = 1.0 * students2 / numberOfStudents * 100;
            percentStudents3 = 1.0 * students3 / numberOfStudents * 100;
            percentStudents4 = 1.0 * students4 / numberOfStudents * 100;
            Console.WriteLine($"Top students: {percentStudents1:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentStudents2:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentStudents3:f2}%");
            Console.WriteLine($"Fail: {percentStudents4:f2}%");
            Console.WriteLine($"Average: {sumGrades / numberOfStudents:f2}");
        }
    }
}
