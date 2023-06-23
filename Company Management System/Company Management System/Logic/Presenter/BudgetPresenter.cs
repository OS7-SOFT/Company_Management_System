using Company_Management_System.Model;
using Company_Management_System.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Company_Management_System.Logic.Servics;

namespace Company_Management_System.Logic.Presenter
{
    public class BudgetPresenter
    {
        BudgetModel model = new BudgetModel();
        IBudgetView view;
        BindingSource depInfolist;

        //Constructor
        public BudgetPresenter(IBudgetView view)
        {
            depInfolist = new BindingSource();

            this.view = view;
            this.view.AddBudgetEvent += AddBudget;
            this.view.EditEvent += LoadBudgetToEdit;
            this.view.SaveEvent += Save;
            this.view.CancelEvent += Cancel;
            this.view.SetDepartmentInfo(depInfolist);

        }

        
        //method to connect Model with View
        private void ConnectionInterfaceAndModel()
        {
            model.Capital = Convert.ToDouble(view.Capital);
        }


        //Methods
        public void LoadAllStatistics()
        {
            //calc Current Budget
            CalcCurrentBudget();

            DataTable capital = BudgetServics.GetCapital();
            DataTable currentBudget = BudgetServics.GetCurrentBudget();

            view.LblCapital = capital.Rows[0][0].ToString();
            view.CurrentBudget = currentBudget.Rows[0][0].ToString();
            view.TotalProjCost = BudgetServics.GetTotalProjCosts().ToString();
            view.TotalProjProfits = BudgetServics.GetTotalProjProfit().ToString();
            view.TotalProjLosses = BudgetServics.GetTotalProjLosses().ToString();
            view.TotalEmpSalaries = BudgetServics.GetTotalSalaries().ToString();

            //Get Department Budget
            depInfolist.DataSource = BudgetServics.GetDepInfo();
        }

        private void AddBudget(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void LoadBudgetToEdit(object sender, EventArgs e)
        {
            view.IsEdit = true;
            DataTable capital = BudgetServics.GetCapital();
            view.Capital = capital.Rows[0][0].ToString();
        }

        private void Save(object sender, EventArgs e)
        {
            ConnectionInterfaceAndModel();

            if (view.IsEdit)
            {
                BudgetServics.EditCapital(model.Capital);
                view.Message = "Edit Successfully";
            }
            else
            {
                DataTable currentCapital = BudgetServics.GetCapital();
                double capital = currentCapital.Rows[0][0].ToString() == null ? model.Capital : model.Capital + Convert.ToDouble(currentCapital.Rows[0][0])  ;
                BudgetServics.Add(model.Capital, capital);
                view.Message = "Added Succssefully ";
            }
            CalcCurrentBudget();
            LoadAllStatistics();
        }

        private void Cancel(object sender, EventArgs e)
        {
            clearFilde();
        }

        private void clearFilde()
        {
            view.Capital = "0";
        }


        private void CalcCurrentBudget()
        {
            DataTable dt = BudgetServics.GetCapital();
            double capital = dt.Rows[0][0].ToString() == null ? 0 : Convert.ToDouble(dt.Rows[0][0]);

            double currentBudget = BudgetServics.GetSumProjectsProfit() + capital - BudgetServics.GetSumDepartmentBudget();
            BudgetServics.UpdateCurrentBudget(currentBudget);
        }

    }
}
