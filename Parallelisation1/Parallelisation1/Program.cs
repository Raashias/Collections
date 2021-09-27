using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Parallelisation1
{
   
    class Program
    {
        //private static int totalSize;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the range: ");
            int a = Convert.ToInt32(Console.ReadLine());
            EvenOdd b = new EvenOdd();
            Thread thread1 = new Thread(b.Evenn);
            Thread thread2 = new Thread(b.Oddd);
            thread1.Start(a);
            thread2.Start(a);

            //Task Task1 = new Task (b.Evenn);
            //Task1.Start();
            for(int i=0; i< Convert.ToInt32(a);i++)
            {
                if(i%2 == 0)
                
                    Console.WriteLine($"Even Number: {i}");
                
            }
            




            ////Printing the content from the file parallely
            //FileStream fs = new FileStream(@"C:\Training\EuroTraining\Collections\Parallelisation1\networklog.txt", FileMode.Open, FileAccess.Read);
            //StreamReader sw = new StreamReader(fs);
            //List<String> res = new List<String>();

            //while (sw.Peek() > 0)
            //{
            //    res.Add(sw.ReadLine());

            //}

            //sw.Close();
            //fs.Close();

            //Parallel.For(0, res.Count, i =>
            //{
            //    Console.WriteLine(res[i]);
            //    Console.WriteLine($"key: {i}, thread: {Thread.CurrentThread.ManagedThreadId}");
            //    Thread.Sleep(100000);

            //});
            Console.Read();
    }
        //Printing even and odd numbers in that particular range
        //Console.Write("Enter the value: ");
        //int a = Convert.ToInt32(Console.ReadLine());
        //DateTime t1 = DateTime.Now;
        //Console.WriteLine("Start Date and time: " + DateTime.Now);

        //Console.WriteLine("Sequential programming");
        //for (int i = 1; i < a; i++)
        //{
        //    if (i % 2 == 0)
        //    {
        //        Console.WriteLine($"Even Number: {i}, threadid = {Thread.CurrentThread.ManagedThreadId}");
        //        Thread.Sleep(1000);
        //    }


        //    if (i % 2 == 1)
        //    {
        //        Console.WriteLine($"Odd Number: {i}, threadid = {Thread.CurrentThread.ManagedThreadId}");
        //        Thread.Sleep(1000);
        //    }
        //}
        //Console.WriteLine("End Date and time: " + DateTime.Now);



        //Console.WriteLine("StartDate and time: " + DateTime.Now);

        //DateTime t2 = DateTime.Now;

        //Console.WriteLine("Parallel programming");
        //Parallel.For(1, a + 1, i =>
        //    {
        //        if (i % 2 == 0)
        //        {
        //            Console.WriteLine($"Even Number: {i}, threadid = {Thread.CurrentThread.ManagedThreadId}");
        //            Thread.Sleep(1000);
        //        }


        //        if (i % 2 == 1)
        //        {
        //            Console.WriteLine($"Odd Number: {i}, threadid = {Thread.CurrentThread.ManagedThreadId}");
        //            Thread.Sleep(1000); //uses diff threads
        //      }

        //    });
        //Console.WriteLine("End Date and time: " + DateTime.Now);
        //TimeSpan time = t2 - t1;
        //Console.WriteLine("Difference " + time);

        //Console.Read();





        //parallel file extraction
        //if (!Directory.Exists(@"C:\Training\EuroTraining\C# Applications\FileCreationNew\FileCreationNew"))
        //{

        //    Console.WriteLine("The directory does not exist.");
        //    return;
        //}

        //String[] files = Directory.GetFiles(@"C:\Training\EuroTraining\C# Applications\FileCreationNew\FileCreationNew");

        //Parallel.For(0, files.Length, index =>
        //{

        //    FileInfo fi = new FileInfo(files[index]);
        //    long size = fi.Length; Interlocked.Add(ref totalSize, (int)size);
        //});
        //Console.WriteLine("Directory '{0}':", @"C:\Training\EuroTraining\C# Applications\FileCreationNew\FileCreationNew");
        //Console.WriteLine("{0:N0} files, {1:N0} bytes", files.Length, totalSize);
        //Console.WriteLine($"Thread: {Thread.CurrentThread.ManagedThreadId}");



    }

}
   


