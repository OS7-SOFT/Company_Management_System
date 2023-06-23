using Company_Management_System.Logic.Servics;
using Company_Management_System.Model;
using Company_Management_System.Views.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company_Management_System.Logic.Presenter
{
    public class HomePresenter
    {
        IHomeView view;
        HomeModel model = new HomeModel();
        BindingSource lastprojects;
        BindingSource lastReport;

        public HomePresenter(IHomeView view)
        {
            this.lastprojects = new BindingSource();
            this.lastReport = new BindingSource();
            this.view = view;
            this.view.CreateEvent += CreateNewAccount;
            this.view = view;
            //to load all data 
            loadAllData();
            this.view.SetLastProjects(this.lastprojects);
            this.view.SetLastReports(this.lastReport);
        }


        //method to connect Model with View
        private void ConnectionInterfaceAndModel()
        {
            model.UserName = view.UserName;
            model.Password = view.Password;

        }

        //Load all Data
        private void loadAllData()
        { 
            view.RepCount = HomeServices.GetRepCount().ToString();
            view.EmpCount = HomeServices.GetEmpCount().ToString();
            view.TotalProj = HomeServices.GetTotalProject().ToString();
            view.Done = HomeServices.GetProjectDone().ToString();
            view.InProgress = HomeServices.GetProjectInProgress().ToString();
            view.Profite = HomeServices.GetPorfit().ToString();

            //Get last Project and Reports
            lastprojects.DataSource =  HomeServices.GetLastProjects();
            lastReport.DataSource = HomeServices.GetLastReports();
        }

        //Create New Account
        private void CreateNewAccount(object sender, EventArgs e)
        {
            ConnectionInterfaceAndModel();
            if (CheckInput())
            {
                //Encoded Passowrd
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(model.Password);
                string passwordEncoded = Convert.ToBase64String(bytes);
                //Add account to tabel
                HomeServices.Add(model.UserName,passwordEncoded);

                view.IsSuccessful = true;
                view.Message = "Account Added Successfully";
            }
            else
            {
                view.IsSuccessful = false;
            }
        }

        //Check input is correct
        private bool CheckInput()
        {
            ConnectionInterfaceAndModel();
            if (model.UserName.Trim() == "")
            {
                view.Message = "Please fill User Name fild";
                return false;
            }
            if (model.Password.Trim() == "")
            {
                view.Message = "Please fill Password fild";
                return false;
            }
            if (view.ConfirmPassword.Trim() == "")
            {
                view.Message = "Please fill ConfirmPassword fild";
                return false;
            }

            if(model.Password != view.ConfirmPassword)
            {
                view.Message = "Confirm Password and Password do not match";
                return false;
            }

            return true;

        }
    }
}
