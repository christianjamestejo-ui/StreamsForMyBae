using System;

namespace StreamWriterExample
{
    class Program
    {
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
