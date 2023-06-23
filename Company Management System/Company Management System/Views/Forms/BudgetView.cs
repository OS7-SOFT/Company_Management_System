using Company_Management_System.Views.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Bunifu.Charts.WinForms;
using Bunifu.Dataviz.WinForms;
using Company_Management_System.Logic.Presenter;
using Company_Management_System.Views.Forms;

namespace Company_Management_System
{
    public partial  class budgetView : UserControl,IBudgetView
    {

        private string message;
        private bool isEdit;

        static BudgetPresenter budgetPresenter;
        ManagementBudgt manageBudget = new ManagementBudgt();

        //Constructor
        public budgetView()
        {
            InitializeComponent();
            //Size Window when program running
            this.Size = new Size(1580, 926);

            budgetPresenter = new BudgetPresenter(this);
            //performEvent
            performEvent();
        }

        private void performEvent()
        {
            btn_addBudget.Click += delegate 
            {
                AddBudgetEvent?.Invoke(this, EventArgs.Empty);
                manageBudget.ShowDialog();
            };

            btn_editBudget.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                manageBudget.ShowDialog();
            };

            manageBudget.Save.Click += delegate 
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                string title = isEdit ? "Edit Capital" : "Add Capital";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                manageBudget.Close();
            };

            manageBudget.Cancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                manageBudget.Close();
            };
        }

        //Fildes
        public string LblCapital 
        {
            get { return null; }
            set { lbl_capital.Text = "$ " + value; }
        }
        public string Capital
        {
            get { return manageBudget.Capital.Value.ToString(); }
            set { manageBudget.Capital.Value = Convert.ToDecimal(value); }
        }
        public string CurrentBudget  
        {
            get { return null; }
            set { lbl_currentBudget.Text = "$ " + value; }
        }
        public string TotalProjCost
        {
            get { return null; }
            set { lbl_totalProjCosts.Text = "$ " + value; }
        }
        public string TotalProjLosses 
        {
            get { return null; }
            set { lbl_totalProjLosses.Text = "$ " + value; }
        }
        public string TotalProjProfits 
        {
            get { return null; }
            set { lbl_totalProjProfit.Text = "$ " + value; }
        }
        public string TotalEmpSalaries 
        {
            get { return null; }
            set { lbl_totalSalaries.Text = "$ " + value; }
        }

        //Propertes
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }

        //Event
        public event EventHandler AddBudgetEvent;
        public event EventHandler EditEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Method
        public void SetDepartmentInfo(BindingSource depInfolist)
        {
            dgv_dep.DataSource = depInfolist;
        }
   
        //Load All Data when  usercontrol opened
        public static void GetAllData()
        {
            budgetPresenter.LoadAllStatistics();
        }

        //Singelton Pattren 
        private static budgetView Object = null;
        public static budgetView Instance()
        {
            if (Object == null)
                Object = new budgetView();
            return Object;
        }

        
    }
}
