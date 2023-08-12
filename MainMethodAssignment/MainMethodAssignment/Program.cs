using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating the MathMethods2 Class
            MathMethods2 math1 = new MathMethods2();
            //Calls the first method with int parameter
            Console.WriteLine(math1.MathOp(5));
            //Calls the second method with string paramter
            Console.WriteLine(math1.MathOp("5"));
            //Calls the third method with decimal parameter
            Console.WriteLine(math1.MathOp(5.1m));
        }
    }
}
