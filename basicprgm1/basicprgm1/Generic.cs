using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprgm1
{
    internal class Generic
    {
        public Generic() { }

        public void Listelements()
        {
            
            List<int> list = new List<int>();
            List<int> list2 = new List<int>();
            
            list.Add(100);
            list.Add(250);
            list.Add(30);
            list.Add(-25);

            list.Skip(1);   

            


            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            { 
               
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("Total "+list.Sum());
            Console.WriteLine("Average "+list.Average());
            list.Sort();
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            

            Dictionary<int,int> n= new Dictionary<int,int>();
            n.Add(1,100);
            n.Add(1, 1000);

            foreach(int i in n.Keys)
                Console.WriteLine(i);
            foreach(int i in n.Values)
                Console.WriteLine(i);

            foreach (int i in n.Keys)
                Console.WriteLine(i+" : "+n[i]);

        }
    }
}
