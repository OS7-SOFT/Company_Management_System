using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Management_System.Model
{
    public class ProjModel
    {
        private int projId;
        private string projName;
        private byte[] projImage;
        private string projStatus;
        private string projDate;
        private string projStartDate;
        private double workDuration;
        private int depNo;
        private double projCost;
        private double projRevenues;
        private double projProfits;
        private double projLosses;
        private string projDetails;


        //Propertes
        public int ProjId
        {
            get { return projId; }
            set { projId = value; }
        }
        public string ProjName
        {
            get { return projName; }
            set { projName = value; }
        }
        public byte[] ProjImage
        {
            get { return projImage; }
            set { projImage = value; }
        }
        public int DepNO
        {
            get { return depNo; }
            set { depNo = value; }
        }
        public string ProjStatus
        {
            get { return projStatus; }
            set { projStatus = value; }
        }
        public string ProjectDate
        {
            get { return projDate; }
            set { projDate = value; }
        }
        public string ProjStartDate
        {
            get { return projStartDate; }
            set { projStartDate = value; }
        }
        public double WorkDuration
        {
            get { return workDuration; }
            set { workDuration = value; }
        }
        
        public double ProjCost
        {
            get { return projCost; }
            set { projCost = value; }
        }
        public double ProjRevenues
        {
            get { return projRevenues; }
            set { projRevenues = value; }
        }
        public double ProjProfits
        {
            get { return projProfits; }
            set { projProfits = value; }
        }
        public double ProjLosses
        {
            get { return projLosses; }
            set { projLosses = value; }
        }
        public string ProjDetails
        {
            get { return projDetails; }
            set { projDetails = value; }
        }
    }
}
