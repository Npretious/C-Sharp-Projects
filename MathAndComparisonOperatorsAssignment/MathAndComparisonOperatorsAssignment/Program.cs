using System;

namespace MathAndComparisonOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program"); //Displays title in the console

            Console.WriteLine("Person 1"); //Displays person 1 in the console
            Console.WriteLine("Hourly Rate?"); //Displays hourly rate question in the console
            string hourlyRate1 = Console.ReadLine(); //storing hourlyRate variable and keeping program from closing between questions
            Console.WriteLine("How many hours do you work per week?"); //Displays hours worked per week question in the console
            string hours1 = Console.ReadLine(); //storing hours1 varirable and keeping program from closing
            int salary1 = Convert.ToInt32(hourlyRate1) * Convert.ToInt32(hours1) * 52; //concatenating and solving the variables salary1, hourlyRate1, and hours1

            Console.WriteLine("Person 2");
            Console.WriteLine("Whats your hourly rate?");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("How many hours do you work per week?");
            string hours2 = Console.ReadLine();
            int salary2 = Convert.ToInt32(hourlyRate2) * Convert.ToInt32(hours2) * 52;

            Console.WriteLine("Yearly salary of Person 1:"); //displaying yearly salary statement of person 1 in the console
            Console.WriteLine(salary1); //displays person 1's salary in the console.
            Console.WriteLine("Yearly salary of Person 2:");
            Console.WriteLine(salary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");

            bool isMore = salary1 > salary2; //boolean true or false statement for comparisons of wage
            Console.WriteLine(isMore); //displays boolean statement
            Console.ReadLine();
        }
    }
}
