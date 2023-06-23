using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Management_System.Logic.Servics
{
    public static class LoginServices
    {
        public static DataTable GetAllAccount()
        {
            return Database.GetAllData("Get_all_accounts");
        }
    }
}
