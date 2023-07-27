using System;

namespace CarInsuranceApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Application"); //Displays title
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? (True or False)"); //Displays true or false dui question
            string answer = Console.ReadLine().ToLower();
            bool dui = answer == "true"; //boolean statement
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified for insurance?");
            bool qualified = (age > 15) && !dui && (tickets <= 3); //boolean statement if age is greater than 15 with no dui's and less than 3 tickets
            Console.WriteLine(qualified); //if the above boolean statement is true, your qualifed
            Console.ReadLine();
        }
    }
}
