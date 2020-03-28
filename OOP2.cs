using System;
using System.IO;

namespace OOP_ASSIGNMENT_2
{
    class Program
    {
        static void Main(string[] args)
        {
            welcome();

            CompareFile();

            Console.ReadKey();
        }

        private static void welcome()
        {
            Console.WriteLine("Welcome to the Git diff file comparer");
            Console.WriteLine();
            Console.WriteLine("Please press any key to continue...");
            Console.WriteLine();

            Console.ReadKey();
        }

        public static void CompareFile()
        {
            bool diff = CompareFiles.file_diff(@"File_a.txt", @"File_b.txt");

            if (diff == true)
            {
                Console.WriteLine("File_a and File_b are the same");
            }

            else
            {
                Console.WriteLine("File_a and File_b are different");
            }

            Console.WriteLine();
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadLine();
        }
        
    }
}
