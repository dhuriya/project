using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.Constructorcls
{
   public class Constructor
    {
       public int Id, Age;
       public string Address, Name;
       public bool IsPermanent;
       static int j;
       // public,private,protected
       // User Defined Default Constructor
       private int price { get; set; }
        public Constructor()
        {
            //Console.WriteLine("Explicit Constructor is called !");
            Id = 100;
            Age = 25;
            Address = "Delhi";
            Name = "Deepu";
            IsPermanent = true;
        }
       // parameterized constructor
        public Constructor(int i)
        {
            Console.WriteLine("Parameteried constructor is called : " + i);
            this.price = 20;
            Console.WriteLine("price : " + price);
        }

        public void Display()
        {
            Console.WriteLine("Employee Id is : " + Id);
            Console.WriteLine("Employee Age is : " + Age);
            Console.WriteLine("Employee Address is : " + Address);
            Console.WriteLine("Employee Name is : " + Name);
            Console.WriteLine("Is Employee Permanent : " + IsPermanent);
        }

       //--------------------
       // Static Constructor
       //--------------------
        //static Constructor()
        //{
        //    j = 100;
        //    Console.WriteLine("static construtor value : " + j);
        //}
       //-----------------
       // Private constructor
       //--------------------
        //private Constructor()
        //{
        //    Console.WriteLine("this is private constructor");
        //}
    }
}
