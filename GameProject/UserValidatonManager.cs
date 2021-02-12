using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidatonManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear== 1985 && gamer.FirstName=="BEYZA"&&gamer.LastName=="BUYUKMANTICI"&& gamer.IdentityNumber==123456)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
