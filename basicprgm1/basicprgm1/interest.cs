using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprgm1
{
    internal class interest 
    {
        private int interest_percentage;

        public interest(int interest_percentage,int accno,string name,double balance,double interest_amount)
        {
            this.Interest_percentage = interest_percentage;
            
        }

        public int Interest_percentage { get => interest_percentage; set => interest_percentage = value; }
        /*
        public override double Calculate_interest()
        {

            return (Balance * (interest_percentage /100));
        }
        */
    }
}
