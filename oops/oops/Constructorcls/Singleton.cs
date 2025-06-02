using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.Constructorcls
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        private static readonly object Instancelock = new object();
        public static Singleton GetSingletonInstance()
        {
            lock (Instancelock)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        private Singleton()
        {
            counter++;
            Console.WriteLine("Singleton constructor Executed "+counter+"Time.");
        }
        public void SomeMethod(string Message)
        {
            Console.WriteLine("Some Method called "+Message +".");
        }
    }
}
