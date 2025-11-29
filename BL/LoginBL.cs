using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chhipa_Motors.DL;
using Chhipa_Motors.DTO;

namespace Chhipa_Motors.BL
{
    public class LoginBL
    {
        LoginDL _loginDl;
        public LoginBL() { 
            _loginDl = new LoginDL();   
        }

        public bool VerifyUser(UserDTO userDTO)
        {
            return _loginDl.VerifyUser(userDTO);
        }

        public int CreateUserAccount(UserDTO userDTO)
        {
            return _loginDl.CreateNewUser(userDTO);
        }
    }
}
