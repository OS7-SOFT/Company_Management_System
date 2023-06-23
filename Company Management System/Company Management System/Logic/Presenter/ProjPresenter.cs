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
    public class ProjPresenter
    {
        IProjView view;
        ProjModel model = new ProjModel();
        BindingSource projList;

        //Constractor
        public ProjPresenter(IProjView view)
        {
            projList = new BindingSource();
            this.view = view;
            //connect Event method with view event
            this.view.SearchEvent += ShowSearchResult;
            this.view.ShowProjInfoEvent += ShowProjectInfo;
            this.view.AddEvent += AddProject;
            this.view.EditEvent += LoadDataToEdit;
            this.view.DeleteEvent += DeleteProject;
            this.view.SaveEvent += SavaProject;
            this.view.CancelEvent += CancelAction;
            //Set Project Data in Binding Source
            this.view.SetDataProject(projList);
            //To Load Project Data
            LoadProjectData();
        }

        
        //to connect Model with View
        private void ConnectionInterfaceAndModel()
        {
            model.ProjId = Convert.ToInt32(view.Id);
            model.ProjName = view.ProjName;
            model.DepNO = view.DepNo == "" ? 0 : Convert.ToInt32(view.DepNo);
            model.ProjImage = view.ProjImage;
            model.ProjStatus = view.ProjStatus == true ? "Complate" : "In Progress";
            model.ProjectDate = view.ProjDate.ToString();
            model.ProjStartDate = view.ProjStartDate.ToString();
            model.WorkDuration = view.WorkDuration;
            model.ProjCost = view.ProjCost == "" ? 0 : Convert.ToDouble(view.ProjCost);
            model.ProjRevenues = view.ProjRevenues == "" ? 0 : Convert.ToDouble(view.ProjRevenues);
            model.ProjDetails = view.ProjDetails;
            //calculate Profit and losses
            double val = model.ProjRevenues - model.ProjCost;
            if (val > 0)
            {
                model.ProjProfits = val;
                model.ProjLosses = 0;
            }
            else if (val < 0)
            {
                model.ProjProfits = 0;
                model.ProjLosses = val * -1;
            }
            else
            {
                model.ProjProfits = 0;
                model.ProjLosses = 0;
            }

        }


        //Methodes
        private void LoadProjectData()
        {
            projList.DataSource = ProjServices.GetAllData();
        }

        private void ShowSearchResult(object sender, EventArgs e)
        {
            bool isEmpty = String.IsNullOrEmpty(view.SearchValue);

            if (isEmpty)
                projList.DataSource = ProjServices.GetAllData();
            else
                projList.DataSource = ProjServices.GetDataByValue(view.SearchValue);
        }

        private void ShowProjectInfo(object sender, EventArgs e)
        {
            model.ProjId = Convert.ToInt32(view.Id);
            DataTable dt = ProjServices.GetProjectDataToShow(model.ProjId);

            view.Id = dt.Rows[0][0].ToString();
            view.ProjName = dt.Rows[0][1].ToString();
            view.DepNo = dt.Rows[0][2].ToString();
            view.ProjImage = dt.Rows[0][3] == null ? null : dt.Rows[0][3] as byte[];
            view.ProjStatus = dt.Rows[0][4].ToString() == "Complate" ? true : false;
            view.ProjStartDate = dt.Rows[0][5].ToString();
            view.ProjDate = dt.Rows[0][6].ToString();
            view.WorkDuration = Convert.ToDouble(dt.Rows[0][7]);
            view.ProjCost = dt.Rows[0][8].ToString();
            view.ProjRevenues = dt.Rows[0][9].ToString();
            view.ProjProfits = dt.Rows[0][10].ToString();
            view.ProjLosses = dt.Rows[0][11].ToString();
            view.ProjDetails = dt.Rows[0][12].ToString();

        }

        private void AddProject(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void LoadDataToEdit(object sender, EventArgs e)
        {
            view.IsEdit = true;
            model.ProjId = Convert.ToInt32(view.Id);
            DataTable dt = ProjServices.GetProjectDataToEdit(model.ProjId);

            view.ProjName = dt.Rows[0][0].ToString();
            view.DepNo = dt.Rows[0][1].ToString();
            view.ProjImage = dt.Rows[0][2] == "" ? null : dt.Rows[0][2] as byte[];
            view.ProjStatus = dt.Rows[0][3].ToString() == "Complate" ? true : false;
            view.ProjStartDate = dt.Rows[0][4].ToString();
            view.ProjDate = dt.Rows[0][5].ToString();
            view.WorkDuration = Convert.ToDouble(dt.Rows[0][6]);
            view.ProjCost = dt.Rows[0][7].ToString();
            view.ProjRevenues = dt.Rows[0][8].ToString();
            view.ProjDetails = dt.Rows[0][9].ToString();
        }

        private void DeleteProject(object sender, EventArgs e)
        {
            model.ProjId = Convert.ToInt32(view.Id);
            ProjServices.Delete(model.ProjId);
            view.Message = "Deleted Successfully";
            LoadProjectData();
        }

        private void SavaProject(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                ConnectionInterfaceAndModel();
                try
                {
                    if (view.IsEdit == false)
                    {
                        ProjServices.Add(model.ProjName, model.DepNO, model.ProjImage, model.ProjStatus, model.ProjectDate, model.ProjStartDate, model.WorkDuration, model.ProjCost, model.ProjRevenues, model.ProjProfits, model.ProjLosses, model.ProjDetails);
                        view.Message = "Project Add Successfully";

                    }
                    else
                    {

                        ProjServices.Edit(model.ProjId, model.ProjName, model.DepNO, model.ProjImage, model.ProjStatus, model.ProjectDate, model.ProjStartDate, model.WorkDuration, model.ProjCost, model.ProjRevenues, model.ProjProfits, model.ProjLosses, model.ProjDetails);
                        view.Message = "Project Edit Successfully";
                    }

                    view.IsSuccessful = true;
                    LoadProjectData();
                    clearFildes();
                }
                catch (Exception ex)
                {
                    view.Message = ex.Message;
                    view.IsSuccessful = false;
                }
            }
            else 
                view.IsSuccessful = false ;
           
        }

        private void CancelAction(object sender, EventArgs e)
        {
            clearFildes();
        }

        //Clear view Fildes 
        public void clearFildes()
        {
            view.ProjName = null;
            view.ProjImage = null;
            view.DepNo = null;
            view.ProjCost = null;
            view.ProjRevenues = null;
            view.WorkDuration = 0;
            view.ProjDetails = null;

        }

        //Check input is correct
        private bool CheckInput()
        {
            model.DepNO = view.DepNo == "" ? 0 : Convert.ToInt32(view.DepNo);
            model.ProjCost = view.ProjCost == "" ? 0 : Convert.ToDouble(view.ProjCost);

            DataTable DepNO_tbl = ProjServices.getDepartmentNO();
            DataTable DepBudget_tbl = ProjServices.GetDepartmentBudget(model.DepNO);

            bool DepNo = false;
            //Check if department id is correct
            for (int i = 0; i < DepNO_tbl.Rows.Count; i++)
            {
                if (model.DepNO == Convert.ToInt32(DepNO_tbl.Rows[i][0]))
                {
                    DepNo = true;
                    break;
                }

            }

            if (view.ProjName.Trim() == "")
            {
                view.Message = "Must be Fill Text Project Name ! ";
                return false;
            }

            if (!DepNo)
            {
                view.Message = "Department Number is not Correct ! ";
                return false;
            }

            if(model.ProjCost > Convert.ToDouble(DepBudget_tbl.Rows[0][0]))
            {
                view.Message = "Project cost greater than Department budget !";
                return false;
            }
            


            return true;
        }

    }
}

