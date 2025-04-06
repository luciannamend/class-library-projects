using System;
using ShowCase;

namespace NugetPacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to NugetPacks!");
            Console.WriteLine();

            ShowCase.Program.Main(args); // Call the Main method from ShowCase   
        }
    }
}