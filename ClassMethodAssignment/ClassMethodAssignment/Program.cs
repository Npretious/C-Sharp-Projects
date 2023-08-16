using System;

namespace ClassMethodAssignment
{
    //Defines new class
    public class Program
    {
        //Defines main method
        public static void Main()
        {
            //Instantating MethodClass1
            MethodClass1 myObject = new MethodClass1();
            //Calls on method on myObject instance, which passes both 1 and 2 as arguments
            myObject.Method(1, 2);
            //Calls on method again but specifies the arguments by name instead
            myObject.Method(x: 3, y: 4);
            //Prevents program from closing
            Console.ReadLine();
        }
    }
}
