using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace basicprgm1
{
    internal class Addition
    {
        /* 
        private int num1, num2;

       public Addition(int num1, int num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
        }

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }
      */

        private static int bon;
        public Addition() { 
        
        }
        
        internal int add(int x,int y,out int Num1, out int Num2)
        {
            Num1 = 10+x;
            Num2 = 20+y;
            return Num1;
            return Num2;

        }




    }

    
}
