using System;
using System.Collections.Generic;
using System.Text;

namespace MethodAssignment
{
    class MethodClass1
    {
        //Creates a method that takes two integers as parameters
        public int MathOperation(int i, int j = 1)
        {
            int result = i * j;
            return result;
        }
    }
}
