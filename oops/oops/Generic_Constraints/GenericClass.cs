using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.Generic_Constraints
{
    //public class GenericClass<T> where T : class
    //{
    //    public T Message;
    //    public void GenericMethod(T Param1, T Param2)
    //    {
    //        Console.WriteLine("Message : "+Message+"");
    //        Console.WriteLine("Param1 : " + Param1 + "");
    //        Console.WriteLine("Param2 : " + Param2 + "");
    //    }
    //}
    //public class GenericClass<T> where T : struct
    //{
    //    public T Message;
    //    public void GenericMethod(T Param1, T Param2)
    //    {
    //        Console.WriteLine("Message : " + Message + "");
    //        Console.WriteLine("Param1 : " + Param1 + "");
    //        Console.WriteLine("Param2 : " + Param2 + "");
    //    }
    //}
    public class GenericClass<T> where T : new()
    {
        public T Message;
        public void GenericMethod(T Param1, T Param2)
        {
            Console.WriteLine("Message : " + Message + "");
            Console.WriteLine("Param1 : " + Param1 + "");
            Console.WriteLine("Param2 : " + Param2 + "");
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }
    public class Customer
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public Customer(string customerName, string customerLocation)
        {
            Name = customerName;
            Location = customerLocation;
        }
    }
}
