using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqdemo
{
    internal class VoterCheck
    {
        public static List<People> where (People[] p,EligibilityCheck del)
        {
            List<People> voters= new List<People>();
            foreach(People person in p)
            {
                if (del(person))
                {
                    voters.Add(person);
                }
               
            }
            return voters;
        }
    }
}
