using System;

namespace Day5
{
    class Rectangle : Shape //Extension to the shapeclass
    {
        int l, w;

        public Rectangle(String color, int length, int width)
        {
            setColor(color);
            this.l = length;
            this.w = width;

        }
        public override double Area(int Length, int Width)
        {
            return l * w;
        }

        public void DisplayArea()
        {
            double A = Area(l, w);
            Console.WriteLine("Area is: " + A);
        }

    }
}
