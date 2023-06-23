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
using Company_Management_System.Logic.Presenter;
using Company_Management_System.Views.Forms;
using Company_Management_System.Views.Interface;

namespace Company_Management_System
{
    public partial  class DepView : UserControl,IDepView
    {
        private string id;
        private string message;
        private bool isSuccessful = true;
        private bool isEdit;

        ManagementDep ManageDep = new ManagementDep();
        ShowDepInfo showDep = new ShowDepInfo();
        static DepPresenter depPresenter;

        //Constructor
        public DepView()
        {
            InitializeComponent();
            /////////Size Window when program running//////////
            this.Size = new Size(1580, 926);

            depPresenter = new DepPresenter(this);

            perfomedEvents();
            
        }

        private void perfomedEvents()
        {
            //Search Department
            btn_searchDep.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txt_searchDep.TextChange += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txt_searchDep.KeyDown += (sawd, e) =>{
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            //Show Department Info
            dgv_dep.DoubleClick += delegate 
            {
                id = dgv_dep.CurrentRow.Cells[0].Value.ToString();
                ShowDepInfoEvent?.Invoke(this, EventArgs.Empty);
                showDep.ShowDialog(); 
            };

            //Close Department Info
            showDep.BtnClose.Click += delegate
            { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
                showDep.Close();
            };

            //Search staff in Department
            showDep.BtnSearchStaff.Click += delegate { SearchStaffAndProjectEvent?.Invoke(this, EventArgs.Empty); };
            showDep.txtSearchStaff.TextChange += delegate { SearchStaffAndProjectEvent?.Invoke(this, EventArgs.Empty); };
            showDep.txtSearchStaff.KeyDown += (sawd, e) =>{
                if (e.KeyCode == Keys.Enter)
                    SearchStaffAndProjectEvent?.Invoke(this, EventArgs.Empty);
            };

            //Search project in Department
            showDep.BtnSearchProj.Click += delegate { SearchStaffAndProjectEvent?.Invoke(this, EventArgs.Empty); };
            showDep.txtSearchProj.TextChange += delegate { SearchStaffAndProjectEvent?.Invoke(this, EventArgs.Empty); };
            showDep.txtSearchProj.KeyDown += (sawd, e) =>{
                if (e.KeyCode == Keys.Enter)
                    SearchStaffAndProjectEvent?.Invoke(this, EventArgs.Empty);
            };

            //Add Department
            btn_addDep.Click += delegate
            {
                AddEvent?.Invoke(this, EventArgs.Empty);
                ManageDep.ShowDialog();
            };

            //Edit Department
            btn_editDep.Click += delegate
            {
                id = dgv_dep.CurrentRow.Cells[0].Value.ToString();
                EditEvent?.Invoke(this, EventArgs.Empty);
                ManageDep.ShowDialog();

            };

            //Delete Department
            btn_deleteDep.Click += delegate
            {
                var result = MessageBox.Show($"Are you sure you want to delete ({dgv_dep.CurrentRow.Cells[1].Value}) Department?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    id = dgv_dep.CurrentRow.Cells[0].Value.ToString();
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(message, "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            //Save 
            ManageDep.Save.Click += delegate
            {

                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    string title = isEdit != true ? "Add Department" : "Edit Department";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ManageDep.Close();
                }
                else
                    MessageBox.Show(message, "Error in input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            //Cancel
            ManageDep.Cancel.Click += delegate
            {

                CancelEvent?.Invoke(this, EventArgs.Empty);
                ManageDep.Close();
            };

        }


        //Propertes
        public string DepNo
        {
            get { return id; }
            set { showDep.DepNo.Text = value; }
        }
        public string DepName
        {
            get { return ManageDep.DepName.Text; }
            set 
            {
                ManageDep.DepName.Text = value;
                showDep.DepName.Text=value;
            }
        }
        public string ManagerID
        {
            get { return ManageDep.ManagerID.Value.ToString(); }
            set 
            {
              
                if(int.TryParse(value,out int result))
                    ManageDep.ManagerID.Value = Convert.ToDecimal(value);
                showDep.Manager.Text = value;
            }
        }
        public string Budget
        {
            get { return ManageDep.Budget.Value.ToString(); }
            set
            {
                ManageDep.Budget.Value = Convert.ToDecimal(value);
                showDep.DepBudget.Text = value;
            }
        }
        public string CurrentBudget
        {
            get { return null; }
            set { showDep.CurrentBudget.Text = value; }
        }
        public string EmpCount
        {
            get { return null; }
            set { showDep.EmpCount.Text = value; }
        }
        public string ProjCount
        {
            get { return null; }
            set { showDep.ProjCount.Text = value; }
        }
        public string Profit
        {
            get { return null; }
            set { showDep.Profit.Text = value; }
        }
        public string Losses
        {
            get { return null; }
            set { showDep.Losses.Text = value; }
        }

        public string DepCount
        {
            get { return null; }
            set { lbl_DepCount.Text =  value; }
        }

        public string LblTotalbudget
        {
            get { return null; }
            set { lbl_totalBudget.Text = "$ " + value; }
        }
        public string LblTotalCurrentbudget
        {
            get { return null; }
            set { lbl_totalCurrentBudget.Text = "$ " + value; }
        }
        public string TotalProjCost
        {
            get { return null; }
            set { showDep.TotalProjCost.Text = value; }
        }
        public string TotalSalaries
        {
            get { return null; }
            set { showDep.TotalSalaries.Text = value; }
        }
        public string SearchValue
        {
            get { return txt_searchDep.Text; }
            set { txt_searchDep.Text = value; }
        }
        public string SearchStaffValue
        {
            get { return showDep.txtSearchStaff.Text; }
            set { showDep.txtSearchStaff.Text = value; }
        }
        public string SearchProjValue
        {
            get { return showDep.txtSearchProj.Text; }
            set { showDep.txtSearchProj.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }




        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler ShowDepInfoEvent;
        public event EventHandler SearchStaffAndProjectEvent;

        //Methodes
        public void SetDataDepartment(BindingSource deplist)
        {
            dgv_dep.DataSource = deplist;
        }

        public void SetDepartmentStaff(BindingSource staffList) 
        {
            showDep.DgvStaff.DataSource = staffList;
        }

        public void SetDepartmentProj(BindingSource ProjList)
        {
            showDep.DgvProj.DataSource = ProjList;
        }

        //Load Data when open this usercontrol
        public static void GetAllData()
        {
            depPresenter.loadDepartmentData();
        }

        //Singelton Pattren 
        private static DepView Object = null;
        public static DepView Instance()
        {
            if (Object == null)
                Object = new DepView();
            return Object;
        }

        
    }
}
