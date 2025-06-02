using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.Polymorphism
{
    class CompileTimePolymorphism
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public void Add(float a, float b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(string a, string b)
        {
            Console.WriteLine(a +" "+ b);
        }
    }
}
