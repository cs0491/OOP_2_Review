using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOP_ASSIGNMENT_2
{
    class CompareFiles
    {
        //uses file_diff to compare the different files
        public static bool file_diff(string Path1, string Path2)
        {
            byte[] File_a = File.ReadAllBytes(@"File_a.txt");
            byte[] File_b = File.ReadAllBytes(@"File_b.txt");

            if (File_a.Length == File_b.Length)
            {

                for (byte i = 0; i < File_a.Length; i++)
                {
                    if (File_a[i] != File_b[i])
                    {

                        return false;
                    }
                }

                return true;
            }

            return false;
        }
    }
}
