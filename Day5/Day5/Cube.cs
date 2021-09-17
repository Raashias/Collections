using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Cube : ShapeN
    {
       static int x = 10;
         public double Area()
        {
            return 6 * x * x;
        }

        public double volume()
        {
            return x * x * x;
        }


    }
}
