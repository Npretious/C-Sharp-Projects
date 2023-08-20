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

        //Adding void method Quit()
        public void Quit()
        {
            //Displaying I quit to the console
            Console.WriteLine("I quit!");
        }
    }
}
