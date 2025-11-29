using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chhipa_Motors.DTO;

namespace Chhipa_Motors.DL
{
    public class BookingDL
    {
        DBConnection _dbCon;
        public BookingDL() { 
            _dbCon = new DBConnection();
        }
    }
}
