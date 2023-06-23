using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company_Management_System.Views.Interface
{
    public interface IDepView
    {
        //Fildes
        string DepNo { get; set; }
        string DepName { get; set; }
        string ManagerID { get; set; }
        string Budget { get; set; }
        string CurrentBudget { get; set; }
        string EmpCount { get; set; }
        string ProjCount { get; set; }
        string Profit { get; set; }
        string Losses { get; set; }
        string DepCount { get; set; }
        string LblTotalbudget { get; set; }
        string LblTotalCurrentbudget { get; set; }
        string TotalProjCost { get; set; }
        string TotalSalaries { get; set; }  

        //Propertes
        string SearchValue { get; set; }
        string SearchStaffValue { get; set; }
        string SearchProjValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler ShowDepInfoEvent;
        event EventHandler SearchStaffAndProjectEvent;
        //Void
        void SetDataDepartment(BindingSource deplist);
        void SetDepartmentStaff(BindingSource stafflist);
        void SetDepartmentProj(BindingSource Projlist);
    }
}
