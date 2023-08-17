using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsAndObjects
{
    //Creating a class called employee and have it inherit from Persons class
    public class Employee : Person
    {
        //Give the Employee class a property called Id, in data type int
        public int Id { get; set; }
    }
}
