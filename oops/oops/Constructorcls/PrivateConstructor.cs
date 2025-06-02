using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.Constructorcls
{
    public class PrivateConstructor
    {
        private PrivateConstructor()
        {
            Console.WriteLine("This is private constructor");
        }
        public PrivateConstructor(int x)
        {
            Console.WriteLine("This is public constructor"+x);
        }

        public void Method1()
        {
            Console.WriteLine("Method is called...");
        }
    }
}
