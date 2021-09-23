using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallelisation1
{
    class EvenOdd
    {
        public void Evenn(object a)
        {
            for (int i = 0; i < Convert.ToInt32(a); i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"Even Number: {i}");

            }

        }

        public void Oddd(object b) 
        { 
            for (int i = 0; i < Convert.ToInt32(b); i++)
            {
                if (i % 2 == 1)
                Console.WriteLine($"Odd Number: {i}");

            }
        }
    }
}
