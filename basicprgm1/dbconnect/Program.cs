using System;
using System.Diagnostics;
using System.Data.SqlClient;
using dbconnect;
using System.Text;

class Program
{

    public static void Main(string[] args)
    {
        DB db = new DB();
        StringBuilder cnnstr = new StringBuilder();
        Console.WriteLine("Data Source");
        cnnstr.Append(Console.ReadLine());
        Console.WriteLine(";Initial Catlog = ");
        cnnstr.Append(Console.ReadLine());
        Console.WriteLine("Enter Database Name");
        cnnstr.Append(Console.ReadLine());
        db.openconn(cnnstr);
        //db.inserttable();
        // db.updatetable();
        db.readtable();
        db.closeconn();
    }
}