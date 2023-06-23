using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Company_Management_System.Views.Interface
{
    public interface IBudgetView
    {
        //Fileds
        string LblCapital { get; set; }
        string Capital { get; set; }
        string CurrentBudget { get; set; }
        string TotalProjCost { get; set; }
        string TotalProjLosses { get; set; }
        string TotalProjProfits { get; set; }
        string TotalEmpSalaries { get; set; }

        //Propertes
        string Message { get; set; }
        bool IsEdit { get; set; }

        //Event
        event EventHandler AddBudgetEvent;
        event EventHandler EditEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;


        //Method 
        void SetDepartmentInfo(BindingSource depInfolist);
    }
}
