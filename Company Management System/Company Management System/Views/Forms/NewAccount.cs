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
using Guna.UI2.WinForms;

namespace Company_Management_System.Views.Forms
{
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
            //connect fildes
            this.UserName = txt_userName;
            this.Password = txt_password;
            this.confirmPassword = txt_confirmPass;

            //Event
            this.BtnSave = btn_save;
            this.BtnCancel = btn_cancel;


            //when form load
            this.Load += delegate
            {
                animateWindow.SetAnimateWindow(this);
                shadow.SetShadowForm(this);
            };

        }

        public BunifuTextBox UserName { get; set; }
        public BunifuTextBox Password { get; set; }
        public BunifuTextBox confirmPassword { get; set; }
        public Guna2Button BtnSave { get; set; }
        public Guna2Button BtnCancel { get; set; }

     
    }

}
