using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIT_Earnings
{
    class Occupation
    {
        public string Cat { get; set; }
        public string Name { get; set; }
        public double WEarn { get; set; }
        public double MEarn { get; set; }
        public int WNum { get; set; }
        public int MNum { get; set; }
        public float Percent { get; set; }
        public double TotalEarn { get; set; }
        public int TotalNum { get; set; }

        public Occupation() { }
    }
}
