using System;

namespace MethodClassAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //displays instructions for user
            Console.WriteLine("Click enter to input two numbers for multiplication!");
            Console.ReadLine();
            //Instantiating the class
            Class1 mathOp = new Class1();
            //Asks user to enter first number
            Console.WriteLine("Enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            //Asks user to enter second number
            Console.WriteLine("Enter another number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            //Calling on method class
            int results = mathOp.MathOperation(num1, num2);
            //displaying results on console
            Console.WriteLine(num1 + " x " + num2 + " = " + results);
        }
    }
}
