//Person.cs
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    //Creates abstract class "Person" with two string properties of firstName and lastName
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        //Adds method SayName()
        public abstract void SayName();
    }
}
