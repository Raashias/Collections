using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerBill
{
    class Consumer
    {
        String ConsumerName;
        int TotalUnits, ConsumerNum;
        public String CName { get => ConsumerName; set => ConsumerName = value; }
        public int CNumber { get => ConsumerNum; set => ConsumerNum = value; }
        public int Totalunits { get => TotalUnits; set => TotalUnits = value; }

    }
}
