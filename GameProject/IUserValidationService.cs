using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IUserValidationService  //kullanıcı dogrulama servisi
    {
        bool Validate(Gamer gamer);    // bool turunde yaptık çünkü true false kontrolu yapmak istiyorum
    }
}
