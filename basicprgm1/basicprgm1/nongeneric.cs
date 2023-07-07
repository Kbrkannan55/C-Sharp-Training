using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprgm1
{
    internal class nongeneric
    {
        public nongeneric() { }

        public void arraylist()
        {
            ArrayList list = new ArrayList();
            list.Add("hi");
            list.Add("hello");
            list.Add(45);

            foreach (var s in list)
            {
                Console.WriteLine(s);
            }

           
            foreach (var s in list)
            {
                Console.WriteLine(s); 
            }

            Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();

            keyValuePairs.Add(1, 2);
            keyValuePairs.Add(1, 4);

            foreach(var s in keyValuePairs.Values)
             Console.WriteLine(s);

        }
    }

}