using DataBaseTrialConnection;
using System.Data.SqlClient;
using System.Text;

namespace Program
{
    internal class Assessment {
        public static void Main(string[] args)
        {
            /*
            StringBuilder sb= new StringBuilder("insert command");
            Console.WriteLine("Data Source");
            sb.Append(Console.ReadLine());
            */
            DB d=new DB();
            d.openconn();
            d.readtable();
           
        }
    }
}