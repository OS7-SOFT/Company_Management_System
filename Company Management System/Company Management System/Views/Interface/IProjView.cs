using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company_Management_System.Views.Interface
{
    public interface IProjView
    {
        //Fildes
        string Id { get; set; }
        string ProjName { get; set; }
        byte[] ProjImage { get; set; }
        bool ProjStatus { get; set; }
        string ProjDate { get; set; }
        string ProjStartDate { get; set; }
        double WorkDuration { get; set; }
        string DepNo { get; set; }
        string ProjCost { get; set; }
        string ProjRevenues { get; set; }
        string ProjProfits { get; set; }
        string ProjLosses { get; set; }
        string ProjDetails { get; set; }

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
        event EventHandler ShowProjInfoEvent;
        event EventHandler ProjectComplete;
        event EventHandler ExtendProjectTime;


        //Void
        void SetDataProject(BindingSource projlist);

    }
}
