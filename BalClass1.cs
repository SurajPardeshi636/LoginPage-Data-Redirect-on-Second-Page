using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modal;
using Dal;
using System.Data;

namespace Bal
{
    
    public class BalClass1
    {
        DalClass1d dal = new DalClass1d();

        public bool LoginDeatils(int UserId, string Passwords)
        {
          return  dal.LoginDeatils(UserId, Passwords);
        }
      
    }
}
