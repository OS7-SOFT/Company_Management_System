using Company_Management_System.Model;
using Company_Management_System.Views.Interface;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Company_Management_System.Logic.Servics;

namespace Company_Management_System.Logic.Presenter
{
    public class DepPresenter
    {
        IDepView view; 
        DepModel model = new DepModel();
        BindingSource depList;
        BindingSource staffList;
        BindingSource projList;

        //Constructor
        public DepPresenter(IDepView view)
        {
            depList = new BindingSource();
            staffList = new BindingSource();
            projList = new BindingSource();

            this.view = view;
            //connect Event method with view event
            this.view.SearchEvent += ShowSearchResultDepartment;
            this.view.SearchStaffAndProjectEvent += ShowSearchResultDepartmentStaffAndProject;
            this.view.AddEvent += AddDepartment;
            this.view.EditEvent += LoadDataToEdit;
            this.view.ShowDepInfoEvent += ShowDepartmentInfo;
            this.view.SaveEvent += Save;
            this.view.CancelEvent += CancelAction;
            this.view.DeleteEvent += DeleteDepartment;
            //Set Department Data in binding Sources
            this.view.SetDataDepartment(depList);
           

        }

        //to connect Model with View
        private void ConnectionInterfaceAndModel()
        {
            model.DepNo = Convert.ToInt32(view.DepNo);
            model.DepName = view.DepName;
            model.ManagerID = Convert.ToInt32(view.ManagerID);
            model.Budget = Convert.ToDouble(view.Budget);
        }


        //Methodes

        //To load Data 
        public  void loadDepartmentData()
        {

            //Calc Current Budget
            CalcCurrentBudget();
            depList.DataSource = DepServices.GetAllData();
            view.DepCount = DepServices.GetDepartmentCount().ToString();
            view.LblTotalbudget = DepServices.GetTotalBudget().ToString();
            view.LblTotalCurrentbudget = DepServices.GetTotalCurrentBudget ().ToString();
            
        }


        //To show search result about department
        private void ShowSearchResultDepartment(object sender, EventArgs e)
        {
            bool isEmpty = String.IsNullOrEmpty(view.SearchValue);

            if (isEmpty)
                depList.DataSource = DepServices.GetAllData();
            else
                depList.DataSource = DepServices.GetDataByValue(view.SearchValue);
        }
        

        //Show Department Info
        private void ShowDepartmentInfo(object sender, EventArgs e)
        {
            model.DepNo = Convert.ToInt32(view.DepNo);

            staffList.DataSource = DepServices.GetCurrentDepartmentStaff(model.DepNo);
            view.SetDepartmentStaff(staffList);

            projList.DataSource = DepServices.GetCurrentDepartmentProjects(model.DepNo);
            view.SetDepartmentProj(projList);

            DataTable dt = DepServices.GetCurrentDepartmentToShow(model.DepNo);

            view.DepName = dt.Rows[0][1].ToString();
            view.ManagerID = dt.Rows[0][2].ToString();
            view.EmpCount = dt.Rows[0][3].ToString();
            view.ProjCount = dt.Rows[0][4].ToString();
            view.Budget = dt.Rows[0][5].ToString();
            view.Profit = dt.Rows[0][6].ToString();
            view.Losses = dt.Rows[0][7].ToString();
            view.TotalSalaries = dt.Rows[0][8].ToString();
            view.CurrentBudget = dt.Rows[0][9].ToString();
            //Get total projects cost
            view.TotalProjCost = DepServices.GetTotalProjectCost(model.DepNo).ToString();
        }


        //To show search result about Department Staff
        private void ShowSearchResultDepartmentStaffAndProject(object sender, EventArgs e)
        {
            model.DepNo = Convert.ToInt32(view.DepNo);

            bool isStaffEmpty = String.IsNullOrEmpty(view.SearchStaffValue);
            bool isProjEmpty = String.IsNullOrEmpty(view.SearchProjValue);

            if (isStaffEmpty)
                staffList.DataSource = DepServices.GetCurrentDepartmentStaff(model.DepNo);
            else
                staffList.DataSource = DepServices.GetCurrentDepartmentStaffByValue(model.DepNo, view.SearchStaffValue);

            if (isProjEmpty)
                projList.DataSource = DepServices.GetCurrentDepartmentProjects(model.DepNo);
            else
                projList.DataSource = DepServices.GetCurrentDepartmentProjectByValue(model.DepNo, view.SearchProjValue);

        }


