using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprgm1
{
    internal class jaggedarray
    {
        private int accno;
        private string name;
        private double balance;
        private double interest_amount;

        public jaggedarray(int accno, string name, double balance, double interest_amount)
        {
            this.Accno = accno;
            this.Name = name;
            this.Balance = balance;
            this.Interest_amount = interest_amount;
        }

        public int Accno { get => accno; set => accno = value; }
        public string Name { get => name; set => name = value; }
        public double Balance { get => balance; set => balance = value; }
        public double Interest_amount { get => interest_amount; set => interest_amount = value; }

        public void Bank_method()
        {
            List<jaggedarray> acc = new List<jaggedarray>()
            { new jaggedarray(12542, "ABC", 150000, 5),
              new jaggedarray(14421,"BOO",200000,15),
              new jaggedarray(520042, "VINO", 74040, 2)
            };

            var names = acc.Select(x => x.Name);

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }


        }

        
        public void jagged()
        {
            int i, j;
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[] { 1, 2, 3, 4, 5 };
            jaggedArray[1] = new int[] { 40, 50, 11, 4 };
            jaggedArray[2] = new int[] { 55, 17 };
            jaggedArray[3] = new int[4];

            Console.WriteLine(jaggedArray[0][2]);

            for(i = 0; i < jaggedArray[3].Length; i++)
            {
                jaggedArray[3][i]=Convert.ToInt32( Console.ReadLine());
            }
            

            int[][,] jaggy=new int[3][,];
            jaggy[0] = new int[5,4];
            jaggy[1]= new int[6,5];
            jaggy[2]= new int[7,6];

            for( i = 0; i < 5;i++)
            {
                for( j = 0; j < 4; j++)
                {
                    jaggy[0][i,j] =Convert.ToInt32(Console.ReadLine());
                }
            }

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write(jaggy[0][i, j]); 
                }
                Console.WriteLine();
            }
        }


        public void LE()
        {
            List<int> list = new List<int>() ;
            list.Add(10);
            list.Add(20);
            list.Add(55);
            list.Add(1);
            list.Add(9);
            list.Add(2);
            List<int> evenum= list.FindAll(x =>((x%2)==0));
            
            foreach(int s in evenum)
            {
                Console.WriteLine(s);
            }

            

        }


        



    }
}
