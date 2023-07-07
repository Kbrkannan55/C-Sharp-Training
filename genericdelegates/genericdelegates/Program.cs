//using genericdelegates;

/*public delegate int MyDelegate();
*/
/*
class Program
{
    public static void Main(string[] args)
    {
        //Delegate
        /*
                MyDelegate del1 = Delegateusage1.Method1;
                MyDelegate del2 = Delegateusage2.Method2;
                MyDelegate del = del1 + del2;
                Console.WriteLine(del1());
                Console.WriteLine(del2());
               */

/*
GenDel<int> gi = new genericdelegates.GenDel<int>(10);
GenDel<double> gd = new GenDel<double>(32.544545);
GenDel<String> gs = new GenDel<string>("Hello");

Console.WriteLine(gi.Rollno);
Console.WriteLine(gd.Rollno);
Console.WriteLine(gs.Rollno);
*/

// GenDel<ArithmeticException> ae = new GenDel<ArithmeticException>(a);
//Console.WriteLine(ae.disp().Message);


/*
GenDel<int> gint = new GenDel<int>(5);
for (int i = 0; i < 5; i++)
{
    gint.setarr(i,i*2);
}

for(int i = 0;i< 5; i++) { 
Console.WriteLine( gint.getarr(i) );
}

GenDel<char> gchar= new GenDel<char>(5);
for(int i=0;i<5;i++)
{
    gchar.setarr(i,Convert.ToChar(i+65));
}
for(int i=0;i<5;i++)
{
    Console.WriteLine( gchar.getarr(i) );
}
*/

using System;

int n1, n2;

readdata();

void readdata()
{
    n1 = Convert.ToInt32(Console.ReadLine());
    n2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(n1 + n2);
    Console.Read();
}
