using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprgm1
{
    internal static class staticdemo
    {
        static int consumerno=143,prev=1000,current=1324;
        static double amount;
        

        public static int Consumerno { get => consumerno; set => consumerno = value; }
        public static int Prev { get => prev; set => prev = value; }
        public static int Current { get => current; set => current = value; }
        public static double Amount { get => amount; set => amount = value; }

        public static double cal()
        {
            amount = (current - prev) * 10;
            return amount;
        }

        public static void dis()
        {
            Console.WriteLine("Executed");
            cal();
        }
    }
}
