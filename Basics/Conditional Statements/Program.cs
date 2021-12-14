using System;

namespace T10InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double volumeSales = double.Parse(Console.ReadLine());


            if (volumeSales >= 0 && volumeSales <= 500)


                switch (town)
                {
                    case "Sofia": Console.WriteLine($"{volumeSales * 0.05:f2}"); break;
                    case "Varna": Console.WriteLine($"{volumeSales * 0.045:f2}"); break;
                    case "Plovdiv":
                        Console.WriteLine($"{volumeSales * 0.055:f2}"); break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            else if (volumeSales > 500 && volumeSales <= 1000)
                switch (town)
                {
                    case "Sofia": Console.WriteLine($"{volumeSales * 0.07:f2}"); break;
                    case "Varna": Console.WriteLine($"{volumeSales * 0.075:f2}"); break;
                    case "Plovdiv":
                        Console.WriteLine($"{volumeSales * 0.08:f2}"); break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            else if (volumeSales > 1000 && volumeSales <= 10000)
                switch (town)
                {
                    case "Sofia": Console.WriteLine($"{volumeSales * 0.08:f2}"); break;
                    case "Varna": Console.WriteLine($"{volumeSales * 0.10:f2}"); break;
                    case "Plovdiv":
                        Console.WriteLine($"{volumeSales * 0.12:f2}"); break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            else
                switch (town)
                {
                    case "Sofia": Console.WriteLine($"{volumeSales * 0.12:f2}"); break;
                    case "Varna": Console.WriteLine($"{volumeSales * 0.13:f2}"); break;
                    case "Plovdiv":
                        Console.WriteLine($"{volumeSales * 0.145:f2}"); break;
                    default:
                        Console.WriteLine("error");
                        break;
                }



        }
    }
}
