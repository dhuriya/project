using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.Constructorcls
{
    public class CopyConstructor
    {
        int x;
        public CopyConstructor(int i)
        {
            x = i;
        }

        public void Display()
        {
            Console.WriteLine("Value is = "+x);
        }
        //this is copy constructor
        public CopyConstructor(CopyConstructor obj)
        {
            x = obj.x;
        }
        
    }
}