        //load data to edit
        private void LoadDataToEdit(object sender, EventArgs e)
        {
            model.DepNo = Convert.ToInt32(view.DepNo);
            view.IsEdit = true;

            DataTable dt = DepServices.GetCurrentDataToEdit(model.DepNo);
            view.DepName = dt.Rows[0][1].ToString();
            view.ManagerID = dt.Rows[0][2].ToString();
            view.Budget = dt.Rows[0][3].ToString(); 

            
        }


        //add Department
        private void AddDepartment(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }


        //delete Department 
        private void DeleteDepartment(object sender, EventArgs e)
        {
            model.DepNo = Convert.ToInt32(view.DepNo);

            try
            {
                DepServices.Delete(model.DepNo);
                view.Message = "Deleted Successfully";
                loadDepartmentData();
            }
            catch (Exception ex)
            {
                view.Message = ex.Message;
            }
        }


        //Save operating 
        private void Save(object sender, EventArgs e)
        {
            if (checkInput())
            {
                ConnectionInterfaceAndModel();

                try
                {
                    if (view.IsEdit == false)
                    {
                        DepServices.Add(model.DepName, model.ManagerID, model.Budget,model.Budget);
                        view.Message = "Department Added Successfully";
                    }
                    else
                    {
                        DepServices.Edit(model.DepNo, model.DepName, model.ManagerID, model.Budget);
                        view.Message = "Department Edited Successfully";
                        CalcCurrentBudget();
                    }
                    view.IsSuccessful = true;
                    clearFildes();
                   
                    loadDepartmentData();   
                }
                catch (Exception ex)
                {
                    view.Message = ex.Message;
                    view.IsSuccessful = false;
                }
            }

            else
            {
                view.IsSuccessful = false;
            }
            
        }


        //cancel operating
        private void CancelAction(object sender, EventArgs e)
        {
            clearFildes();
        }


        //Clear view Fildes 
        public void clearFildes()
        {
            view.DepName = null;
            view.ManagerID = "0";
            view.Budget = "0";
            
        }

        //Calculate Current Budget
        private void CalcCurrentBudget()
        {

            for (int depNo = 1; depNo <= DepServices.GetDepartmentCount(); depNo++)
            {
                DataTable dt = DepServices.GetCurrentDepartmentToShow(depNo);
                double totalProjCost = DepServices.GetTotalProjectCost(depNo);
                double budget = Convert.ToDouble(dt.Rows[0][5]);
                double totalProjProfit = dt.Rows[0][6].ToString() == null ? 0 : Convert.ToDouble(dt.Rows[0][6]);
                double totalProjLosses = dt.Rows[0][7].ToString() == null ? 0 : Convert.ToDouble(dt.Rows[0][7]);
                double totalSalaries = dt.Rows[0][8].ToString() == null ? 0 : Convert.ToDouble(dt.Rows[0][8]);

                double currentBudget = budget + totalProjProfit - totalSalaries - totalProjCost - totalProjLosses;

                DepServices.EditCurrentBudget(depNo, currentBudget);
            }
           
        }

        //Check input Fildes
        private bool checkInput() 
        {
            DataTable dt = DepServices.GetStaffID();
            DataTable CompanyBudget = DepServices.GetBudgetCompany();

            bool manageId = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToInt32(view.ManagerID) == (int)dt.Rows[i][0])
                {
                    manageId = true;
                    break;
                }

            }

            if(view.DepName.Trim() == "")
            {
                view.Message = "Must be fill Department Name Text !";
                return false;
            }

            if (!manageId)
            {
                view.Message = "Selected manager ID does Not Found !";
                return false;
            }

            if (view.Budget.Trim() == "")
            {
                view.Message = "Must be fill Budget Text !";
                return false;
            }

            if (Convert.ToDouble(view.Budget) > Convert.ToDouble(CompanyBudget.Rows[0][0]))
            {
                view.Message = "Department Budget greater than Company budget !";
                return false;
            }

            return true;
        }
    }
}
