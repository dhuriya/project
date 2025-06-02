using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.AnonymousMethods
{
    public class Anonymous
    {
        public delegate string GreetingsDelegate(string name);

        public static string Greetings(string name)
        {
            return "Hello " + name + " Welcome to Donet Tutorial.";
        }
    }
}
