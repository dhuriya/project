using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.Interface
{
    public class MultipleInheritanceTest : Interface1, Interface2
    {
        public void Test()
        {
            Console.WriteLine("Test Method is Implemented in Child Class");
        }
        //Explicit Interface Implementation
        void Interface1.Show()
        {
            Console.WriteLine("Interface1 Show Method is Implemented in child class");
        }
        //Explicit Interface Implementation
        void Interface2.Show()
        {
            Console.WriteLine("Interface2 Show Method is Implemented in child class");
        }
    }
}
