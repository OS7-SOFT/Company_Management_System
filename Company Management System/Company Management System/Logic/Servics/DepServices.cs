using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Management_System.Logic.Servics
{
    public static class DepServices
    {

        //Get all data
        public static DataTable GetAllData()
        {
            return Database.GetAllData("Select_Dep_info_to_datagridview");
        }

        //Get data by value search
        public static DataTable GetDataByValue(string value)
        {
            int id = int.TryParse(value, out id) ? Convert.ToInt32(value) : 0;
            string name = value;

            return Database.GetDataByValue("Search_Department", () => ParameterSearch(Database.command, id, name));
        }
        public static void ParameterSearch(SqlCommand command, int id, string name)
        {
            command.Parameters.Add("@dep_name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@dep_no", SqlDbType.Int).Value = id;
        }

        /////////////////////

        //Get current Departmen Data to show
        public static DataTable GetCurrentDepartmentToShow(int id)
        {
            return Database.GetDataByValue("Show_Department_info", () => ParameterID(Database.command, id));
        }

        //Get all data current Department to edit
        public static DataTable GetCurrentDataToEdit(int id)
        {
            return Database.GetDataByValue("Select_Dep_for_edit", () => ParameterID(Database.command, id));
        }

        //Get Department staff
        public static DataTable GetCurrentDepartmentStaff(int id)
        {
            return Database.GetDataByValue("select_Dep_staff", () => ParameterID(Database.command, id));
        }

        //Get Project in Department
        public static DataTable GetCurrentDepartmentProjects(int id)
        {
            return Database.GetDataByValue("select_Dep_proj", () => ParameterID(Database.command, id));
        }

        public static void ParameterID(SqlCommand command, int id)
        {

            command.Parameters.Add("@dep_no", SqlDbType.Int).Value = id;
        }

        ///////////////////// 

        //Get Department staff by value
        public static DataTable GetCurrentDepartmentStaffByValue(int dep_no,string value)
        {
            int id = int.TryParse(value, out id) ? Convert.ToInt32(value) : 0;
            string name = value;

            return Database.GetDataByValue("search_employee_in_current_department", () => ParameterSearchStaff(Database.command, dep_no, id, name));
        }
        public static void ParameterSearchStaff(SqlCommand command, int dep_no, int id, string name)
        {
            command.Parameters.Add("@dep_no", SqlDbType.Int).Value = dep_no;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
        }

        //Get Project in Department by value
        public static DataTable GetCurrentDepartmentProjectByValue(int dep_no, string value)
        {
            int id = int.TryParse(value, out id) ? Convert.ToInt32(value) : 0;
            string name = value;

            return Database.GetDataByValue("search_project_in_current_department", () => ParameterSearchProject(Database.command, dep_no, id, name));
        }
        public static void ParameterSearchProject(SqlCommand command, int dep_no, int id, string name)
        {
            command.Parameters.Add("@dep_no", SqlDbType.Int).Value = dep_no;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@projName", SqlDbType.VarChar).Value = name;
        }

        //Add Data 
        public static void Add(string name, int managerID, double budget, double currentBudget)
        {
            Database.DealingData("add_Dep", () => ParameterAdd(Database.command, name, managerID, budget, currentBudget));
        }

        public static void ParameterAdd(SqlCommand command, string name, int managerID, double budget,double currentBudget)
        {
            command.Parameters.Add("@dep_name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@manager", SqlDbType.Int).Value = managerID;
            command.Parameters.Add("@budget", SqlDbType.BigInt).Value = budget;
            command.Parameters.Add("@currentBudget", SqlDbType.BigInt).Value = currentBudget;

        }

        //Edit Data 
        public static void Edit(int id,string name, int managerID, double budget)
        {
            Database.DealingData("Edit_Dep", () => ParameterEdit(Database.command,id, name, managerID, budget));
        }

        public static void ParameterEdit(SqlCommand command,int id, string name, int managerID, double budget)
        {
            command.Parameters.Add("@dep_no", SqlDbType.VarChar).Value = id;
            command.Parameters.Add("@dep_name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@manager", SqlDbType.Int).Value = managerID;
            command.Parameters.Add("@budget", SqlDbType.BigInt).Value = budget;
        }

        //Delete Data 
        public static void Delete(int id)
        {
            Database.DealingData("Delete_Dep", () => ParameterDelete(Database.command, id));
        }

        public static void ParameterDelete(SqlCommand command, int id)
        {
            command.Parameters.Add("@dep_no", SqlDbType.Int).Value = id;
        } 

        //Select all Staff id
        public static DataTable GetStaffID()
        {
            return Database.GetAllData("select_staff_id");
        }

        //Get department Count
        public static int GetDepartmentCount()
        {
            return Database.getCount("Department_number");
        }

        //Get Total Budget
        public static double GetTotalBudget()
        {
            return Database.getSum("Get_total_dep_budget", () => { });
        }

        //Get Total Current Budget
        public static double GetTotalCurrentBudget()
        {
            return Database.getSum("Get_total_dep_Current_budget", () => { });
        }

        //Get Total Projects Cost
        public static double GetTotalProjectCost(int depNo)
        {
            return Database.getSum("Total_proj_cost_in_dep", () => ParameterDepNo(Database.command, depNo));
        }

        //Get Currrent Budget
        public static DataTable GetCurrentBudget(int depNo)
        {
            return Database.GetDataByValue("Get_Dep_current_budget", () => ParameterDepNo(Database.command, depNo));
        }

        public static void ParameterDepNo(SqlCommand command, int depNo)
        {
            command.Parameters.Add("@depNo", SqlDbType.Int).Value = depNo;
        }

        //Edit Current Budget 
        public static void EditCurrentBudget(int depNo,double result)
        {
            Database.DealingData("update_department_Currentbudget", () => ParameterEditCurrentBudget(Database.command, depNo,result));
        }

        public static void ParameterEditCurrentBudget(SqlCommand command, int depNo,double result)
        {
            command.Parameters.Add("@depNo", SqlDbType.Int).Value = depNo;
            command.Parameters.Add("@result" , SqlDbType.BigInt).Value = result;    
        }

        //Get CurrrentBudget For Company 
        public static DataTable GetBudgetCompany()
        {
            return Database.GetDataByValue("Get_current_budget", () => { });
        }
    }
}
