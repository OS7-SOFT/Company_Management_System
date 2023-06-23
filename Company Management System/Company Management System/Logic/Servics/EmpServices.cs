using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Company_Management_System.Model;

namespace Company_Management_System.Logic.Servics
{
    public static class EmpServices
    {
        //Get all data
        public static DataTable GetAllData()
        {
             return Database.GetAllData("Select_EmpData_Datagridview");
        }

        //Get data by value search
        public static DataTable GetDataByValue(string value)
        {
             int id = int.TryParse(value, out id) ? Convert.ToInt32(value) : 0;
             string name = value;

             return Database.GetDataByValue("Search_Employee", ()=> ParameterSearch(Database.command,id,name));
        }
        public static void ParameterSearch(SqlCommand command,int id,string name)
        {
             command.Parameters.Add("@name",SqlDbType.VarChar).Value = name;
             command.Parameters.Add("@id",SqlDbType.Int).Value = id;
        }

        //////////////////

        //Get all data current employee to edit
        public static DataTable GetCurrentDataToEdit(int id)
        {
            return Database.GetDataByValue("Select_All_Data_Emp_to_edit", () => ParameterID(Database.command, id));
        }

        //Get all data current employee to show
        public static DataTable GetCurrentDataToShow(int id)
        {
            return Database.GetDataByValue("Select_All_Data_Emp_to_show", () => ParameterID(Database.command, id));
        }
      
        public static void ParameterID(SqlCommand command, int id)
        {

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }
        //////////////////


        //Add Data 
        public static void Add(string name, int age, string gender, byte[] photo, double phone,string email, string Address, string jopTitle, double salary, int dep_no)
        {
            Database.DealingData("Add_Emp", () => ParameterAdd(Database.command,name,age,gender,photo,phone,email,Address,jopTitle,salary,dep_no));
        }

        public static void ParameterAdd(SqlCommand command,string name , int age , string gender,byte[] photo, double phone,string email, string Address,string jopTitle , double salary,int dep_no)
        {
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@age", SqlDbType.Int).Value = age;
            command.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@photo", SqlDbType.Image).Value = photo;
            command.Parameters.Add("@phone", SqlDbType.BigInt).Value = phone;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = Address;
            command.Parameters.Add("@jop_title", SqlDbType.VarChar).Value = jopTitle;
            command.Parameters.Add("@salary", SqlDbType.BigInt).Value = salary;
            command.Parameters.Add("@dep_no", SqlDbType.VarChar).Value = dep_no;
        }

        //Edit Data 
        public static void Edit(int id,string name, int age, string gender, byte[] photo, double phone, string email, string Address, string jopTitle, double salary, int dep_no)
        {
            Database.DealingData("Edit_Emp", () => ParameterEdit(Database.command, id, name, age, gender, photo, phone, email, Address, jopTitle, salary, dep_no));
        }

        public static void ParameterEdit(SqlCommand command, int id, string name, int age, string gender, byte[] photo, double phone,string email ,string Address, string jopTitle, double salary, int dep_no)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@age", SqlDbType.Int).Value = age;
            command.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@photo", SqlDbType.Image).Value = photo;
            command.Parameters.Add("@phone", SqlDbType.BigInt).Value = phone;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = Address;
            command.Parameters.Add("@jop_title", SqlDbType.VarChar).Value = jopTitle;
            command.Parameters.Add("@salary", SqlDbType.BigInt).Value = salary;
            command.Parameters.Add("@dep_no", SqlDbType.VarChar).Value = dep_no;
        }

        //Delete Data 
        public static void Delete(int id)
        {
            Database.DealingData("Delete_Emp", () => ParameterDelete(Database.command,id));
        }

        public static void ParameterDelete(SqlCommand command, int id)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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

        //get Department NO
        public static DataTable getDepartmentNO()
        {
            return Database.GetAllData("get_Department_NO");
        }

        //Get Employee Count
        public static int GetEmpCount()
        {
            return Database.getCount("empCount");
        }

        //Get Employee Count
        public static int GetEmpMale()
        {
            return Database.getCount("empCountMale");
        }

        //Get Employee Count
        public static int GetEmpFemale()
        {
            return Database.getCount("empCountFemale");
        }

        //Get Total Salaries 
        public static int GetTotalSalaries()
        {
            return Database.getCount("totalSalaries");
        }
    }
}
