//Employee.cs
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    //Creates another class called Employee and it inherits from the Person class
    public class Employee : Person
    {
        public int Id { get; set; }
        //Implements SayName() method inside employee class
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
