using linqdemo;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate bool EligibilityCheck(People person);

    class Program
    {
        public static void Main(string[] args)
        {
        /*
        
        People[] p = new People[]
        {
           new People {Name="Boopathi", Age=23},
           new People {Name="Jothika", Age=23},
           new People {Name="Anu", Age=11},
           new People {Name="Abinaya", Age=17},
           new People {Name="Keerthika", Age=16}
        };
        */
        /*
        people[] voters = new people[p.Length];
        int i = 0;
        foreach(people person in p)
        {
            if (person.Age >= 18)
            {
                voters[i++] = person;
               Console.WriteLine(person.Name);
            }
        }
        
        

        List<People> p = new List<People>
        {
           new People {Name="Boopathi", Age=23},
           new People {Name="Jothika", Age=23},
           new People {Name="Anu", Age=21},
           new People {Name="Abinaya", Age=17},
           new People {Name="Keerthika", Age=16}
        };
        */
        /*
        List<People> voters = VoterCheck.where(p, delegate (People person)
        {
            return person.Age >=18;
        });

        foreach (People voter in voters)
        {
            Console.WriteLine(voter.Name);
        }
        */
        


        //List<People> voters = p.Where(p => p.Age >= 18).ToList();
        /*
        List<People> voters = (from voter in p where voter.Age>=18 select voter).ToList();
        Console.WriteLine(voters);

        foreach (var voter in voters)
        {
            Console.WriteLine(voter.Name);
        }
        */


        // ExamplesForClassifications e=new ExamplesForClassifications();
        // e.example1();
        // e.example2();
        //  e.example3();
        // e.example4();
        //  e.example5();

        Random rnd= new Random();
        int num = rnd.Next(0, 9);
        int rannumber;
        for (int i = 0; i < 6; i++)
        {
            rannumber = rnd.Next(000000, 999999);
            Console.WriteLine(rannumber);
        }

        }
    }
