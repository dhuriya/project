using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.Constructorcls
{
    public class UserDefineDefault
    {
        public int id, age;
        public string address, name;
        public bool isPermanent;

        public UserDefineDefault()
        {
            id = 100;
            age = 30;
            address = "delhi";
            name = "deepu";
            isPermanent = true;
        }
        public void Display()
        {
            Console.WriteLine(id);
            Console.WriteLine(age);
            Console.WriteLine(address);
            Console.WriteLine(name);
            Console.WriteLine(isPermanent);
        }

    }
}
