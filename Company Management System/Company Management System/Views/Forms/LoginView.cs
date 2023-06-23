using Company_Management_System.Logic.Presenter;
using Company_Management_System.Views.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company_Management_System.Views.Forms
{
    public partial class LoginView : Form, ILoginView
    {
        public static bool isLogged;
        string message;


        LoginPresenter loginPresenter;

        public LoginView()
        {
            InitializeComponent();
            loginPresenter = new LoginPresenter(this);
            performLogin();
        }



        private void performLogin()
        {
            btn_login.Click += delegate
            {
                Login?.Invoke(this, EventArgs.Empty);
                if (isLogged)
                {
                    this.Close();

                }
                else
                    MessageBox.Show(message, "Error in input", MessageBoxButtons.OK, MessageBoxIcon.Error);

            };
            btn_cancel.Click += delegate
            {
                this.Close();
            };

        }


        public string UserName { get { return txt_userName.Text; } }
        public string Password { get { return txt_password.Text; } }
        public bool IsLogged { get { return isLogged; } set { isLogged = value; } }
        public string Message { get { return message; } set { message = value; } }

        //Event
        public event EventHandler Login;

        
    }
}
