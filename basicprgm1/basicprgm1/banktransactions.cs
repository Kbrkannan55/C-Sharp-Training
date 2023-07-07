using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace basicprgm1
{
    public class banktransactions
    {
        private int cusid;
        private long accno;
        private string accname, status;
        private decimal balance, creditamt, debitamt;
        public banktransactions(int id, long acc, string name, decimal bal)
        {
            cusid = id;
            accno = acc;
            accname = name;
            status ="Inactive";
            balance = bal;
            creditamt = 0;
            debitamt = 0;
        }

        public int Cusid { get => cusid; set => cusid = value; }
        public long Accno { get => accno; set => accno = value; }
        public string Accname { get => accname; set => accname = value; }
        public string Status { get => status; set => status = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public decimal Creditamt { get => creditamt; set => creditamt = value; }
        public decimal Debitamt { get => debitamt; set => debitamt = value; }




        /*
private void ReadCustomerDetails()
{
Console.WriteLine("Enter Customer id ,account number, holder name,  accname, balance");
cusid = Convert.ToInt32(Console.ReadLine());
accno = Convert.ToInt64(Console.ReadLine());
accname = Console.ReadLine();
balance = Convert.ToDecimal(Console.ReadLine());
//creditamt = Convert.ToDecimal(Console.ReadLine());
//debitamt = Convert.ToDecimal(Console.ReadLine());
status = "Inactive";
creditamt = debitamt = 0;

}*/

        internal decimal PerformTransactions()
        {
            
            Console.WriteLine("1.Credit 2. Debit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                 case 1:
                    Console.WriteLine("Enter Credit Amount");
                    this.creditamt = Convert.ToDecimal(Console.ReadLine());
                    this.balance += creditamt;
                    this.status = "Active";
                    break;
                case 2:
                    Console.WriteLine("Enter Debit Amount");
                    this.debitamt = Convert.ToDecimal(Console.ReadLine());
                    this.balance -= debitamt;
                    this.status = "Active";
                    break;
                default:
                    Console.WriteLine("Please Debit or Credit");
                    PerformTransactions();
                    break;
            }
            return balance;
        }

        internal class studentDetails
        {
            private int rno;
            private string name;
            private double mark1, mark2, mark3;


            public studentDetails(int rno, string name, double mark1, double mark2, double mark3)
            {
                this.Rno = rno;
                this.Name = name;
                this.Mark1 = mark1;
                this.Mark2 = mark2;
                this.Mark3 = mark3;

            }

            public int Rno { get => rno; set => rno = value; }
            public string Name { get => name; set => name = value; }
            public double Mark1 { get => mark1; set => mark1 = value; }
            public double Mark2 { get => mark2; set => mark2 = value; }
            public double Mark3 { get => mark3; set => mark3 = value; }
        }

       
    }

}