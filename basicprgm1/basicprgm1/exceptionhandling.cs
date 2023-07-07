using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprgm1
{
    internal class exceptionhandling
    {
        int n1, n2, ans;

        public exceptionhandling(int n1,int n2, int ans) {
        this.n1 = n1; this.n2 = n2; this.ans = ans;

        }
        public void add()
        {
            this.ans = this.n1 + this.n2;
            Console.WriteLine(ans);

        }

        public void mul()
        {
            this.ans = this.n1 * this.n2;
            Console.WriteLine(ans);
        }

        public void div()
        {
            int[] num = { 10, 0 };
            try
            {
                this.ans = this.n1 / this.n2;
                Console.WriteLine(ans);
                int x = num[0]/num[2];
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Don't give 0 in the denominator");
            }

            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done");
            }
        }

        public void checkval(int num)
        {
            if (num > 0)
            {
                throw new ArgumentException("Dont pass 0");
            }
            else if (num < 18)
            {
                throw new ArithmeticException("Number should be greater than 18");
            }
            else
            {
                Console.WriteLine("OK");
            }
        }
    }
}
