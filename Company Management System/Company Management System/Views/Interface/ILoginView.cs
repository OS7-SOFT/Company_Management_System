using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Management_System.Views.Interface
{
    public interface ILoginView
    {
        //Fildes
        string UserName { get;  }
        string Password { get; }

        //Properties
        bool IsLogged { get; set; }
        string Message { get; set; }


        //Event
        event EventHandler Login;

        

    }
}
