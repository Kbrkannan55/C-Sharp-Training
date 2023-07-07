using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqtoSql
{
    internal class Program
    {
       public static void Main(string[] args)
        {
          StaffDetials s=new StaffDetials();
            //s.ReadData();
            s.Aggregate();
            Console.Read();
        }
    }
}
