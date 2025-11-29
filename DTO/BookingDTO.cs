using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chhipa_Motors.DTO
{
    public class BookingDTO
    {
        public int BookingID { get; set; }
        public int UserID { get; set; }
        public int CarID { get; set; }
        public string Status { get; set; }
        public string AdminNote { get; set; }
    }
}
