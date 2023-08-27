using System;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks user to input a number
            Console.WriteLine("Please enter a number: ");
            string input = Console.ReadLine();
            //Converts input to integer
            int number;
            if (int.TryParse(input, out number))
            {
                //Logs number to a text file
                string filePath = "C:\\Users\\Nickp\\logs\\log.txt";
                File.WriteAllText(@"C:\Users\Nickp\Logs\log.txt", number.ToString());

                //Print contents of text file back to the user
                string fileContents = File.ReadAllText(@"C:\Users\Nickp\Logs\log.txt");
                Console.WriteLine("The contents of text file are: " + fileContents);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
