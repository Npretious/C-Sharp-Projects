using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAssignment
{
    //Creates employee class
    public class Employee
    {
        //Adds ids for employee class and first name and last name
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Overloads the == operator to compare two employees by their id property
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.Id == emp2.Id;
        }
        //Overloads the != operator to compare two employees by their id property
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }
    }
}
