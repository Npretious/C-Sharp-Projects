//Program.cs
using System;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print current date and time to console
            Console.WriteLine("Current date and time: " + DateTime.Now);
            //Asks user to enter a number of hours
            Console.WriteLine("Enter a number of hours: ");
            //Calculates the time it will be in X hours
            int hours = Convert.ToInt32(Console.ReadLine());
            //Print future time to console
            DateTime futureTime = DateTime.Now.AddHours(hours);
            Console.WriteLine("In " + hours + " hours, it will be: " + futureTime);
        }
    }
}
