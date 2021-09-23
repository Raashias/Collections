using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerBill
{
    class GenerateBill
    {
        int BillNo, ConsumerNo;
        double CostPerUnit, TotalAmount;
        DateTime DueDate;
        public int Billnum { get => BillNo; set => BillNo = value; }
        public int ConsumerNum { get => ConsumerNo; set => ConsumerNo = value; }
        public double Costperunit { get => CostPerUnit; set => CostPerUnit = value; }
        public double Totalamount { get => TotalAmount; set => TotalAmount = value; }
        public DateTime Duedate { get => DueDate; set => DueDate = value; }

        
    }
}
