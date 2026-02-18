using System;

namespace StreamWriterExample
{
    class Program
    {
        /// <summary>
        /// Creates a file of inputted student name and ID
        /// </summary>
        /// <param name="StudentName">The unique name of a student.</param>
        /// <param name="StudentID">The unique ID of a student.</param>
        /// <param name="path">The unique name for the file to be created.</param>
        /// <param name="data">The unique identifier to test file for existing content or finds the file if exists.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Input Name of Student:");
            string StudentName = Console.ReadLine();

            Console.WriteLine("Input ID Number:");
            string StudentID = Console.ReadLine();

            string path = "StreamWriterExample.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine($"Student Name: {StudentName}");
                writer.WriteLine($"Student ID: {StudentID}");
            }

            try
            {
                string data = File.ReadAllText(path);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: File not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.ToString()}");
            }
            finally
            {
                Console.WriteLine("I/O attempt complete");
            }
        }
    }
}
