using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprgm1
{
    internal class TeachingStaff:College
    {
        private int employeeid;
        private string name, dept, favsubject;
        private double salary;


        public TeachingStaff(string collegename, string dept, int pincode, int employeeid,string name, string favsub,double salary) : base(collegename,dept,pincode)
        {
            Employeeid = employeeid;
            Name = name;
            
            Favsubject = favsubject;
            Salary = salary;
            Employeeid = employeeid;
            Name = name;
            Dept = dept;
            Favsubject = favsubject;
            Salary = salary;
        }
    
        public int Employeeid { get => employeeid; set => employeeid = value; }
        public string Name { get => name; set => name = value; }
        public string Dept { get => dept; set => dept= value; }
        public string Favsubject { get => favsubject; set => favsubject = value; }
        public double Salary { get => salary; set => salary = value; }

        public double calculatesalary()
        {
            double da = 0.4;
            double hra = 0.2;
            double allowances = (salary*da) + (salary*hra);
            double pf = 0.25;
            double deductions = salary * pf;
            double netsalary = salary + allowances - deductions;
            return netsalary;
        }
    }
}
