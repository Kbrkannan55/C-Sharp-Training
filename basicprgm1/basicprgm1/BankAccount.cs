using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprgm1
{
    internal class BankAccount
    {
        private int cusid;
        private string name;
        private long accno;
        private double balance;
        private string status;

        public BankAccount(int cusid, string name, long accno, double balance, string status= "Inactive")
        {
            Cusid = cusid;
            Name = name;
            Accno = accno;
            Balance = balance;
            Status = status;
         
        }

        public void checkaccstatus(long accno)
        {
            if(accno==Accno)
            {
                 balance=Balance; status=Status; name=Name; cusid=Cusid;
            }
        }

        public void checkaccstatus(int cusid)
        {
            if (cusid==Cusid)
            {
                balance = Balance; status = Status; name = Name; accno=Accno;
            }
        }

        public int Cusid { get => cusid; set => cusid = value; }
        public string Name { get => name; set => name = value; }
        public long Accno { get => accno; set => accno = value; }
        public double Balance { get => balance; set => balance = value; }
        public string Status { get => status; set => status = value; }
    }
}
