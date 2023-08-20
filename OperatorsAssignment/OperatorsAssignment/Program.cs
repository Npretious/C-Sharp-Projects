using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate two objects of Employee class and assigns values to properties
            Employee employee1 = new Employee();
            employee1.Id = 1;
            employee1.FirstName = "Nick";
            employee1.LastName = "Pretious";

            Employee employee2 = new Employee();
            employee2.Id = 2;
            employee2.FirstName = "Carole";
            employee2.LastName = "Sullivan";

            //Compares the two employees using the overloaded == operator.
            if (employee1 == employee2)
            {
                Console.WriteLine("The two employee Id's are identical.");
            }
            else
                Console.WriteLine("The two employee Id's are unique.");
        }
    }
}
