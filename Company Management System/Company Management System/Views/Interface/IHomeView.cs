using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company_Management_System.Views.Interface
{
    public interface IHomeView
    {

        //Fildes
        string UserName { get;  }
        string Password { get; }   
        string ConfirmPassword { get; }   
        string EmpCount {  set; }
        string RepCount { set; }
        string TotalProj {  set; }
        string InProgress {  set; }
        string Done {  set; }
        string Profite {  set; }

        //Properties
        bool IsSuccessful { get; set; }
        string Message { get; set; }


        //Events
        event EventHandler CreateEvent;

        //Method
        void SetLastProjects(BindingSource listProjects);
        void SetLastReports(BindingSource listReports);
    }
}
