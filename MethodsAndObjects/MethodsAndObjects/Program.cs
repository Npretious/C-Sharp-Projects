using System;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inside of Main method, instantiate and intialize an employee object
            //Using first name "Sample" and last name "Student"
            Employee sam = new Employee() { FirstName = "Sample", LastName = "Student" };
            //Call the superclass method SayName() on the Employee object
            sam.SayName();
            Console.ReadLine();
            IQuittable quittable = new Employee();
            quittable.Quit();
        }
    }
}
