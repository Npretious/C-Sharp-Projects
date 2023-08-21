//Program.cs
using System;

namespace ParsingEnumAssignment
{
    class Program
    {
        //Creating enum for days of the week.
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            //Asks user to enter current of the week
            Console.WriteLine("Enter the current day of the week: ");
            string input = Console.ReadLine();
            DayOfWeek day;

            try
            {
                //Assigns value to a variable of the enum data type just created
                day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input, true);
                Console.WriteLine("The current day of the week is: " + day);
            }
            catch (ArgumentException)
            {
                //Asks user to enter an actual day of the week if they entered something other than a day of the week
                Console.WriteLine("Please enter an actual day of the week. ");
            }
            Console.WriteLine("Have an amazing day");
            //Prevents program from closing
            Console.ReadLine();
        }
    }
}
