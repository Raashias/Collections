using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Day5
{
    public abstract class Shape
    {
        private String color;
        public void setColor(String c)
        {
            this.color = c;

        }
        public String getColor()
        {
            return color;
        }

        public abstract double Area(int Length, int Width);
       
    }
}
