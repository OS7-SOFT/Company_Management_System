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
using Guna.UI2.WinForms;
namespace Company_Management_System
{
    
    public partial class Show_emp_info : Form
    {
        

        //constructor
        public Show_emp_info()
        {
            InitializeComponent();

            //Connect Fildes
            this.Id = lbl_id;
            this.empName = lbl_name;
            this.Age = lbl_age;
            this.Gender = lbl_gender;
            this.Phone = lbl_phone;
            this.Email = lbl_email;
            this.Address = lbl_address;
            this.JopTitle = lbl_jopTitle;
            this.Salary = lbl_salary;
            this.DepName = lbl_depName;
            //Connect Event
            this.BtnDelete = btn_delete;
            this.BtnEdit = btn_edit;
            this.BtnClose = btn_close;
            //When form Load
            this.Load += delegate
            {
                animate.SetAnimateWindow(this);
                shadow_form.SetShadowForm(this);
            };

        }

        //fildes
        public Label Id;
        public Label empName;
        public Label Age;
        public Label Gender;
        public Label Phone;
        public Label Email;
        public Label Address;
        public Label JopTitle;
        public Label Salary;
        public Label DepName;

        //events
        public Guna2Button BtnDelete;
        public Guna2Button BtnEdit;
        public Button BtnClose;

        //Set image in picturebox from database
        public void SetImage(byte[] value)
        {
            if (value != null)
            {
                MemoryStream ms = new MemoryStream(value);
                pic_box.Image = Image.FromStream(ms);
            }
            else
                pic_box.Image = Properties.Resources.account;
        }

        
    }
}
