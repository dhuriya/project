using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.Constructorcls
{
    public class StaticConstsructor
    {
        static StaticConstsructor()
        {
            Console.WriteLine("This is a static constructor");
        }
        public StaticConstsructor()
        {
            Console.WriteLine("This is a non static constructor");
        }
    }
}
