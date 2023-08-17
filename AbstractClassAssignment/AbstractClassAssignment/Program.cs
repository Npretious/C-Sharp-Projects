//Program.cs
using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Employee object in main method
            Employee sam = new Employee() { firstName = "Sample", lastName = "Student" };
            //Calls the SayName method for the object
            sam.SayName();
            Console.ReadLine();
        }
    }
}
