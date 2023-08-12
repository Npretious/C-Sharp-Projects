using System;


namespace MainMethodAssignment
{
        public class MathMethods2
        {
            //First method - takes an integer
            public int MathOp(int number)
            {
                return number + 10;
            }
            //Second method - takes a string
            public int MathOp(string number)
            {
                //Converts string to an integer to perform equation
                int newnum = Convert.ToInt32(number);
                return newnum % 5;
            }
            //Third method - takes a decimal
            public int MathOp(decimal number)
            {
                //Converts decimal to an integer to perform equation
                int newnum = Convert.ToInt32(number);
                return newnum * 15;
            }
        }
 
}

