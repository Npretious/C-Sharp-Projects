using System;


namespace TryCatchAssignment
{
    //This age calculator class calculates the birth year of user based on age.
    class Program
    {
        static void Main(string[] args)
        {
            //asks user to enter age
            Console.WriteLine("Please enter your age: ");
            try
            {
                //Converts users input to an integer
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    //If age entered is zero or negative, displays error messgae
                    Console.WriteLine("Error: Age must be a positive number.");
                }
                else
                {
                    //Gets the current year
                    int currentYear = DateTime.Now.Year;
                    //Calculates birth year by subtracting age from current year
                    int birthYear = currentYear - age;
                    //Displays birth year to user
                    Console.WriteLine("You were born in the year {0}.", birthYear);
                }
            }
            catch (FormatException)
            {
                //If input is not an integer, displays error message
                Console.WriteLine("Error: Invalid input. Please enter a valid number.");
            }
            catch (Exception)
            {
                //If any other exception occurs, displays general error message
                Console.WriteLine("An error occurred. Please try again.");
            }
        }
    }
}
