using System;

namespace PackageExpressAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow instructions below."); //Displays title
            Console.WriteLine("Please enter package weight:");
            string input = Console.ReadLine(); //assigning input variable as string
            int packageWeight = int.Parse(input); //assigning packageWeight variable as int and ensuring user input is accounted for
            if (packageWeight > 50) //if statement, if package weighs more than 50, error message appears
            {
                Console.WriteLine("Package is too heavy for shipping with Package Express. We apologize for the inconvience"); //displays message on console.
            }
            Console.ReadLine(); //stops program from closing

            Console.WriteLine("Please enter package width:");
            string inputWidth = Console.ReadLine(); //assigning inputWidth as string variable
            int packageWidth = int.Parse(inputWidth); //assigning packageWidth as int variable and parsing inputWidth
            Console.WriteLine("Please enter package height:");
            string inputHeight = Console.ReadLine();
            int packageHeight = int.Parse(inputHeight);
            Console.WriteLine("Please enter package length:");
            string inputLength = Console.ReadLine();
            int packageLength = int.Parse(inputLength);

            if (packageWidth > 8 && packageHeight > 3 && packageLength > 2) //if statement checking if the package is to large to be shipping
            {
                Console.WriteLine("Package too big to be shipped via Package Express. We apologize for the inconvience"); // if item is too large this message is displayed
            }
            else
            {
                decimal shippingCost = (packageWidth + packageHeight + packageLength) * packageWeight / 100m; // else statement occurs if item is less than 50 
                Console.WriteLine("Your estimated total for shipping the package is: ${0}", shippingCost); //displays total cost of shipping on console
                Console.WriteLine("Thank you!");
            }
        }
    }
}
