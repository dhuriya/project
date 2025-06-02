using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops
{
    class GenericClass<T>
    {
        public T Message;
       
        public void GenericMethod(T Name, T Location)
        {
            Console.WriteLine("Message : "+Message+"");
            Console.WriteLine("Name : "+Name+"");
            Console.WriteLine("Location : " + Location + "");
        }

        // Generic Method
        public void GenericMethod<T1, T2>(T1 Param1, T2 Param2)
        {
            Console.WriteLine("Parameter T1 Type : "+typeof(T1)+" Parameter T2 type : "+typeof(T2)+"");
            Console.WriteLine("Paramter 1 : "+Param1+" Parameter 2 : "+Param2+"");
        }
    }

}
