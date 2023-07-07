using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprgm1
{
    internal class loan : banking
    {
        private double Loanno, Loanamount;
        private string Name;
        private double Accno;

        public loan(double loanno,double loanamount,double accno,string name) : base(accno,name)
        {
            this.Loanno = loanno;
            this.Loanamount = loanamount;
            this.Name2 = name;
            this.Accno1 = accno;    
        }

        public void loandetails()
        {
            Console.WriteLine("Name " + Name);
            Console.WriteLine("Account No " + Accno);
            Console.WriteLine("Loan No " + Loanno);
            Console.WriteLine("Loan Amount " + Loanamount);
        }

        public double Loanno1 { get => Loanno; set => Loanno = value; }
        public double Loanamount1 { get => Loanamount; set => Loanamount = value; }
        public string Name2 { get => Name; set => Name = value; }
        public double Accno1 { get => Accno; set => Accno = value; }
    }
}
