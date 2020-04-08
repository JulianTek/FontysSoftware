using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMockup.Data
{
    public class DatabaseManager
    {
        string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CashMockup;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public void login(int cashierID, string password)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand login = new SqlCommand("login");
                login.CommandType = CommandType.StoredProcedure;
                login.Parameters.AddWithValue("@CashierID", cashierID);
                login.Parameters.AddWithValue("@pwd", password);
                SqlParameter oblogin = new SqlParameter();
                oblogin.ParameterName = "isValid";
                oblogin.SqlDbType = SqlDbType.Bit;
                oblogin.Direction = ParameterDirection.Output;
                login.Parameters.Add(oblogin);
                
                sqlConnection.Open();
                login.ExecuteNonQuery();
                int result = Convert.ToInt32(oblogin.Value);

                if (result == 1)
                {
                    // Login Succesvol
                }
                else
                {
                    // Login Niet succesvol
                }
            }
        }
    }
}
