using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Company_Management_System
{
    public partial class Main_Window : Form
    {



        //Constructor
        public Main_Window()
        {
            InitializeComponent();
            this.Size = new Size(1600, 926);

            //to execute event
            performEvent();

        }

        private void performEvent()
        {
            btn_home.Click += delegate { showUserControl(new Home_window()); changeActive(btn_home); };
            btn_budget.Click += delegate { showUserControl(budgetView.Instance()); budgetView.GetAllData(); changeActive(btn_budget); };
            btn_emp.Click += delegate { showUserControl(EmpView.Instance()); changeActive(btn_emp); };
            btn_proj.Click += delegate { showUserControl(ProjView.Instance()); changeActive(btn_proj); };
            btn_dep.Click += delegate { showUserControl(DepView.Instance()); DepView.GetAllData(); changeActive(btn_dep); };
            btn_report.Click += delegate { showUserControl(ReportView.Instance()); changeActive(btn_report); };
            btn_exit.Click += delegate { this.Close(); };
        }


      

        //change color active from icon
        private void changeActive(IconButton currentIcon )
        {
            foreach(IconButton icon in icon_content.Controls.OfType<IconButton>())
            {
               icon.IconColor = Color.FromArgb(64, 64, 64);
            }

            currentIcon.IconColor = Color.DodgerBlue;
            active.Top = currentIcon.Top;
        }

        //Method To Change Between User_Control in main_panel
        private void showUserControl(object userControl)
        {
            if (this.main_panel.Controls.Count > 0)
            {
                this.main_panel.Controls.Clear();
            }



            UserControl us = userControl as UserControl;

            us.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(us);
            this.main_panel.Tag = us;

            us.Show();

        }


    }
}
