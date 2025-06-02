using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.Polymorphism
{
    class MethodOverridingCls
    {
        // virtual function (overridable method)
        public virtual void Show()
        {
            Console.WriteLine("Parent Class..");
        }
    }
    class MethodOverridingCls2:MethodOverridingCls
    {
        // Overriding method
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Child Class Show Method..");
        }
    }
}
