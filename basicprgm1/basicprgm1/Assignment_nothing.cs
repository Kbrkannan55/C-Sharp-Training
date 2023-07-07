using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprgm1
{
    internal class new_nothing : nothing
    {
        public override void Name(string name,int roll)
        {
            string sname,address;
            int rollno;

            sname= name;
            rollno = roll;
            address = "Mettupalayam";

            Console.WriteLine("Enter Student Name "+sname);
            Console.WriteLine("Rollno " + rollno);
            Console.WriteLine("Address " + address);
        }
    }
}
