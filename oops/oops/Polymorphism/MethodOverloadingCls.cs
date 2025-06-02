using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.Polymorphism
{
    class MethodOverloadingCls
    {
        public void Method()
        {
            Console.WriteLine("1st Method");
        }
        public void Method(int i)
        {
            Console.WriteLine("2nd Method");
        }
        public void Method(string s)
        {
            Console.WriteLine("3rd Method");
        }
        public void Method(int i,string s)
        {
            Console.WriteLine("4th Method");
        }
        public void Method(string s,int i)
        {
            Console.WriteLine("5th Method");
        }
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(float x, float y)
        {
            Console.WriteLine(x + y);
        }
        public void Add(string s1, string s2)
        {
            Console.WriteLine(s1 + " " + s2);
        }

        //----------------------
        // Constructor overloading
        //--------------------------
        int x, y, z;
        public MethodOverloadingCls(int x)
        {
            Console.WriteLine("Constructor1 Called");
            this.x = 10;
        }
        public MethodOverloadingCls(int x, int y)
        {
            Console.WriteLine("Constructor2 Called");
            this.x = x;
            this.y = y;
        }
        public MethodOverloadingCls(int x, int y, int z)
        {
            Console.WriteLine("Constructor3 Called");
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void Display()
        {
            Console.WriteLine("X= "+x+", Y= "+y+", Z= "+z+"");
        }
    }
}
