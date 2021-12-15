using System;

namespace T03ExtractFileVer2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int indexOfFileName = input.LastIndexOf(@"\") + 1;
            int indexOfExtension = input.IndexOf(".") + 1;
            string fileName = input.Substring(indexOfFileName, indexOfExtension-1 - indexOfFileName);
            string extension = input.Substring(indexOfExtension);
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
