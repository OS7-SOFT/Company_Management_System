using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Management_System.Model
{
    public class DepModel
    {
        private int depNo;
        private string depName;
        private int managerId;
        private double budget;

        //Propertes
        public int DepNo
        {
            get { return depNo; }
            set { depNo = value; }
        }
        public string DepName
        {
            get { return depName; }
            set { depName = value; }
        }
        public int ManagerID
        {
            get { return managerId; }
            set { managerId = value; }
        }
        public double Budget
        {
            get { return budget; }
            set { budget = value; }
        }
    }
}
