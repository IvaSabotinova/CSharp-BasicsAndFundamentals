using System;

namespace T05Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int daysAvailable = int.Parse(Console.ReadLine());
            int numberOfWorkersForAOHWork = int.Parse(Console.ReadLine());

            double hoursAvailableForProjectInOfficeHours = daysAvailable * 8 * 0.9;
            int hoursAOH = numberOfWorkersForAOHWork * 2 * daysAvailable;
            double totalHoursAvailableForProject = Math.Floor(hoursAvailableForProjectInOfficeHours + hoursAOH);

            if (hoursNeeded <= totalHoursAvailableForProject)
            {
                double hoursLeft = totalHoursAvailableForProject - hoursNeeded;

                Console.WriteLine($"Yes!{hoursLeft} hours left.");
            }
            else
            {
                double hoursShort = hoursNeeded - totalHoursAvailableForProject;
                Console.WriteLine($"Not enough time!{hoursShort} hours needed.");
            }
        }
    }
}
