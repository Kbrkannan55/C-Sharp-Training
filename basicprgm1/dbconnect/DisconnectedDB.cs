using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbconnect
{
    internal class DisconnectedDB
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;

        public SqlConnection Conn { get => conn; set => conn = value; }
        public SqlDataAdapter Da { get => da; set => da = value; }
        public DataSet Ds { get => ds; set => ds = value; }

        conn= new SqlConnection(str);
            try
            {
                conn.Open();
                Console.WriteLine("Opened");
            }
            catch (SqlException ex)
            {
                
                Console.WriteLine("Connection not established");
            }
        
        public void createtable()
{

    SqlCommand cmd = new SqlCommand("Create table stud_detials(rno int, sname nvarchar(25))", conn);
    if (conn != null)
    {
        cmd.ExecuteNonQuery();
        Console.WriteLine("Table Created");
    }

}

public void inserttable()
{
    SqlCommand cmd = new SqlCommand("insert into stud_detials values(1002, 'Abinaya'),(1002, 'Abinaya'), (1002, 'Abinaya'),(1002, 'Abinaya')", conn);

    if (conn != null)
    {
        cmd.ExecuteNonQuery();
        Console.WriteLine("Row Inserted");
    }
}

public void updatetable()
{
    SqlCommand cmd = new SqlCommand("update stud_detials set sname='anu' where rno=1002", conn);
    if (conn != null)
    {
        cmd.ExecuteNonQuery();
        Console.WriteLine("Row Updated");
    }
}

public void readtable()
{
    SqlCommand cmd = new SqlCommand("select * from stud_detials", conn);
    if (conn != null)
    {
        SqlDataReader s = cmd.ExecuteReader();
        while (s.Read())
        {
            Console.WriteLine(s[0] + " " + s[1]);
        }

public void closeconn()
{
    if (conn != null)
    {
        conn.Close();
    }
}



 