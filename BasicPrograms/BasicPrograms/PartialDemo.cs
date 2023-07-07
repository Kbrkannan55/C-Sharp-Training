using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    partial class PartialDemo
    {
        int n1, n2;

        public PartialDemo(int n1,int n2)
        {
           this.n1 = n1;
            this.n2 = n2;

        }

        public int N1 { get => n1; set => n1 = value; }
        public int N2 { get => n2; set => n2 = value; }
        
       
       partial void dis();
    }

    partial class PartialDemo
    {
        int ans;
        public PartialDemo(int n1,int n2,int Ans)
        {
            this.N1 = n1;
            this.N2 = n2;
            this.Ans = Ans;
        }

        public int Ans { get => ans; set => ans = value; }

      partial void dis()
        {
            ans = n1 + n2;
            Console.WriteLine(ans);
        }

        public void add()
        {
            Console.WriteLine(n1);
            Console.WriteLine(n2);
        }
    }
}
