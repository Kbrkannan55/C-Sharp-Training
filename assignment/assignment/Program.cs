// See https://aka.ms/new-console-template for more information
using assignment;
using System;
using System.Drawing;

class Program1
{
    public static void Main(string[] args)
    {
        //  completecall call = new completecall();

        //Quadrant
        /*        int xaxis, yaxis;
        Console.WriteLine("The Value of X coordinate :");
        xaxis = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The Value of Y coordinate :");
        yaxis = Convert.ToInt32(Console.ReadLine());
        call.quadrant(xaxis, yaxis);


        // Student Details

        int rollno, phy_mark, chem_mark, com_mark, total_mark;
        decimal percentage;
        string division,name;
        call.student_details(784, "James", 70, 80, 90);


        // Trianglenumber 1
        call.triangle1();

        // Triangenumber 2
        call.triangel2(4);

        //Electricity Bill
        call.electricity();

        //Reverse Array
        call.reversearray();
        call.copyarray();
        call.sumarray();
        call.uniques();
        call.secondlargest();
        call.transpose();
        call.prime();
        call.countstring();
        call.totalcount();
        call.fibo(5);
        call.armstrong(1);
        call.primes(5);
        call.stringpalindrome("malayalam");
        call.numpalindrome(12521);
        */


        


        // Question 1
        FileOperations fileOperations = new FileOperations();
        if (fileOperations.createfile() == false)
        {
            Console.WriteLine("The file exists/created and operable");
        }
        else
        {
            Console.WriteLine("The file is not operable");
        }
        fileOperations.writingToFile();
        fileOperations.readFromFile();


        //Question 2
        stringDuplication stringDuplication = new stringDuplication();
        stringDuplication.findDuplicate();


        //Question 3
        Repetition rep = new Repetition();
        Console.WriteLine("Enter the string : ");
        string input = Console.ReadLine();
        rep.Display_Rep(input);

        //Question 4
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        DataTransfer dt = new DataTransfer();
        dt.process(s1, s2);

        //Question 5
        Sequence seq = new Sequence();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string sequence = Console.ReadLine();
            Console.WriteLine(seq.Colors(sequence) ? "True" : "False");
        }


        //Question 6
        Digit d = new Digit();
        string[] inputs = Console.ReadLine().Split(' ');
        long num = long.Parse(inputs[0]);
        int k = int.Parse(inputs[1]);
        long digitSum = 0;
        while (num > 0)
        {
            digitSum += n % 10;
            n /= 10;
        }
        digitSum *= k;
        Console.WriteLine(d.Digits(digitSum));





    }

}

