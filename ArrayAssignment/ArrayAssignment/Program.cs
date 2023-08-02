using System;
using System.Collections.Generic;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array with strings 
            string[] colorArray = { "Black", "White", "Red", "Orange", "Yellow", "Blue", "Green", "Purple", "Pink", "Brown" };
            //Asks the user to choose a number to display the string in that location
            Console.WriteLine("Please choose a number between 0 and 9:");
            int stringSelect = Convert.ToInt32(Console.ReadLine());
            bool validString = false;

            while (!validString)
            {
                try
                {
                    Console.WriteLine("Your favourite colour is " + colorArray[stringSelect]);
                    validString = true;
                }
                //Adds a message to display if the user picks an index that isn't between 0 and 9.
                catch
                {
                    Console.WriteLine("Unfortunately, the number you chose is invalid. Please select a number between 0 and 9. ");
                    stringSelect = Convert.ToInt32(Console.ReadLine());
                }
            }

            // List of strings
            List<string> occupationList = new List<string>()
            {
                "Firefighter",
                "Cop",
                "Software Developer",
                "Operator",
                "Labourer",
                "Athlete",
                "Framer",
                "Roofer",
                "Farmer",
                "Contractor"
            };

            //Ask the user for a number to display the string at the index selected.
            Console.WriteLine("\nPlease choose another number between 0 and 9:");
            int listSelect = Convert.ToInt32(Console.ReadLine());
            bool validList = false;

            while (!validList)
            {
                try
                {
                    Console.WriteLine("Your new occupation is: " + occupationList[listSelect]);
                    validList = true;
                }
                //Adds a message to display if the user picks an index that isn't between 0 and 9.
                catch
                {
                    Console.WriteLine("Unfortunately, that number is invalid. Please select a number between 0 and 9. ");
                    listSelect = Convert.ToInt32(Console.ReadLine());
                }
            }
            //Array of integers
            int[] intArray = { 54, 32, 1, 53, 65, 76, 12, 43, 67, 83 };
            //Asks the user for a number to display the string at the index selected.
            Console.WriteLine("\nSelect another number between 0 and 9:");
            int intSelect = Convert.ToInt32(Console.ReadLine());
            bool validInt = false;

            while (!validInt)
            {
                try
                {
                    Console.WriteLine("Your lucky number is " + intArray[intSelect]);
                    validInt = true;
                }
                ////Adds a message to display if the user picks an index that isn't between 0 and 9.
                catch
                {
                    Console.WriteLine("Sadly, your number selection is invalid. Please select a number between 0 and 9.");
                    intSelect = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
