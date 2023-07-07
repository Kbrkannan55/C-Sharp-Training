using basicprgm1;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

class Demo3
{
    public static void Main(string[] args)
    {
        //  Program demo1 = new Program();
        /* demo1.big2();
         demo1.switching();*/
        /*demo1.loop();
        demo1.whileloop();*/
        //demo1.forloop();
        //demo1.foreachloop();
        // demo1.arraydisplay();


        // Console.WriteLine("Enter Customer id ,account number, holder name, balance");
        //  int  cusid = Convert.ToInt32(Console.ReadLine());
        //long accno = Convert.ToInt64(Console.ReadLine());
        //string accname = Console.ReadLine();
        //decimal balance = Convert.ToDecimal(Console.ReadLine());
        //creditamt = Convert.ToDecimal(Console.ReadLine());
        //debitamt = Convert.ToDecimal(Console.ReadLine());
        //     string status = "Inactive";
        //      decimal creditamt =0, debitamt = 0;
        //  banktransactions Bank = new banktransactions(cusid,accno,accname,balance);
        //   banktransactions bank = new banktransactions(125,5000045,"Boo",35000);
        // decimal bal =   bank.PerformTransactions();
        //    Console.WriteLine($"Name : {accname} Account Balance : {balance} Account Status : {status}");


        /*   Console.WriteLine("Enter the Roll Number, Name and 3 marks");
           int rno=Convert.ToInt32(Console.ReadLine());
           string name=Console.ReadLine();
           double mark1=Convert.ToDouble(Console.ReadLine());
           double mark2=Convert.ToDouble(Console.ReadLine());
           double mark3=Convert.ToDouble(Console.ReadLine());

           studentcall student=new studentcall(rno,name,mark1,mark2,mark3,0,0);
           student.Calculate();
           Console.WriteLine("Rollno " + student.Rno);
           Console.WriteLine("Name "+student.Name);
           Console.WriteLine("Total " + student.Total);
           Console.WriteLine("Average " + student.Avg);
        */


        /*
        Console.WriteLine("-----College-----");
        Console.WriteLine("Enter Collegename, address, pincode");
        string collegename=Console.ReadLine();
        string address=Console.ReadLine();
        int pincode=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("-----Teaching Staff-----");
        Console.WriteLine("Enter employeeid, name,department,favsubject, salary");
        int employeeid=Convert.ToInt32(Console.ReadLine());
        string name=Console.ReadLine();
        string department=Console.ReadLine();
        string favsubject=Console.ReadLine();
        double salary=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("-----Admin Staff-----");
        Console.WriteLine("Enter Employeeid,name, salary");
        int employeid=Convert.ToInt32(Console.ReadLine()) ;
        string namee=Console.ReadLine() ;
        double sal=Convert.ToDouble(Console.ReadLine()) ;

        TeachingStaff teachingstaff = new TeachingStaff(collegename, department, pincode, employeeid, name, favsubject, salary);

        adminstaff Admin = new adminstaff(collegename, address, pincode, employeid, namee, sal);
        double emp_sal = teachingstaff.calculatesalary();
        double admin_sal=Admin.calculatesalary();

        teachingstaff.calculatesalary();

        Admin.calculatesalary();

        Console.WriteLine("College Name :" + teachingstaff.Collegename);
        Console.WriteLine("Address :"+teachingstaff.Address);
        Console.WriteLine("Employee Name :" + teachingstaff.Name);
        Console.WriteLine("Teaching Staff Salary :" + emp_sal);
        Console.WriteLine("Admin ID :"+Admin.Employeeid);
        Console.WriteLine("Admin Name :"+Admin.Name);
        Console.WriteLine("Admin Salary :" +admin_sal);
        */

        // Console.WriteLine("Enter Two Numbers");
        //Addition addition = new Addition();
        //int Num1, Num2;
        //Num1=Convert.ToInt32(Console.ReadLine());
        //Num2=Convert.ToInt32(Console.ReadLine());
        //int answer= addition.add(Num1,Num2,out int Num3,out int Num4); 
        //Console.WriteLine(answer);
        //Console.WriteLine(Num1 + " " + Num2);

        // interest Interest = new interest(15, 12354, "abc", 45000, 100);
        //double int_amt = Interest.Calculate_interest();
        //Console.WriteLine(int_amt);
        /*
                Animal dog = new Animal("dog",2,1,4,1);
                Animal cow = new Animal("cow", 2, 1, 4, 1);
                Animal cat=new Animal("cat",2,1, 4, 1);

                cat.MakeSound(cat.AnimalName1);
                cow.Type(cow.AnimalName1);
                dog.Type(dog.AnimalName1);
                dog.MakeSound(dog.AnimalName1);
        */

        //BankAccount bank = new BankAccount(1234,"aaa",5454564545155,15000);
        //Console.WriteLine();



        //bank.checkaccstatus(bank.Accno);
        //bank.checkaccstatus(bank.Cusid);

        //  enumdemo enums=new enumdemo();
        // enums.Display();

        // exceptionhandling e=new exceptionhandling(10,1,5);
        // e.add();
        /*e.mul();
        e.div();
        e.checkval(5);*/
        //   Files files = new Files();
        // files.display();
        //files.copyfile();



        // Generic g = new Generic();
        // g.Listelements();

        // nongeneric g=new nongeneric();
        //g.arraylist();
        // jaggedarray j=new jaggedarray();
        //  j.LE();

        //  jaggedarray b=new jaggedarray(10,"fdad",45000,15);
        // b.Bank_method();

        /*
        
        Console.WriteLine("Enter the chicken counts");
        int chicken = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the cow counts");
        int cow = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the pig counts");
        int pig = Convert.ToInt32(Console.ReadLine());
        Animals animal1 = new Animals(chicken, cow, pig);
        Console.WriteLine(animal1.count_legs());


        Console.WriteLine("Enter the number of wins");
        int wins = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of draws");
        int draws = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the losses");
        int losses = Convert.ToInt32(Console.ReadLine());
        Football football = new Football();
        Console.WriteLine(football.FootballPoints(wins, draws, losses));


        Console.WriteLine("Enter the prob");
        double prob = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the prize");
        int prize = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the pay");
        int pay = Convert.ToInt32(Console.ReadLine());
        program p=new program();
        Console.WriteLine(p.Programs(prob, prize, pay));




        Console.WriteLine("Enter the number");
        int number = Convert.ToInt32(Console.ReadLine());
        Box box = new Box();
        Console.WriteLine("Number os stacked boxes : " + box.StackBoxes(number));


        Console.WriteLine("Enter the age");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the breaktime");
        bool breaktime = Convert.ToBoolean(Console.ReadLine());
        Bartender bartender = new Bartender();
        Console.WriteLine(bartender.ShouldServeDrinks(age, breaktime));



        Console.WriteLine("Enter the cup count");
        int cup = Convert.ToInt32(Console.ReadLine());
        Coffee coffee = new Coffee();
        Console.WriteLine("Total Number of cups : " + coffee.TotalCups(cup));

        
        
        AddingString adding = new AddingString();
        string[] temp = { "clever", "meek", "hurried", "nice" };
        adding.Addstring(temp, "ly");
        Console.WriteLine();


        Console.WriteLine("Enter the number of switches");
        int num = Convert.ToInt32(Console.ReadLine());
        Arrange arrange = new Arrange();
        Console.WriteLine(arrange.PosCom(num));



        */
        /*
                new_nothing n= new new_nothing();
                n.Name("Boo", 9);


                int choice;
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1.UIProject");
                Console.WriteLine("2.DBProject");
                choice=Convert.ToInt32(Console.ReadLine());
                switch (choice) {
                    case 1:
                        UIProject ui = new UIProject();
                        ui.Progress();
                        break;
                      case 2:
                        DBIProject dbi = new DBIProject();
                        dbi.Progress();
                        break;
                    default:
                        Console.WriteLine("Enter your correct choice");
                        break;

                }

        */

        // derivedclass d=new derivedclass();
        // d.display();

        /*
        Console.WriteLine("Enter your choice");
        Console.WriteLine("1. Savings Details");
        Console.WriteLine("2. Loan Details");
        int choice1;
        choice1 = Convert.ToInt32(Console.ReadLine());
        switch (choice1) {
            case 1:
        savings s = new savings(5250043452, "Boo");
        s.BankDetails();
                break;

                case 2:

        loan l = new loan(5485122412, 45000, 2576223, "Vinay");
        l.loandetails();
                break;
                default: Console.WriteLine("Enter correct choice");
                break;

    }
        */

        staticdemo s= new staticdemo();
        s.dis();
        Console.WriteLine("Total EB Bill Amount "+staticdemo.Amount);
    }
}
