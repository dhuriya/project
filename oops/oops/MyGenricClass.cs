using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops
{
    class MyGenricClass<T>
    {
        //Genric variable
        //The data type is generic T
        private T GenericMemberVariable;
        //Generic Constructor
        //Constructor accepts one parameter of Generic type T
        public MyGenricClass(T Value)
        {
            GenericMemberVariable = Value;
        }
        //Generic Method
        //Method accepts one Generic type parameter T 
        //Method return type also Generic T

        public T GenericMethod(T GenericParameter)
        {
            Console.WriteLine("Parameter type : "+typeof(T).ToString()+",Value : "+GenericParameter+"");
            Console.WriteLine("Return type : "+typeof(T).ToString()+",Value : "+GenericMemberVariable+"");
            return GenericMemberVariable;
        }
        //Generic Property
        //The data type is generic T
        public T GenericProperty { get; set; }
    }
}
