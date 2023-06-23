using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Bunifu.UI.WinForms;


namespace Company_Management_System.Views.Forms
{
    public partial class ShowDepInfo : Form
    {
        public ShowDepInfo()
        {
            InitializeComponent();
            //connect fildes
            this.DgvStaff = dgvStaff;
            this.DgvProj = dgvProj;
            this.DepNo = lbl_depNo;
            this.DepName = lbl_depName;
            this.Manager = lbl_manager;
            this.DepBudget = lbl_budget;
            this.CurrentBudget = lbl_currentBudget;
            this.EmpCount = lbl_empCount;
            this.ProjCount = lbl_projCount;
            this.Profit = lbl_profit;
            this.Losses = lbl_losses;
            this.TotalProjCost = lbl_totalProjCost;
            this.TotalSalaries = lbl_totalSalaries; 
            //connect event
            this.BtnSearchStaff = btn_searchStaff;
            this.txtSearchStaff = txt_searchStaff;
            this.BtnSearchProj = btn_searchProj;
            this.txtSearchProj = txt_searchProj;
            this.BtnClose = btn_close;

            //when Form Load
            this.Load += delegate
            {
                animate.SetAnimateWindow(this);
                shadow.SetShadowForm(this);
            };
        }

        //Fildes
        public DataGridView DgvStaff;
        public DataGridView DgvProj;
        public Label DepNo;
        public Label DepName;
        public Label Manager;
        public Label DepBudget;
        public Label CurrentBudget;
        public Label Profit;
        public Label Losses;
        public Label TotalProjCost;
        public Label TotalSalaries;
        public Label EmpCount;
        public Label ProjCount;

        //Event
        public Button BtnSearchStaff;
        public Button BtnSearchProj;
        public Button BtnClose;
        public BunifuTextBox txtSearchStaff;
        public BunifuTextBox txtSearchProj;

    }
}
