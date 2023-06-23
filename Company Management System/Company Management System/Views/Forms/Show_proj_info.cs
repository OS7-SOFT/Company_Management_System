using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Guna.UI2.WinForms;

namespace Company_Management_System.Views.Forms
{
    public partial class Show_proj_info : Form
    {
        public Show_proj_info()
        {
            InitializeComponent();

           
           
            //connect fildes
            this.Id = lbl_id;
            this.ProjName = lbl_name;
            this.DepNO = lbl_departmen;
            this.ProjStatus = lbl_status;
            this.ProjStartDate = lbl_projDate;
            this.ProjDate = lbl_endDate;
            this.WorkDuration = lbl_workDuration;
            this.ProjCost = lbl_projCost;
            this.ProjRevenues = lbl_projRevenues;
            this.ProjProfit = lbl_profit;
            this.ProjLosses = lbl_losess;
            this.ProjDetails = txt_projDetails;
            //connect events
            this.Delete = btn_delete;
            this.Edit = btn_edit;
            this.Close = btn_close;

            Method();
        }

        private void Method()
        { 

            
            this.Load += delegate 
            {
                shadow.SetShadowForm(this);
                //Animate Window
                animWindow.SetAnimateWindow(this);
                //Check Status to show and hide element
                if (ProjStatus.Text == "In Progress")
                {
                    icon_cmplate.Visible = false;
                    icon_inProgress.Visible = true;
                    lbl_ProgressDetails.Visible = true;
                    lbl_endDate.Visible = true;

                    lbl_workDuration.Text = "Not Specified";
                    lbl_projRevenues.Text = "Not Specified";
                    lbl_profit.Text = "Not Specified";
                    lbl_losess.Text = "Not Specified";
                    lbl_titleDate.Text = "Start Date";
                    lbl_projDate.Text = ProjStartDate.Text;

                }
                else if (ProjStatus.Text == "Complete")
                {
                    icon_inProgress.Visible = false;
                    icon_cmplate.Visible = true;
                    lbl_ProgressDetails.Visible = false;
                    lbl_endDate.Visible = false;

                    lbl_titleDate.Text = "Project Date";
                    lbl_projDate.Text = ProjDate.Text;
                }

                //Check Details
                if(ProjDetails.Text.Trim() == "")
                    lbl_hint.Visible = true;
                else
                    lbl_hint.Visible = false;   

            };
        }

        

        //Fildes
        public Label Id;
        public Label ProjName;
        public Label DepNO;
        public Label ProjStatus;
        public Label ProjDate;
        public Label ProjStartDate;
        public Label WorkDuration;
        public Label ProjCost;
        public Label ProjRevenues;
        public Label ProjProfit;
        public Label ProjLosses;
        public RichTextBox ProjDetails;

        //events
        public Guna2Button Delete;
        public Guna2Button Edit;
        public Button Close;


        //Set image in picturebox from database
        public void SetImage(byte[] value)
        {
            if (value != null)
            {
                MemoryStream ms = new MemoryStream(value);
                pic_box.Image = Image.FromStream(ms);
            }
            else
                pic_box.Image = Properties.Resources.Image;
        }

        
    }
}
