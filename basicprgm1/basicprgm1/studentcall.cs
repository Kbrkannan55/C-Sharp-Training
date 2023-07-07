using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprgm1
{
    internal class studentcall : call2
    {
        private double total, avg;
        

        public studentcall(int rno, string name, double mark1, double mark2, double mark3,double total, double avg):base(rno,name,mark1,mark2,mark3)
        {
        
            this.Total = total;
            this.Avg = avg;

        }

        public double Total { get => total; set => total = value; }
        public double Avg { get => avg; set => avg = value; }

        public void Calculate()
        {
            this.total = this.Mark1 + this.Mark3 + this.Mark2;
            this.Avg = this.Total / 3;
        }
    }
}
