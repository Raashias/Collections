using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerBill
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the Number of Customers:");
            int x = Convert.ToInt32(Console.ReadLine());
            Dictionary<Consumer, GenerateBill> dt = new Dictionary<Consumer, GenerateBill>();
            int j = 0;

            while (x > 0)
            {
                Consumer cn = new Consumer();
                
                Console.WriteLine($"Enter the customer {++j} Number");
                int a = Convert.ToInt32(Console.ReadLine());
                cn.CNumber = a;
                Console.WriteLine("Enter the name of the customer: ");
                cn.CName = Console.ReadLine();
                Console.WriteLine("Enter the Totalunits: ");
                cn.Totalunits = Convert.ToInt32(Console.ReadLine());
                

                GenerateBill bl = new GenerateBill();
                Console.WriteLine("Enter the Cost per unit: ");
                double Cpu = Convert.ToInt32(Console.ReadLine());
                bl.Costperunit = Cpu;
                bl.ConsumerNum = a;
                dt.Add(cn, bl);

                System.Random random = new System.Random();
                bl.Billnum = random.Next(1000000);

                bl.Totalamount = bl.Costperunit * cn.Totalunits;

                bl.Duedate = DateTime.Today.AddDays(10);

                x--; 

            }

            Console.WriteLine();
            Console.WriteLine("BILL GENERATION");
            
            foreach ( var i in dt)
            {
                Console.WriteLine("Bill Number: " + i.Value.Billnum);
                Console.WriteLine("Consumer Number: " + i.Value.ConsumerNum);
                Console.WriteLine("Consumer Name: " + i.Key.CName);
                Console.WriteLine("Total number of Units: " + i.Key.Totalunits);
                Console.WriteLine("Cost per unit: " + i.Value.Costperunit);
                Console.WriteLine("Total Amount charged: " + i.Value.Totalamount);
                Console.WriteLine("DueDate: " + i.Value.Duedate);

                Console.WriteLine();
             }

           
            Console.Read();

        }
    }
}
