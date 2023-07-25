using System;
using System.IO;

namespace StudentDataConsoleApp
{
    class Program
    {
        private const string Value = "ID\tFirstName \t LastName \t Grade";

        static void Main(string[] args)
        {
            try
            {
                // Specify the file path where the student data is stored
                string filePath = "students.txt";

                // Read all lines from the text file
                string[] lines = File.ReadAllLines(filePath);

                // Display the data on the console
                Console.WriteLine("Student Data:");

                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    string studentID = data[0];
                    string firstName = data[1];
                    string lastName = data[2];
                    string grade = data[3];

                    Console.WriteLine($"{studentID}\t{firstName}\t{lastName}\t{grade}");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: File not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
