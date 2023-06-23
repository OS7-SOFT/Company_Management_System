using Company_Management_System.Logic.Servics;
using Company_Management_System.Model;
using Company_Management_System.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company_Management_System.Logic.Presenter
{
    public class EmpPresenter
    {
        IEmpView view;
        EmpModel model = new EmpModel();
        BindingSource empList;
      

        public EmpPresenter(IEmpView view)
        {
            empList = new BindingSource();
            this.view = view;
            //connect Event method with view event  
            this.view.SearchEvent += ShowSearchResult;
            this.view.ShowInfoEmployeeEvent += ShowInfoEmployee;
            this.view.AddEvent += AddEmployee;
            this.view.EditEvent += LoadDataToEdit;
            this.view.SaveEvent += SaveEmployee;
            this.view.CancelEvent += CancelAction;
            this.view.DeleteEvent += DeleteEmployee;
            //Set Employee in binding source
            this.view.SetDataEmployee(empList);
            //to load all data
            LoadAlldata();
        
        }


        //method to connect Model with View
        private void ConnectionInterfaceAndModel()
        {
            model.Id = Convert.ToInt32(view.Id);
            model.Name = view.empName;
            model.Age = view.Age;
            model.Gender = view.Male == true ? "Male" : "Female";
            model.Photo = view.Photo;
            model.Phone = view.Phone;
            model.Email = view.Email;
            model.Address = view.Address;
            model.JopTitl = view.JopTitl;
            model.Salary = view.Salary;
            model.DepNo = view.DepNo;
            
        }


        // Methods
        private void LoadAlldata()
        {

            empList.DataSource = EmpServices.GetAllData();
            //to calculate Employee Count  
            view.EmpCount = EmpServices.GetEmpCount().ToString();
            view.EmpCountMale = EmpServices.GetEmpMale().ToString();
            view.EmpCountFemale = EmpServices.GetEmpFemale().ToString();
            view.TotalSalaries = EmpServices.GetTotalSalaries();
        }

        private void ShowSearchResult(object sender, EventArgs e)
        {
            bool isEmpty = String.IsNullOrEmpty(view.SearchValue);

            if (isEmpty)
                empList.DataSource = EmpServices.GetAllData();
            else
                empList.DataSource = EmpServices.GetDataByValue(view.SearchValue);
        }

        private void ShowInfoEmployee(object sender, EventArgs e)
        {
            model.Id = Convert.ToInt32(view.Id);
            DataTable dt = EmpServices.GetCurrentDataToShow(model.Id);

            view.Id = dt.Rows[0][0].ToString();
            view.empName = dt.Rows[0][1].ToString();
            view.Age = (int)dt.Rows[0][2];
            view.Male = dt.Rows[0][3].ToString() == "Male" ? true : false;
            view.Photo = dt.Rows[0][4] == "" ? null : dt.Rows[0][4] as byte[];
            view.Phone = Convert.ToDouble(dt.Rows[0][5]);
            view.Email = dt.Rows[0][6].ToString();
            view.Address = dt.Rows[0][7].ToString();
            view.JopTitl = dt.Rows[0][8].ToString();
            view.Salary = Convert.ToDouble(dt.Rows[0][9]);
            view.DepName = dt.Rows[0][10].ToString();
        }

        private void AddEmployee(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void LoadDataToEdit(object sender, EventArgs e)
        {
            view.IsEdit = true;
            model.Id = Convert.ToInt32(view.Id);
            DataTable dt = EmpServices.GetCurrentDataToEdit(model.Id);

            view.empName = dt.Rows[0][0].ToString();
            view.Age =  (int)dt.Rows[0][1];
            view.Male = dt.Rows[0][2].ToString() == "Male" ? true : false;
            view.Photo = dt.Rows[0][3] == "" ? null : dt.Rows[0][3] as byte[];
            view.Phone = Convert.ToDouble(dt.Rows[0][4]);
            view.Email = dt.Rows[0][5].ToString();
            view.Address = dt.Rows[0][6].ToString();
            view.JopTitl = dt.Rows[0][7].ToString();
            view.Salary = Convert.ToDouble(dt.Rows[0][8]);
            view.DepNo = (int)dt.Rows[0][9];
        }

        

        private void DeleteEmployee(object sender, EventArgs e)
        {
            model.Id = Convert.ToInt32(view.Id);
            try
            {
                EmpServices.Delete(model.Id);
                view.Message = "Deleted Successfully";
                LoadAlldata();
            }
            catch (Exception ex)
            {
                view.Message = ex.Message;
            } 
        }

        private void SaveEmployee(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                ConnectionInterfaceAndModel();

                try
                {
                    if (view.IsEdit == false)
                    {
                        EmpServices.Add(model.Name, model.Age, model.Gender, model.Photo, model.Phone, model.Email, model.Address, model.JopTitl, model.Salary, model.DepNo);
                        view.Message = "Employee Added Successfully";
                    }
                    else
                    {
                        
                        EmpServices.Edit(model.Id, model.Name, model.Age, model.Gender, model.Photo, model.Phone, model.Email, model.Address, model.JopTitl, model.Salary, model.DepNo);
                        view.Message = "Employee Edited Successfully";
                    }
                    view.IsSuccessful = true;
                
                    clearFildes();
                    LoadAlldata();
                }
                catch (Exception ex)
                {
                    view.Message = ex.Message;
                    view.IsSuccessful = false;
                }
            }
            
            else 
                view.IsSuccessful=false;
                        
        }


        private void CancelAction(object sender, EventArgs e)
        {
            clearFildes();
        }

        //Clear view Fildes 
        private void clearFildes()
        {
            view.empName = null;
            view.Age = 0;
            view.Phone = 0;
            view.Photo = null;
            view.Email = null;
            view.Address = null;
            view.JopTitl = null;
            view.Salary = 0;
            view.DepNo = 0;
        }

        //Check input is correct
        private bool CheckInput()
        {
            model.DepNo = view.DepNo;
            DataTable dt = EmpServices.getDepartmentNO();
            DataTable Departmentbudget = EmpServices.GetDepartmentBudget(model.DepNo);

            bool DepNo = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if(view.DepNo == Convert.ToInt32(dt.Rows[i][0]))
                {
                    DepNo = true;
                    break;
                }
                    
            }

            if (!DepNo)
            {
                view.Message = "Department NO is not Correct ! ";
                return false;
            }
         
            if (view.empName.Trim() == "")
            {
                view.Message = "Must be Fill Text Name ! ";
                return false;
            }
            else if (view.Address.Trim() == "")
            {
                view.Message = "Must be Fill Text Address ! ";
                return false;
            }
            else if (view.JopTitl.Trim() == "")
            {
                view.Message = "Must be Fill Text Jop Title ! ";
                return false;
            }

            //Regular exprssion For Email
            Regex regex = new Regex(@"^\w+([-_.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            if (!regex.IsMatch(view.Email))
            {
                view.Message = "Invalid Email !!! ";
                return false;
            }

            else if (view.Email.Trim() == "")
            {
                view.Message = "Must be Fill Text Email ! ";
                return false;
            }

            else if (view.Salary > Convert.ToDouble(Departmentbudget.Rows[0][0]))
            {
                view.Message = "Employee Salary greater than Department budget ! ";
                return false;
            }

            return true;
                 
        }

    }
}
