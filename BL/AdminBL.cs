using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chhipa_Motors.DTO;
using Chhipa_Motors.DL;
using System.Data;

namespace Chhipa_Motors.BL
{
    public class AdminBL
    {
        private AdminDL _adminDL;
        public AdminBL() {
            _adminDL = new AdminDL();
        }

        public int CreateAdmin(DTO.UserDTO userDTO)
        {
           return _adminDL.CreateAdmin(userDTO);
        }

        public DataTable getAdmins()
        {
            return _adminDL.GetAdmins();
        }

        public DataTable getUsers()
        {
            return _adminDL.GetUsers();
        }
        public DataTable getCustomers()
        {
            return _adminDL.GetCustomers();
        }
        public int DeleteUser(UserDTO _udto)
        {
            return _adminDL.DeleteUser(_udto);
        }
        public DataTable GetAllCars()
        {
            return _adminDL.GetAllCars();
        }
        public int updateCarPrice(CarDTO _carDTO)
        {
            return _adminDL.updateCarPrice(_carDTO);
        }
        public int updateCarStock(CarDTO _carDTO)
        {
            return _adminDL.updateCarStock(_carDTO);
        }
        public int changeCarStatus(CarDTO _carDTO)
        {
            return _adminDL.changeCarStatus(_carDTO);
        }
        public DataTable GetBookedCars()
        {
            return _adminDL.getBookedCars();
        }
        public int updateBookingStatus(BookingDTO _bookingDTO)
        {
            return _adminDL.updateBookingStatus(_bookingDTO);
        }
    }
}
