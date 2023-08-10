using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //Creating list of integers
        List<int> intList = new List<int>() { 5, 99, 23, 10, 185, 22, 12, 2994, 101, 77000 };
        //Asks the user for input and loops through list dividing each  number by the input
        bool numValid = false;
        while (!numValid)
        {
            //Using try/catch block to show error message
            try
            {
                Console.WriteLine("\nEnter a number to divide the list by: ");
                float numDivide = float.Parse(Console.ReadLine());
                //if statement to check if user entered 0
                if (numDivide == 0)
                {
                    Console.WriteLine("Please enter a number other than 0.");
                }
                //Divides each number in list by input
                else
                {
                    foreach (int num in intList)
                    {
                        float Divide = num / numDivide;
                        Console.WriteLine(num + "/" + numDivide + " = " + Divide);
                    }
                    numValid = true;
                }
            }
            //Catch block to display error message for string input
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
        //Message to let the user know the program has exited the try/catch block
        Console.WriteLine("The program has exited the try/catch block.");
        Console.ReadLine();
    }
}
