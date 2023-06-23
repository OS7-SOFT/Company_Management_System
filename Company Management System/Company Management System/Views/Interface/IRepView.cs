using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company_Management_System.Views.Interface
{
    public interface IRepView
    {

        //Fildes
        string Id { get;}
        string Title { get; set; }
        string Content { get; set; }
        string Date { get; set; }
        string ReportCount { get; set; }

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
        event EventHandler ShowReportContent;

        //Void
        void SetDataReports(BindingSource reportList);
    }
}
