using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Company_Management_System.Logic.Presenter;
using Company_Management_System.Views.Forms;
using Company_Management_System.Views.Interface;
using MaterialSkin.Controls;

namespace Company_Management_System
{
    public partial class Home_window : UserControl, IHomeView
    {
        bool isSuccessful;
        string message;


        NewAccount accountForm = new NewAccount();

        HomePresenter homePresenter;

        public Home_window()
        {
            InitializeComponent();

            this.Size = new Size(1580, 926);

            homePresenter = new HomePresenter(this);

            GetData();
            craeteNewAccount();
        }


        void GetData()
        {
            timer.Tick += delegate
            {

                time.Text = DateTime.Now.ToString("T");
                date.Text = DateTime.Now.ToString("D");
            };
        }

        void craeteNewAccount()
        {
            //open form
            btn_createAccount.Click += delegate
            {
                accountForm.ShowDialog();
            };

            //close form
            accountForm.BtnCancel.Click += delegate
            {
                accountForm.Close();

            };

            //Create Account
            accountForm.BtnSave.Click += delegate
            {
                CreateEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    accountForm.Close();
                    MessageBox.Show(message, "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(message, "Error in input", MessageBoxButtons.OK, MessageBoxIcon.Error);

            };
        }

        //Propertes
        public string EmpCount
        {
            set { lbl_EmpCount.Text = value; }
        }
        public string RepCount
        {
            set { lbl_repCount.Text = value; }
        }
        public string TotalProj
        {
            set { lbl_projTotal.Text = value; }
        }
        public string InProgress
        {
            set { lbl_inProgress.Text = value; }
        }
        public string Done
        {
            set { lbl_projDone.Text = value; }
        }
        public string Profite
        {
            set { lbl_projProfits.Text = value; }
        }
        public string UserName
        {
            get { return accountForm.UserName.Text; }

        }
        public string Password { get { return accountForm.Password.Text; } }
        public string ConfirmPassword { get { return accountForm.confirmPassword.Text; } }
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

        //Event
        public event EventHandler CreateEvent;

        //Method
        public void SetLastProjects(BindingSource listProjects)
        {
            dgv_lastProj.DataSource = listProjects;
        }

        public void SetLastReports(BindingSource listReports)
        {
            dgv_lastReport.DataSource = listReports;
        }


        //Singelton Pattren 
        private static Home_window Object = null;



        public static Home_window Instance()
        {
            if (Object == null)
                Object = new Home_window();
            return Object;
        }

    }
}
