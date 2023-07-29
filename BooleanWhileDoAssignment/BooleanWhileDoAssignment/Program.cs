using System;

namespace BooleanWhileDoAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Below is a do while loop
            int count = 0;
            do
            {
                Console.WriteLine("Inside the loop");
                count++;
            }
            while (count < 8); //loops until program reaches 8

            //Below is a while loop
            Console.WriteLine("Press enter to show while loop");
            Console.ReadLine();

            int counting = 0;
            while (counting < 10) //loops until program counts reaches 10
            {
                Console.WriteLine("Ten at a time!");
                counting++;
            }
        }
    }
}
