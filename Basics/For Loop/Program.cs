using System;

namespace T02Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int numberOfDoctors = 7;
            int numberOfTreatedPatients = 0;
            int numberOfUntreatedPatients = 0;



            for (int i = 1; i <= numberOfDays; i++)
            {

                if (i % 3 == 0 && numberOfUntreatedPatients > numberOfTreatedPatients)
                {
                    numberOfDoctors++;
                }
                int numberOfIncomingPatientsForTheDay = int.Parse(Console.ReadLine());

                if (numberOfIncomingPatientsForTheDay <= numberOfDoctors)
                {
                    numberOfTreatedPatients += numberOfIncomingPatientsForTheDay;

                }
                else if (numberOfIncomingPatientsForTheDay > numberOfDoctors)
                {
                    numberOfTreatedPatients += numberOfDoctors;
                    numberOfUntreatedPatients += (numberOfIncomingPatientsForTheDay - numberOfDoctors);

                }

            }
            Console.WriteLine($"Treated patients: {numberOfTreatedPatients}.");
            Console.WriteLine($"Untreated patients: {numberOfUntreatedPatients}.");



        }
    }
}
