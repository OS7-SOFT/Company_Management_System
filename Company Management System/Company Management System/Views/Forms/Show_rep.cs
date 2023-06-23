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

namespace Company_Management_System.Views.Forms
{
    public partial class Show_rep : Form
    {
        public Show_rep()
        {
            InitializeComponent();
            //connect Fildes
            this.Content = txt_Content;
            this.Title = lbl_title;
            this.Date = lbl_date;

            //connect event
            this.BtnClose = btn_close;
            this.BtnEdit = btn_edit;
            this.BtnDelete = btn_delete;

            //set shadow and animate window
            this.Load += delegate
            {
                animateWindow.SetAnimateWindow(this);
                shadow.SetShadowForm(this);
            };
        }

        //Fileds
        public Label Title;
        public Label Date;
        public RichTextBox Content;

        //Event
        public Button BtnClose;
        public Guna2Button BtnEdit;
        public Guna2Button BtnDelete;



    }
}
