using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprgm1
{
    internal class bankdetails
    {
        private int accno;
        private string name;
        private double balance;
        private double interest_amount;

        public bankdetails(int accno, string name, double balance, double interest_amount)
        {
            this.Accno = accno;
            this.Name = name;
            this.Balance = balance;
            this.Interest_amount = interest_amount;
        }

        public int Accno { get => accno; set => accno = value; }
        public string Name { get => name; set => name = value; }
        public double Balance { get => balance; set => balance = value; }
        public double Interest_amount { get => interest_amount; set => interest_amount = value; }

        public void Bank_method()
        {
            List<bankdetails> acc = new List<bankdetails>()
            { new bankdetails(12542, "ABC", 150000, 5),
              new bankdetails(14421,"BOO",200000,15),
            new bankdetails(520042, "VINO", 74040, 2)
            };

            var names = acc.Select(x => x.Name);

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }


        }

      //  public double Calculate_interest();
    }
}
