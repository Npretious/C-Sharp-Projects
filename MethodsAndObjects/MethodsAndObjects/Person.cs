using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsAndObjects
{
    //Create class called person
    public class Person
    {
        //Adding two properties(firstname and lastname
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Give class void method called SayName() which takes no parameters
        public void SayName()
        {
            //Displays persons full name in console
            Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);
        }

        public void Quit()
        {
            Console.WriteLine("I quit!");
        }
    }
}
