using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LinqtoSql
{
    internal class StaffDetials
    {
        SampleDBDataContext c = new SampleDBDataContext();
        public void ReadData()
        {
            

            //   var res = from s in c.staff_Masters where s.Staff_sal>45000 select s;

            var res = c.staff_Masters.Where(s => s.Staff_sal > 45000);
            foreach (var m in res)
            {
                Console.WriteLine("Staff Code " + m.Staff_Code + " Staff Name " + m.Staff_Name);
            }
        }

        public void Aggregate()
        {
            
           var res =((from s in c.staff_Masters select s.Staff_Code).Min() + (from s in c.staff_Masters select s).Count());

            var result = c.staff_Masters.Min(s=>s.Staff_Code,t);
            
            Console.WriteLine(result);

            int res1=(from s in c.staff_Masters select s.Staff_Code).Min();

            int res2 = (from s in c.staff_Masters select s.Staff_Code).Max();

            

      //      Console.WriteLine("Minimum Salary " + res1);
 
     //       Console.WriteLine("Maximum Salary " + res2);

    //        Console.WriteLine(res);


        }      
    }
}
