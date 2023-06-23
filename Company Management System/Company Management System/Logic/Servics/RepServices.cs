using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Management_System.Logic.Servics
{
    public static class RepServices
    {
        //Get All Data
        public static DataTable GetAllData()
        {
            return Database.GetAllData("Select_Report_to_datagridview");
        }

        //Get Reports Count
        public static int GetReportsCount()
        {
            return Database.getCount("Get_ReportCount");
        }

        //Get data by value search
        public static DataTable GetDataByValue(string value)
        {
            int id = int.TryParse(value, out id) ? Convert.ToInt32(value) : 0;
            string title = value;

            return Database.GetDataByValue("Search_Report", () => ParameterSearch(Database.command, id, title));
        }
        public static void ParameterSearch(SqlCommand command, int id, string title)
        {
            command.Parameters.Add("@title", SqlDbType.VarChar).Value = title;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }

        //Get all data current employee to show and Edit
        public static DataTable GetCurrentReport(int id)
        {
            return Database.GetDataByValue("Select_current_Report", () => ParameterID(Database.command, id));
        }

        public static void ParameterID(SqlCommand command, int id)
        {

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }

        //Add Data 
        public static void Add(string title, string content , string date)
        {
            Database.DealingData("add_Report", () => ParameterAdd(Database.command, title,content,date));
        }

        public static void ParameterAdd(SqlCommand command, string title, string content , string date)
        {
            command.Parameters.Add("@title", SqlDbType.VarChar).Value = title;
            command.Parameters.Add("@content", SqlDbType.VarChar).Value = content;
            command.Parameters.Add("@date", SqlDbType.VarChar).Value = date;
         
        }

        //Edit Data 
        public static void Edit(int id,string title, string content)
        {
            Database.DealingData("Edit_Report", () => ParameterEdit(Database.command, id, title, content));
        }

        public static void ParameterEdit(SqlCommand command, int id, string title, string content)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@title", SqlDbType.VarChar).Value = title;
            command.Parameters.Add("@content", SqlDbType.VarChar).Value = content;

        }

        //Delete Data 
        public static void Delete(int id)
        {
            Database.DealingData("Delete_Report", () => ParameterDelete(Database.command, id));
        }

        public static void ParameterDelete(SqlCommand command, int id)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }
    }
}
