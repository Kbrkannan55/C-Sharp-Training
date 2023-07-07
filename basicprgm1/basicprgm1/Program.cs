/* Author : Boo
 * Date : 22/03/2023
 * Description : Basic Program
 */
/*
System.Console.WriteLine("Hello World");
System.Console.WriteLine("Hello World");
int num1, num2, ans;
Console.WriteLine("Enter two numbers");
num1=Convert.ToInt32( Console.ReadLine());
num2=Convert.ToInt32(Console.ReadLine());
ans = num1 + num2;
Console.WriteLine("Result :"+ ans);
*/

/*
int number = 97;
float flnum = number;
Console.WriteLine(flnum);

char ch =Convert.ToChar( number);
Console.WriteLine(ch);

string str = "boopathi";
char cha = ''a';
Console.WriteLine(str);
*/



/*
double answer = Math.Sqrt(16);
Console.WriteLine(answer);

int x = 5, y = 10;
string s1 = "Hello";
string s2 = "Hello world";
Console.WriteLine(s1.Length);
Console.WriteLine(s2.Substring(2,6));
Console.WriteLine(s1.IndexOf('l'));
Console.WriteLine($"{x} {y}");
*/
using System;

class Program
{
    /*
    public void big2()
    {
        int num1, num2,num3;
        Console.WriteLine("Enter 3 numbers");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        num3 = Convert.ToInt32(Console.ReadLine());
        if ((num2 > num1) && (num2 > num3))
            Console.WriteLine("Num 2 is Greater");
        else if ((num1 > num2) && (num1 > num3))
            Console.WriteLine("Num 1 is Greater");
        else if ((num3 > num1) && (num3 > num2))
            Console.WriteLine("Num 3 is Greater");
        else
            Console.WriteLine("None");
    }


    public void switching()
    {
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        switch (n)
        {
            case 0:
                Console.WriteLine("0 is Selected");
                break;
            case 1:
                Console.WriteLine("1 is Selected");
                break;
            default:
                Console.WriteLine("None is Selected");
                break;
        }

    }
    public void loop()
    {
       int num1, n2=0;
        num1= Convert.ToInt32(Console.ReadLine());
        do
        {
            n2=n2+1; 
           
            num1++;

        } while (num1 <5);
        Console.WriteLine(n2);

    }

    public void whileloop()
    {
        int num1, n2=0;
        num1= Convert.ToInt32(Console.ReadLine());
        while(num1 <5);
        {
            n2++;
            num1++;
        }
        Console.WriteLine(n2);
    }

    public void forloop()
    {
        int num1, n2;
        num1= Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<5;i++)
        {
            Console.WriteLine(i);
        }
    }
    public void foreachloop()
    {
        int num1=900, n2;
        //num1= Convert.ToInt32(Console.ReadLine());
        //n2 = Convert.ToInt32(Console.ReadLine());
        string s1 = "Hello World";

        foreach(char s in s1)
        {
            Console.WriteLine(s1);
        }
    }

    public void arraydisplay()
    {
       /* int[] num=new int[5];
        num[0] = 10;
        num[1] = 20;
        num[2] = 30;
        num[3] = 40;
        num[4] = 50;
      

        int[] num = { 10, 20, 90, 5, 50 };
        Array.Sort(num);
        foreach(int n in num)
        {
            Console.WriteLine(n);
        }
    }*/


   
  

}
