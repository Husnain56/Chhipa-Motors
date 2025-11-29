using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chhipa_Motors.DL;
using Chhipa_Motors.DTO;

namespace Chhipa_Motors.BL
{
    public class CustomerBL
    {
        private CustomerDL _customerDL;

        public CustomerBL()
        {
            _customerDL = new CustomerDL();
        }

        public DataTable fetchBookings(UserDTO userDTO)
        {
            return _customerDL.FetchBookings(userDTO);
        }
        public DataTable fetchPurchasedCars(UserDTO userDTO)
        {
            return _customerDL.FetchPurchasedCars(userDTO);
        }
    }
}
