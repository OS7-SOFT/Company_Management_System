using Company_Management_System.Logic.Servics;
using Company_Management_System.Model;
using Company_Management_System.Views.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company_Management_System.Logic.Presenter
{
    public class RepPresenter
    {
        IRepView view;
        RepModel model = new RepModel();
        BindingSource reportList;
        public RepPresenter(IRepView view)
        {
            reportList = new BindingSource();
            this.view = view;
            //connect Event method with view event  
            this.view.SearchEvent += ShowSearchResult;
            this.view.ShowReportContent += ShowInfoReport;
            this.view.AddEvent += AddReport;
            this.view.EditEvent += LoadDataToEdit;
            this.view.SaveEvent += SaveReport;
            this.view.CancelEvent += CancelAction;
            this.view.DeleteEvent += DeleteReport;
            //Set Report in binding source
            this.view.SetDataReports(reportList);
            //to load all data
            LoadAlldata();
        }

        //method to connect Model with View
        private void ConnectionInterfaceAndModel()
        {
            model.Id = Convert.ToInt32(view.Id);
            model.Title = view.Title;
            model.Content = view.Content;
            model.Craeted = Convert.ToDateTime(view.Date);
        }

        private void LoadAlldata()
        {
            reportList.DataSource = RepServices.GetAllData();

            view.ReportCount = RepServices.GetReportsCount().ToString();
        }

        private void ShowSearchResult(object sender, EventArgs e)
        {
            bool isEmpty = String.IsNullOrEmpty(view.SearchValue);

            if (isEmpty)
                reportList.DataSource = RepServices.GetAllData();
            else
                reportList.DataSource = RepServices.GetDataByValue(view.SearchValue);
        }

        private void ShowInfoReport(object sender, EventArgs e)
        {
            model.Id = Convert.ToInt32(view.Id);
            DataTable dt = RepServices.GetCurrentReport(model.Id);

            view.Title = dt.Rows[0][1].ToString();
            view.Content = dt.Rows[0][2].ToString();
            view.Date = dt.Rows[0][3].ToString();
        }

        private void LoadDataToEdit(object sender, EventArgs e)
        {
            view.IsEdit = true;
            model.Id = Convert.ToInt32(view.Id);
            DataTable dt = RepServices.GetCurrentReport(model.Id);

            view.Title = dt.Rows[0]["Title"].ToString();
            view.Content = dt.Rows[0]["Content"].ToString();
            view.Date = dt.Rows[0]["Date"].ToString();
        }

        private void AddReport(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void DeleteReport(object sender, EventArgs e)
        {
            model.Id = Convert.ToInt32(view.Id);
            RepServices.Delete(model.Id);
            view.Message = "Deleted Successfully";
            LoadAlldata();
        }

        private void SaveReport(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                ConnectionInterfaceAndModel();

                if (view.IsEdit)
                {
                    RepServices.Edit(model.Id, model.Title, model.Content);
                    view.Message = "Report edit Successfully";
                }
                else
                {

                    RepServices.Add(model.Title, model.Content,DateTime.Now.ToString("g"));
                    view.Message = "Report Added Successfully";

                }

                view.IsSuccessful = true;

                clearFildes();
                LoadAlldata();

            }
            else
            {
                view.IsSuccessful = false;
            }

        }

        private void CancelAction(object sender, EventArgs e)
        {
            clearFildes();
        }

        //Clear view Fildes 
        private void clearFildes()
        {
            view.Title = null;
            view.Content = null;
        }

        //Check input is correct
        private bool CheckInput()
        {
            ConnectionInterfaceAndModel();

            if (model.Title.Trim() == "")
            {
                view.Message = "Please fill title filds";
                return false;
            }
            if (model.Content.Trim() == "")
            {
                view.Message = "Please fill Content filds";
                return false;
            }


            return true;

        }

    }
}
