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
            //Stops program from closing
            Console.ReadLine();
            //creating instance of employee class and assigning variable type IQuittable to it.
            IQuittable quittable = new Employee();
            quittable.Quit();
        }
    }
}
