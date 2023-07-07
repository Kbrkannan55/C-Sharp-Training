using Assessment;
using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Program
{
    internal class problem
    {
        public static void Main(string[] args)
        {
            /*
            Console.WriteLine("Choose Your Choice");
            Console.WriteLine("1. Character Pattern");
            Console.WriteLine("2. Numeric Pattern");

            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    int num1;
                    Console.WriteLine("How many rows to be printed ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    CharPattern ch = new CharPattern(num1);
                    ch.CPattern();
                    break;
                case 2:
                    int num2;
                    Console.WriteLine("How many rows to be printed ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    NumericPattern n = new NumericPattern(5);
                    n.NPattern();

                    break;

                default:
                    Console.WriteLine("Enter Correct Choice");
                    break;

            }
            */


            // derivedclass d= new derivedclass();
            // d.CallLog();
            // d.DialLastCall();

            /*
            
                        int n1, n2, new_choice;

                        Console.WriteLine("Enter two Numbers");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        n2 = Convert.ToInt32(Console.ReadLine());

                        Calculator cal = new Calculator(n1, n2);
                        Console.WriteLine("1. Addition");
                        Console.WriteLine("2. Subtraction");
                        Console.WriteLine("3. Multiplication");
                        Console.WriteLine("4. Division");
                        Console.WriteLine("5. Modulus");
                        new_choice = Convert.ToInt32(Console.ReadLine());

                        switch (new_choice)
                        {
                            case 1:
                                
                                Console.WriteLine(cal.add());
                                break;
                            case 2:
                               
                                Console.WriteLine(cal.sub());
                                break;
                            case 3:

                                
                    Console.WriteLine(cal.mul());
                                break;
                            case 4:
                                
                    Console.WriteLine(cal.div());
                                break;
                            case 5:
                              
                    Console.WriteLine(cal.mod());
                                break;
                            default:
                                Console.WriteLine("Enter Correct Choice");
                                break;

                        }
             
            */


            derivedclass d = new derivedclass();


            double balance = 0;



            try
            {
                d.dis(5,0);
            }
            catch(SecondNumberZero s)
            {
                Console.WriteLine(s);
            }
     
              
                
                
           
           
            


//            FileOperations f=new FileOperations();
  //         f.CreateFile();
    //     f.Readfile();
            
           

        
        }



    }
}

