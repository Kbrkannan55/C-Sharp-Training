using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprgm1
{
    internal class newsolution
    
    {
        internal class ListElements
        {
            public void ListCollec()
            {
                List<int> number = new List<int>();
                number.Add(0);
                number.Add(1);
                number.Add(2);
                foreach (int num in number)
                {
                    Console.WriteLine(num);
                }
                number.Append(10);
                Console.WriteLine("");
                Console.WriteLine("-------------------------");
                Console.WriteLine("AFTER SORT:");
                number.Sort();
                number.Remove(0);
                foreach (int num in number)
                {
                    Console.WriteLine(num);
                }
                Console.WriteLine("-------------------------");
                Console.WriteLine("average: " + number.Average());
                Console.WriteLine("Sum: " + number.Sum());
            }

            //  Keys must be unique and cannot be null.
           // Values can be null or duplicate.


            public void Hash()
            {
                Dictionary<int, int> hash = new Dictionary<int, int>();
                hash.Add(1, 200);
                hash.Add(2, 854);
                foreach (int k in hash.Keys)
                {
                    Console.WriteLine(k);
                }
                Console.WriteLine("-------------------------");
                foreach (int k in hash.Values)
                {
                    Console.WriteLine(k);
                }
                Console.WriteLine("-------------------------");
                foreach (int k in hash.Keys)
                {
                    Console.WriteLine(hash[k]);
                }
            }
         
            //NON-GENERICS
            public void ArrayListCollec()
            {
                ArrayList number = new ArrayList();
                number.Add(0);
                number.Add("hi");
                number.Add(28.96);
                foreach (var num in number)
                {
                    Console.WriteLine(num);
                }
                //number.Append(10);
                Console.WriteLine("");
                Console.WriteLine("-------------------------");
                Console.WriteLine("AFTER SORT:");

                number.Remove("hi");
                foreach (var num in number)
                {
                    Console.WriteLine(num);
                }
                Console.WriteLine("-------------------------");
                //Console.WriteLine("average: " + number.Average());
                //Console.WriteLine("Sum: " + number.Sum());
            }

           }
            
           
            public void NonGenHash()
            {
                Hashtable hash = new Hashtable();
                hash.Add(1, "Raja");
                hash.Add("Boopathi", 854);
                foreach (var k in hash.Keys)
                {
                    Console.WriteLine(k);
                }
                Console.WriteLine("-------------------------");
                foreach (var k in hash.Values)
                {
                    Console.WriteLine(k);
                }
                Console.WriteLine("-------------------------");
                foreach (var k in hash.Keys)
                {
                    Console.WriteLine(hash[k]);
                }
            }
           public void arr()
             {
                int[] arrr= new int[10];
                for(int i = 0; i < 10; i++)
                {
                    arrr[i] = i;
                }

             }
       }

       internal class enumdemos
      {
        enum Colors { Red, Green, Blue };

        public void Display()
        {
            Colors colors1 = Colors.Red;
            Colors colors2 = Colors.Green;
            Colors colors3 = Colors.Blue;
            Console.WriteLine(colors3);

        }

    }
}

