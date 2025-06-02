using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.Interface
{
    class ImplementationClass2 : ITestInterface2
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine("Sum of num1 and num2 is " + (num1 + num2) + "");
        }

        public void Sub(int num1, int num2)
        {
            Console.WriteLine("Division of num1 and num2 is " + (num1 - num2) + "");
        }
    }
}
