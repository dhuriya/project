using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.Inheritance
{
    public class SingleInheritance
    {
        public int length;
        public int breadth;
        public int Area()
        {
            return length * breadth;
        }
        public int Perimeter()
        {
            return 2 * (length + breadth);
        }
    }
    public class Cuboid : SingleInheritance
    {
        public int height;
        public Cuboid(int l, int b, int h)
        {
            length = l;
            breadth = b;
            height = h;
        }
        public int Volume()
        {
            return length * breadth * height;
        }
    }
}
