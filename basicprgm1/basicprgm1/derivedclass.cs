using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprgm1
{
    internal class derivedclass : multipleclass,multipleinterface
    {
       
        public void derived() {
            Console.WriteLine("Derived Class");
        }
        public  void display1()
        {
            Console.WriteLine("Base class 2");
        }
    }
}
