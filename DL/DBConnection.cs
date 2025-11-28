using Microsoft.Data.SqlClient;
using System;
using System.Configuration;

namespace Chhipa_Motors.DL
{
    public class DBConnection
    {
        private SqlConnection con;

        public DBConnection()
        {
           // string conString = ConfigurationManager.ConnectionStrings["Chhipa_DB"].ConnectionString;

            // Option 2: If you want to hardcode (not recommended)
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Chhipa Motors\Chhipa Motors\Chhipa Motors\ChhipaMotors.mdf;Integrated Security=True";

            con = new SqlConnection(conString);
        }

        public SqlConnection Con { get => con; }

        // Add proper connection handling methods
        public void OpenConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}