using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Management_System.Logic.Servics
{
    public static class HomeServices
    {
        //Get All Projects
        public static DataTable GetLastProjects()
        {
            return Database.GetAllData("get_Last_project");
        }

        //Get All Reports
        public static DataTable GetLastReports()
        {
            return Database.GetAllData("get_Last_report");
        }


        //Get Employee Count
        public static int GetEmpCount()
        {
            return Database.getCount("empCount");
        }

        //Get Report Count 
        public static int GetRepCount()
        {
            return Database.getCount("Get_ReportCount");
        }

        //Get total Project
        public static int GetTotalProject()
        {
            return Database.getCount("Project_Count");
        }

        //Get Porfit
        public static double GetPorfit()
        {
            return Database.getLargNumber("Total_proj_profits");
        }

        //Get Project Done
        public static int GetProjectDone()
        {
            return Database.getCount("Project_Done_Count");
        }

        //Get Project inProgress
        public static int GetProjectInProgress()
        {
            return Database.getCount("Project_inProgress_Count");
        }

        //Add New Account 
        public static void Add(string userName, string passwoed)
        {
            Database.DealingData("add_newAccount", () => ParameterAdd(Database.command, userName,passwoed));
        }

        public static void ParameterAdd(SqlCommand command, string userName,string password)
        {
            command.Parameters.Add("@userName", SqlDbType.VarChar).Value = userName;
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
        }

    }
}
