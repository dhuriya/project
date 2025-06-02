using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.Inheritance
{
    public class MultipleInheritance
    {
        public void GetPhoneModel()
        {
            Console.WriteLine("Redmi Nort 5 pro");
        }
    }
    public class Camera
    {
        public void GetCameraDetails()
        {
            Console.WriteLine("24 Mega Pixel Camera");
        }
    }
    public class SmartPhone : MultipleInheritance, Camera
    {
        public void GetDetails()
        {
            Console.WriteLine("Its a Redmi Smart Phone");
        }
    }
}
