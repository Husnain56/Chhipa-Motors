using Chhipa_Motors.DTO;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Chhipa_Motors.DL
{   
    public class CustomerDL
    {
        private DBConnection _dbCon;
        public CustomerDL()
        {
            _dbCon = new DBConnection();
        }

        public DataTable FetchBookings(UserDTO userDTO)
        {
            try
            {
                _dbCon.OpenConnection();
               string query = "SELECT Bookings.BookingID, Bookings.CarID, Cars.CarName, Cars.Manufacturer, Bookings.BookingDate, Bookings.Status, Bookings.UpdatedAt, Bookings.AdminNote FROM Bookings " +
                    "INNER JOIN Cars ON Bookings.CarID = Cars.CarID WHERE Bookings.UserID = @UserID ORDER BY Bookings.BookingDate DESC;";

                SqlCommand com = new SqlCommand(query, _dbCon.Con);
                com.Parameters.AddWithValue("@UserID", userDTO.Id);
                SqlDataReader reader = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
            catch (Exception ex) {
                throw ex;
            }
            finally
            {
                _dbCon.CloseConnection();
            }
        }
        public DataTable FetchPurchasedCars(UserDTO userDTO)
        {
            try
            {
                _dbCon.OpenConnection();
                string query = "SELECT Sales.SaleID, Sales.CarID, Cars.CarName, Cars.Manufacturer, Sales.SaleDate, Sales.TotalAmount FROM Sales " +
                    "INNER JOIN Cars ON Sales.CarID = Cars.CarID WHERE Sales.UserID = @UserID ORDER BY Sales.SaleDate DESC;";

                SqlCommand com = new SqlCommand(query, _dbCon.Con);
                com.Parameters.AddWithValue("@UserID", userDTO.Id);
                SqlDataReader reader = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _dbCon.CloseConnection();
            }
        }
    }
}
