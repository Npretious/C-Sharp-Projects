using System;

namespace StructAssignment
{
    //Defines a struct called number
    struct Number
    {
        //Adds property called Amount of data type decimal
        public decimal Amount;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Creates a object of data type Number
            Number number = new Number();
            //Assigns a mount to object's Amount property
            number.Amount = 5.5m;
            //Displays amount to console
            Console.WriteLine(number.Amount);
        }
    }
}
