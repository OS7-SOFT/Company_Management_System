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
using Company_Management_System.Views.Interface;

namespace Company_Management_System
{
    public partial class EmpView : UserControl, IEmpView
    {

        private string id;
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        EmpPresenter empPresenter;
        ManagementEmp manageEmp = new ManagementEmp();
        Show_emp_info show_Emp = new Show_emp_info();

        //Constructor
        public EmpView()
        {
            InitializeComponent();
            //size this UserControle
            this.Size = new Size(1580, 926);

            empPresenter = new EmpPresenter(this);
            //To perform Event
            perfomedEvents();

        }

        private void perfomedEvents()
        {
            //Search Employee
            btn_searchEmp.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txt_SearchEmp.TextChange += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txt_SearchEmp.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            //show employee info
            dgv_emp.DoubleClick += delegate
            {
                id = dgv_emp.CurrentRow.Cells[0].Value.ToString();
                ShowInfoEmployeeEvent?.Invoke(this, EventArgs.Empty);
                show_Emp.ShowDialog();
            };

            //close employee info 
            show_Emp.BtnClose.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                show_Emp.Close();
            };

            //Add Employee
            btn_addEmp.Click += delegate
            {
                AddEvent?.Invoke(this, EventArgs.Empty);
                manageEmp.ShowDialog();
            };

            //Edit Employee
            btn_editEmp.Click += delegate
            {
                id = dgv_emp.CurrentRow.Cells[0].Value.ToString();
                EditEvent?.Invoke(this, EventArgs.Empty);
                manageEmp.ShowDialog();

            };

            show_Emp.BtnEdit.Click += delegate
            {
                id = dgv_emp.CurrentRow.Cells[0].Value.ToString();
                EditEvent?.Invoke(this, EventArgs.Empty);
                manageEmp.ShowDialog();
                show_Emp.Close();
            };

            //Delete Employee
            btn_deleteEmp.Click += delegate
            {
                var result = MessageBox.Show($"Are you sure you want to delete ({dgv_emp.CurrentRow.Cells["name"].Value}) Employee?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    id = dgv_emp.CurrentRow.Cells[0].Value.ToString();
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(message, "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            show_Emp.BtnDelete.Click += delegate
            {
                var result = MessageBox.Show($"Are you sure you want to delete ({dgv_emp.CurrentRow.Cells["name"].Value}) Employee?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    id = dgv_emp.CurrentRow.Cells[0].Value.ToString();
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    show_Emp.Close();
                    MessageBox.Show(message, "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            //Save 
            manageEmp.btnSave.Click += delegate
            {

                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    manageEmp.Close();
                    string title = isEdit != true ? "Add Employee" : "Edit Employee";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(message, "Error in input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            //Cancel
            manageEmp.btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                manageEmp.Close();
            };

        }


        //Properties
        public string Id 
        {
            get { return id; }
            set { show_Emp.Id.Text = value; }
        }
        public string empName
        {
            get { return manageEmp.empName.Text; }
            set
            {
                manageEmp.empName.Text = value;
                show_Emp.empName.Text = value;
            }
        }
        public int Age
        {
            get { return (int)manageEmp.Age.Value; }
            set
            {
                manageEmp.Age.Value = Convert.ToDecimal(value);
                show_Emp.Age.Text = value.ToString();
            }
        }
        public bool Male
        {
            get { return manageEmp.Male.Checked; }
            set
            {
                manageEmp.Male.Checked = value;
                manageEmp.Female.Checked = !value;
                show_Emp.Gender.Text = value ? "Male" : "Female";
            }
        }
        public byte[] Photo
        {
            get { return manageEmp.GetPhoto(); }
            set
            {
                manageEmp.SetImage(value);
                show_Emp.SetImage(value);
            }
        }
        public double Phone
        {
            get { return (double)manageEmp.Phone.Value; }
            set
            {
                manageEmp.Phone.Value = Convert.ToDecimal(value);
                show_Emp.Phone.Text = value.ToString();
            }
        }
        public string Email
        {
            get { return manageEmp.Email.Text; }
            set
            {
                manageEmp.Email.Text = value;
                show_Emp.Email.Text = value;
            }
        }
        public string Address
        {
            get { return manageEmp.Address.Text; }
            set
            {
                manageEmp.Address.Text = value;
                show_Emp.Address.Text = value;
            }
        }
        public string JopTitl
        {
            get { return manageEmp.JopTitl.Text; }
            set
            {
                manageEmp.JopTitl.Text = value;
                show_Emp.JopTitle.Text = value;
            }
        }
        public double Salary
        {
            get { return (double)manageEmp.Salary.Value; }
            set
            {
                manageEmp.Salary.Value = Convert.ToDecimal(value);
                show_Emp.Salary.Text = "$" + value.ToString();
            }
        }
        public int DepNo
        {
            get { return (int)manageEmp.DepNo.Value; }
            set { manageEmp.DepNo.Value = Convert.ToDecimal(value);}
            
        }
        public string DepName
        {
            get { return null; }
            set { show_Emp.DepName.Text = value; }
        }
        public string EmpCount
        {
            get { return null; }
            set { lbl_empCount.Text = value; }
        }
        public string EmpCountMale
        {
            get { return null; }
            set { lbl_empMaleCount.Text = value; }
        }
        public string EmpCountFemale
        {
            get { return null; }
            set { lbl_empFemalCount.Text = value; }
        }

        public int TotalSalaries
        {
            get { return 0; }
            set 
            {
                lbl_salaryMonth.Text = "$ " + value;
                lbl_salaryDay.Text = "$ " + value/30;
                lbl_salaryYear.Text = "$ " + value * 12;
            }
        }
        public string SearchValue
        {
            get { return txt_SearchEmp.Text; }
            set { txt_SearchEmp.Text = value;}
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

        //events
        public event EventHandler SearchEvent;
        public event EventHandler AddEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler ShowInfoEmployeeEvent;


        //Method load data in datagridview
        public void SetDataEmployee(BindingSource empList)
        {
            dgv_emp.DataSource = empList;
        }


        //Singelton Pattren 
        private static EmpView Object = null;
        public static EmpView Instance()
        {
            if(Object == null)
                Object = new EmpView();
            return Object;
        }
    }
}
