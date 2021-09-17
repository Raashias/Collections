using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Circle : ShapeN
    {
        int radius = 10;
        public double Area()
        {
            double A = 3.412 * radius * radius;
            return A;
        }

        public double volume() { 
            return 0;
            }
    }
}
