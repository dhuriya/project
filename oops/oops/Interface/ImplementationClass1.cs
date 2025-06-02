using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.Interface
{
    public class ImplementationClass1 //: ITestInterface1
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine("Sum of num1 and num2 is "+(num1 + num2)+"");
        }
    }
}
