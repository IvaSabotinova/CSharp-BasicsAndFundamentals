using System;

namespace T07ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            const int hoursPerProject = 3;
            int neededHours = numberOfProjects * hoursPerProject;

            Console.WriteLine($"The architect {name} will need {neededHours} hours to complete {numberOfProjects} project/s.");
        }
    }
}
