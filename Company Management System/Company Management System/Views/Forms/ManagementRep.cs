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
using Bunifu.UI.WinForms;

namespace Company_Management_System.Views.Forms
{
    public partial class ManagementRep : Form
    {
        public ManagementRep()
        {
            InitializeComponent();

            //connect Fildes
            this.Content = txt_content;
            this.Title = txt_RepTitle;

            //connect event
            this.BtnCancle = btn_cancel;
            this.BtnSave = btn_save;

            //set shadow and animate window
            this.Load += delegate
            {
                animateWindow.SetAnimateWindow(this);
                shadow.SetShadowForm(this);
            };

            //to refresh textBox
            btn_refresh.Click += delegate {

                txt_RepTitle.Text = "";
                txt_content.Text = "";

            };
        }


        //Fileds
        public BunifuTextBox Title;
        public RichTextBox Content;

        //Event
        public Guna2Button BtnCancle;
        public Guna2Button BtnSave;
    }
}
