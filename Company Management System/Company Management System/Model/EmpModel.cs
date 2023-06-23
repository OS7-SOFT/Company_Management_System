using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Management_System.Model
{
    public class EmpModel
    {
        private int id;
        private string name;
        private int age;
        private string gender;
        private byte[] photo;
        private double phone;
        private string email;
        private string address;
        private string jopTitl;
        private double salary;
        private int  depNo;

        //Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public byte[] Photo
        {
            get { return photo; }
            set { photo = value; }
        }
        public double Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string JopTitl
        {
            get { return jopTitl; }
            set { jopTitl = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public int DepNo
        {
            get { return depNo; }
            set { depNo = value; }
        }

    }
}
