using Bunifu.UI.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company_Management_System
{
    public partial class ManagementDep : Form
    {

        public ManagementDep()
        {
            InitializeComponent();
            //Connect fildes
            this.DepName = txt_depName;
            this.ManagerID = managerIdValue;
            this.Budget = budgetValue;
            //Connect event
            this.Save = btn_save;
            this.Cancel = btn_cancel;

            //when form loaded
            this.Load += delegate 
            {
                animate.SetAnimateWindow(this);
                shadow.SetShadowForm(this);
            };
            
        }

        //fildes
        public BunifuTextBox DepName;
        public Guna2NumericUpDown ManagerID;
        public Guna2NumericUpDown Budget;
        //Events
        public Guna2Button Save;
        public Guna2Button Cancel;

      
    }
}
