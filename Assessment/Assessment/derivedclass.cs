using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class derivedclass : SmartPhone
    {
        public derivedclass() { }

        public void CallLog()
        {
            long num;
            Stack<long> numbers = new Stack<long>();
            numbers.Push(9234567890);
            numbers.Push(9545421212);
            numbers.Push(8542121542);
            numbers.Push(7522454212);
            numbers.Push(8542421212);
            numbers.Push(8245454512);
            numbers.Push(9545421212);
            numbers.Push(9545421212);
            numbers.Push(9545421212);
            numbers.Push(9545421212);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Need to Call");
            Console.WriteLine("Press 1");
            int val = Convert.ToInt32(Console.ReadLine());
            num =numbers.Peek();
            
        }
       

        public void DialLastCall(long s)
            {
                long s1 = s;
                Console.WriteLine(s1);
                Console.WriteLine("Call Duration :12:00 minutes");
                Console.WriteLine("Call Ended");
            }
        public void dis(int n1, int n2)
        {
            if (n2 == 0)
                throw new SecondNumberZero("Dont use 0 in n2");
            
        }
    }

}

