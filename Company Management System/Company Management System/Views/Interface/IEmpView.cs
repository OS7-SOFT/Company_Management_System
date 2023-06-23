using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company_Management_System.Views.Interface
{
    public interface IEmpView
    {
        //Fildes

        string Id { get; set; }
        string empName { get; set; }
        int Age { get; set; }
        bool Male { get; set; }
        byte[] Photo { get; set; }
        double Phone { get; set; }
        string Email { get; set; }
        string Address { get; set; }
        string JopTitl { get; set; }
        double Salary { get; set; }
        int DepNo { get; set; }
        string DepName { get; set; }
        string EmpCount { get; set; }
        string EmpCountMale { get; set; }
        string EmpCountFemale { get; set; }
        int TotalSalaries { get; set; }

        //Propertes
        string SearchValue { get; set; }
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
        event EventHandler ShowInfoEmployeeEvent;

        //Void
        void SetDataEmployee(BindingSource empList);




    }
}
