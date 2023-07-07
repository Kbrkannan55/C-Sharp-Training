using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprgm1
{
    internal class adminstaff:College
    {
        private int employeeid;
        private string name;
        private double salary;

        public adminstaff(string collegename, string address, int pincode,int employeeid,string name,double salary) : base(collegename, address, pincode)
        {
            this.employeeid = employeeid;
            this.name = name;   
            this.salary = salary;

        }


        public int Employeeid { get => employeeid; set => employeeid = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }

        public double calculatesalary()
        {
            double da = 0.3;
            double hra = 0.15;
            double allowances = (salary * da) + (salary * hra);
            double pf = 0.2;
            double deductions = salary * pf;
            double netsalary = salary + allowances - deductions;
            return netsalary;
        }
    }
}
