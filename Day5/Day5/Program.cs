using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cube and circle problem

            Cube cb = new Cube();
            Console.WriteLine("Area of Cube: " + cb.Area());
            Console.WriteLine("Volume of Cube: " + cb.volume());
            Circle cc = new Circle();
            Console.WriteLine("Area of Circle: " + cc.Area());
            Console.WriteLine("Volume of Circle: " + cc.Area());




            Console.Read();
            //rectangle problem
            //Rectangle rect = new Rectangle("Green", 5, 10);
            //rect.DisplayArea();

            //WordLength
            //var Letters = new List<String> { "Maroon","Green","Red","Pink","Yellow","Purple" };
            //WordLength(Letters);

            //SUM OF EVEN NUMBERS
            //var addition = new List<int>();
            //addition.Add(1);
            //addition.Add(2);
            //addition.Add(3);
            //addition.Add(4);
            //addition.Add(5);
            //addition.Add(6);
            //addition.Add(7);
            //addition.Add(8);
            //addition.Add(9);
            //addition.Add(10); // or List<int>{1,2,3,4,5,6,7,8,9,10}
            //int result = EvenNumbers(addition);
            //Console.WriteLine("Sum of even numbers: " + result);
            //Console.ReadLine();

        }
        //SUM OF EVEN NUMBERS
        //public static int EvenNumbers(List<int> l)
        //{
        //    int sum = 0;
        //    foreach (var addy in l)
        //    {
        //        if (addy % 2 == 0)
        //        {
        //            sum += addy;
        //        }
        //    }
        //    return sum;

        //}


        //WordLength
        //public static void WordLength(List<String> Str)
        //{
        //    Console.WriteLine("Enter the Length of the String");
        //    int result = Convert.ToInt32(Console.ReadLine());
        //    foreach (var value in Str)
        //    {
        //        String a = value;

        //        if (a.Length == result)
        //        {
        //            Console.WriteLine(a);
        //        }
        //    }

        //}



    }
}
