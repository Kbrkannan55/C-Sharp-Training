using System.Data.SqlClient;

namespace AdoAssessment
{
    internal class DbCon
    {
        public SqlConnection conn;


        public void openconn()
        {

            conn = new SqlConnection("data source=KBRKANNAN\\SQLEXPRESS;" +
            "database=adoassessment;" +
            "integrated security=SSPI;");
            

            try
            {
                conn.Open();
               // Console.WriteLine("Opened");
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Connection not established");
            }
        }
    }
}
