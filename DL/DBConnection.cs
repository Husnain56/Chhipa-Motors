using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chhipa_Motors.DL
{
    public class DBConnection
    {
        private SqlConnection con;

        public DBConnection()
        {
            string conString = ConfigurationManager.ConnectionStrings["ChhipaMotorsDB"].ConnectionString;

            con = new SqlConnection(conString);
        }
    }
}
