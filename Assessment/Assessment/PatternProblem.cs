using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assessment
{

    //Character Pattern
    internal class CharPattern
    {
        private int i, row,column;

        internal CharPattern(int num)
        {
            this.I = num;
        }

        public int I { get => i; set => i = value; }
        public int Row { get => row; set => row = value; }
        public int Column { get => column; set => column = value; }

        public void CPattern()
        {
            for(row=0; row<this.I; row++)
            {
                for(column=0; column<row; column++)
                {
                    Console.Write("*   ");
                }
                Console.WriteLine();
            }
        }

    }


    //Numeric Pattern

    internal class NumericPattern
    {
        int i, row, column;
        public NumericPattern(int num)
        {
            this.I = num;
        }

        public int I { get => i; set => i = value; }
        public int Row { get => row; set => row = value; }
        public int Column { get => column; set => column = value; }

        public void NPattern()
        {
            int number = 1;
            for (int i = 0; i < I ; i++)
            {
                for (int space = I - 1; space > i; space--)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(number++ + "   ");
                }
                Console.WriteLine();
                number = 1;
            }   
        }
    }


    //Partial 

    internal partial class Calculator
    {
        private int num1,num2;
        public Calculator(int n1,int n2)
        {
            this.Num1 = n1;
            this.Num2 = n2;
        }

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }


    }

    internal partial class Calculator
    {
        public int add()
        {
            int addition;
            addition = Num1 + Num2;
            return addition;
        }
    }

    internal partial class Calculator
    {
        public int sub()
        {
            int subtract;
            subtract = Num1 - Num2;
            Console.WriteLine("Subtraction of two numbers " + subtract);
            return subtract;
        }
    }

    internal partial class Calculator
    {
        public int mul()
        {
            int multiplication;
            multiplication=Num1 * Num2;
            return multiplication;
        }
    }

    internal partial class Calculator
    {
        public int div()
        {
            int division;
            division = Num1 / Num2;
            return division;

        }
    }
   
    internal partial class Calculator
    {
        public int mod()
        {
            int modulus;
            modulus = Num1 % Num2;
            return modulus;
        }
    }


    internal class FileOperations
    {

        public void CreateFile()
        {
            FileInfo fi = new FileInfo($@"C:\Users\kbrka\OneDrive\Desktop\practical training\\Employee.txt");
            using StreamWriter str = fi.CreateText();
            Console.WriteLine("File has been created");
            str.WriteLine("Hr Tl Tl Hr Tl ");
            Console.WriteLine("Written");


        }
        public void Readfile()
        {
            string path = ($@"C:\Users\kbrka\OneDrive\Desktop\practical training\\Employee.txt");
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            string text = System.IO.File.ReadAllText($@"C:\Users\kbrka\OneDrive\Desktop\practical training\\Employee.txt");
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int count1 = 0;
            int count2 = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "Hr")
                {
                    count1++;
                }
                else if (words[i] =="Tl") 
                {
                    count2++;
                }
            }
           
            Console.WriteLine("Count of HR :" + count1);
            Console.WriteLine("Count of TL :" + count2);

            reader.Close();
            fileStream.Close();


        }

    }


}
