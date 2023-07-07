using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprgm1
{
    internal class savings : banking
    {

        public savings(double accno,string name) : base(accno, name)
        {
            
        }

        public void BankDetails()
        {
            Console.WriteLine("Account Number " + AccountNo1);
            Console.WriteLine("Holder Name " + Name1);
            Console.WriteLine("Savings Amount 500000");
        }
    }
}
