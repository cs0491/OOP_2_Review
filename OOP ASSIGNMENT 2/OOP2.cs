using System;
using System.IO;

namespace OOP_ASSIGNMENT_2
{
    class Program
    {
        //contains the following methods
        static void Main(string[] args)
        {
            welcome();

            CompareFile();

            Console.ReadKey();
        }

        //welcomes user to the file comparer
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
            //reads files and compares them
            bool diff = CompareFiles.file_diff(@"File_a.txt", @"File_b.txt");

            //if the files are the equal it will write the following message
            if (diff == true)
            {
                Console.WriteLine("File_a and File_b are the same");
            }

            //otherwise it writes the following if false
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
