using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbconnect
{
    internal class DB
    {
        SqlConnection conn;
        public void openconn(string str)
        {

           // conn = new SqlConnection("data source=KBRKANNAN\\SQLEXPRESS;" +
            //"database=student;" +
            //"integrated security=SSPI");
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
            }
        }

        public void closeconn()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
