using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating class
            MethodClass1 mathOp = new MethodClass1();
            //Displaying user instructions for coming steps
            Console.WriteLine("In the next few steps, enter your two favorite numbers!(if possible)");
            //Stops program from closing
            Console.ReadLine();
            //Asking user for first number
            Console.WriteLine("Please enter your first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            //Asking user for second optional number
            Console.WriteLine("Please note: This next number is optional, if you have one enter your second numberPlease enter your second favorite number:");
            try
            {
                //Calls method with 2 parameters if both provided
                int num2 = Convert.ToInt32(Console.ReadLine());
                int results = mathOp.MathOperation(num1, num2);
                Console.WriteLine(num1 + " x " + num2 + " = " + results);
            }
            catch
            {
                //Calls method with one parameter if only one provided
                int results = mathOp.MathOperation(num1);
                Console.WriteLine(num1 + " x Default 1 = " + results);
            }
            Console.ReadLine();
        }
    }
}
