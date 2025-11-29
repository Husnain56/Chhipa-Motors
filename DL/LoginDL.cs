using Chhipa_Motors.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chhipa_Motors.DL
{
    public class LoginDL
    {
        private DBConnection _dbCon;
        public LoginDL() {
            _dbCon = new DBConnection();
        }
        public bool VerifyUser(UserDTO userDTO)
        {
            try
            {   
                _dbCon.OpenConnection();
                string query = "SELECT UserID FROM Users WHERE Username = @username AND Password = @password AND Role = @Role";
                SqlCommand com = new SqlCommand(query, _dbCon.Con);
                com.Parameters.AddWithValue("@Username", userDTO.Username);
                com.Parameters.AddWithValue("@Password", userDTO.Password);
                com.Parameters.AddWithValue("@Role", userDTO.Role);

                SqlDataReader reader = com.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An Error Occured while retrieving user info", ex);
            }
            finally
            {
                _dbCon.CloseConnection();
            }
        }
        public int CreateNewUser(UserDTO userDTO)
        {
            try
            {
                _dbCon.OpenConnection();
                string query = "INSERT INTO USERS(Username,Password,Role) Values (@Username,@Password,@Role)";

                SqlCommand com = new SqlCommand(query, _dbCon.Con);
                com.Parameters.AddWithValue("@Username", userDTO.Username);
                com.Parameters.AddWithValue("@Password", userDTO.Password);
                com.Parameters.AddWithValue("@Role", userDTO.Role);

                int rowAffected = com.ExecuteNonQuery();
                return rowAffected;

            }
            catch (Exception ex)
            {
                throw new Exception("An Error Occured while creating new user account", ex);
            }
            finally
            {
                _dbCon.CloseConnection();
            }
        }
    }
}
