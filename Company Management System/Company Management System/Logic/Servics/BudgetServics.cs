using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Management_System.Logic.Servics
{
    public static class BudgetServics
    {




        //Add Budget
        public static void Add(double capital , double currentBudget)
        {
            Database.DealingData("Add_budget", () => ParameterAdd(Database.command, capital, currentBudget));
        }

        public static void ParameterAdd(SqlCommand command,double capital , double currentBudget)
        {
            command.Parameters.AddWithValue("@capital", SqlDbType.BigInt).Value = capital;
            command.Parameters.AddWithValue("@currentBudget", SqlDbType.BigInt).Value = currentBudget;
        }

        //update Capital
        public static void EditCapital(double capital)
        {
            Database.DealingData("edit_capital", () => ParameterEditCapital(Database.command, capital));
        }

        public static void ParameterEditCapital(SqlCommand command, double capital)
        {
            command.Parameters.AddWithValue("@capital", SqlDbType.BigInt).Value = capital;
        }

        //update Current Budget
        public static void UpdateCurrentBudget(double value)
        {
            Database.DealingData("edit_CurrentBudget", () => ParameterUpdate(Database.command, value));
        }

        public static void ParameterUpdate(SqlCommand command, double value)
        {
            command.Parameters.AddWithValue("@currentBudget", SqlDbType.BigInt).Value = value;
        }

        //Get All Department info 
        public static DataTable GetDepInfo()
        {
            return Database.GetAllData("Get_department_budget");
        }

        //Get Capital
        public static DataTable GetCapital()
        {
            return Database.GetAllData("Get_Capital");
        }

        //Get Current Budget
        public static DataTable GetCurrentBudget()
        {
            return Database.GetAllData("Get_current_budget");
        }

        //Get Project Costs
        public static double GetTotalProjCosts()
        {
            return Database.getSum("Total_proj_costs", () => { });
        }
        //Get Project Costs
        public static double GetTotalProjProfit()
        {
            return Database.getSum("Total_proj_profits", () => { });
        }
        //Get Project Costs
        public static double GetTotalProjLosses()
        {
            return Database.getSum("Total_proj_Losses", () => { });
        }
        //Get Project Costs
        public static double GetTotalSalaries()
        {
            return Database.getSum("totalSalaries", () => { });
        }
        //Get All Projects profit 
        public static double GetSumProjectsProfit()
        {
            return Database.getSum("sum_Profit_Projects", () => { });
        }

        //Get All Sum Department Budget
        public static double GetSumDepartmentBudget()
        {
            return Database.getSum("sum_departmentBudget", () => { });
        }
    }
}
