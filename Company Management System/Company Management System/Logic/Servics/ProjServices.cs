using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Management_System.Logic.Servics
{
    public static class ProjServices
    {
        
        //Get all data
        public static DataTable GetAllData()
        {
            return Database.GetAllData("select_project_datagridview");
        }

        //Get data by value search
        public static DataTable GetDataByValue(string value)
        {
            int id = int.TryParse(value, out id) ? Convert.ToInt32(value) : 0;
            string name = value;

            return Database.GetDataByValue("search_Project", () => ParameterSearch(Database.command, id, name));
        }
        public static void ParameterSearch(SqlCommand command, int id, string name)
        {
            command.Parameters.Add("@id", SqlDbType.BigInt).Value = id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
        }


        //Get Project Data To show
        public static DataTable GetProjectDataToShow(int id)
        {

            return Database.GetDataByValue("show_project", () => ParameterId(Database.command, id));
        }
        //Get data To Edit
        public static DataTable GetProjectDataToEdit(int id)
        {

            return Database.GetDataByValue("Select_Project_for_edit", () => ParameterId(Database.command, id));
        }

        public static void ParameterId(SqlCommand command, int id)
        {
            command.Parameters.Add("@id", SqlDbType.BigInt).Value = id;
        }

        //Add Data 
        public static void Add(string name, int depno, byte[] photo, string status, string projDate, string startDate, double workDuration, double projCost, double projRevenues, double projPorfit, double projLosses, string projDetails)
        {
            Database.DealingData("Add_proj", () => ParameterAdd(Database.command, name, depno, photo, status, projDate, startDate, workDuration, projCost, projRevenues, projPorfit, projLosses, projDetails));
        }

        public static void ParameterAdd(SqlCommand command, string name, int depno, byte[] photo, string status,string projDate,string startDate , double workDuration, double projCost, double projRevenues, double projPorfit , double projLosses , string projDetails)                                              
        {
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@dep_no", SqlDbType.Int).Value = depno;
            command.Parameters.AddWithValue("@photo",photo);
            command.Parameters.Add("@proj_status", SqlDbType.VarChar).Value = status;
            command.Parameters.Add("@proj_date", SqlDbType.VarChar).Value = projDate;
            command.Parameters.Add("@start_date", SqlDbType.VarChar).Value = startDate;
            command.Parameters.Add("@work_duration", SqlDbType.BigInt).Value = workDuration;
            command.Parameters.Add("@proj_cost", SqlDbType.BigInt).Value = projCost;
            command.Parameters.Add("@proj_revenues", SqlDbType.BigInt).Value = projRevenues;
            command.Parameters.Add("@proj_porfit", SqlDbType.BigInt).Value = projPorfit;
            command.Parameters.Add("@proj_losses", SqlDbType.BigInt).Value = projLosses;
            command.Parameters.Add("@proj_details", SqlDbType.VarChar).Value = projDetails;
        }

        //Edit Data 
        public static void Edit(int id,string name, int depno, byte[] photo, string status, string projDate, string startDate, double workDuration, double projCost, double projRevenues, double projPorfit, double projLosses, string projDetails)
        {
            Database.DealingData("Edit_project", () => ParameterEdit(Database.command, id, name, depno, photo, status, projDate, startDate, workDuration, projCost, projRevenues, projPorfit, projLosses, projDetails));
        }

        public static void ParameterEdit(SqlCommand command, int id, string name, int depno, byte[] photo, string status, string projDate, string startDate, double workDuration, double projCost, double projRevenues, double projPorfit, double projLosses, string projDetails)
        {
            command.Parameters.Add("@id", SqlDbType.BigInt).Value = id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@dep_no", SqlDbType.Int).Value = depno;
            command.Parameters.Add("@photo", SqlDbType.Image).Value = photo;
            command.Parameters.Add("@proj_status", SqlDbType.VarChar).Value = status;
            command.Parameters.Add("@proj_date", SqlDbType.VarChar).Value = projDate;
            command.Parameters.Add("@start_date", SqlDbType.VarChar).Value = startDate;
            command.Parameters.Add("@work_duration", SqlDbType.BigInt).Value = workDuration;
            command.Parameters.Add("@proj_cost", SqlDbType.BigInt).Value = projCost;
            command.Parameters.Add("@proj_revenues", SqlDbType.BigInt).Value = projRevenues;
            command.Parameters.Add("@proj_porfit", SqlDbType.BigInt).Value = projPorfit;
            command.Parameters.Add("@proj_losses", SqlDbType.BigInt).Value = projLosses;
            command.Parameters.Add("@proj_details", SqlDbType.VarChar).Value = projDetails;
        }

        //Delete Data 
        public static void Delete(int id)
        {
            Database.DealingData("delete_Project", () => ParameterDelete(Database.command, id));
        }

        public static void ParameterDelete(SqlCommand command, int id)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }

        //get Department NO
        public static DataTable getDepartmentNO()
        {
            return Database.GetAllData("get_Department_NO");
        }

        //Get Department Budget 
        public static DataTable GetDepartmentBudget(int depNo)
        {
            return Database.GetDataByValue("Get_Dep_current_budget", () => ParameterDepNO(Database.command, depNo));
        }

        public static void ParameterDepNO(SqlCommand command, int depNo)
        {
            command.Parameters.Add("@depNo", SqlDbType.Int).Value = depNo;
        }

    }
}
