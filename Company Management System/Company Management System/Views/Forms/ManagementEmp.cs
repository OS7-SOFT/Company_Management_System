using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Guna.UI2.WinForms;
using System.Text.RegularExpressions;
using Company_Management_System.Logic.Servics;

namespace Company_Management_System
{
    public partial class ManagementEmp : Form
    {

        private string message;

        //Constructor
        public ManagementEmp()
        {
            InitializeComponent();
            //fildes
            this.empName = txt_name;
            this.Age = ageValue;
            this.Male = rb_male;
            this.Female = rb_female;
            this.Photo = pic_box;
            this.Phone = phoneValue;
            this.Email = txt_email; 
            this.Address = txt_address;
            this.JopTitl = txt_jopTitle;
            this.Salary = salaryValue;
            this.DepNo = depNoValue;
            //event
            this.btnSave = btn_save;
            this.btnCancel = btn_cancel;
            //
            perfomedEvents();
           
        }

        //Select image
        private void perfomedEvents()
        {
            //form load
            this.Load += delegate 
            {
                animated.SetAnimateWindow(this);
                shadow.SetShadowForm(this);
                
            };

            txt_name.KeyDown += (s,e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    Email.Focus();
            };

            Email.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    JopTitl.Focus();
            };

            JopTitl.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    txt_address.Focus();
            };

            //Select image
            btn_selcet.Click += delegate
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "PNG & JPG Image | *.png ; *.jpg";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (ofd.ShowDialog() == DialogResult.OK)
                    pic_box.Image = new Bitmap(ofd.FileName);
            };

            //Delete image from picturbox
            btn_imageDelete.Click += delegate { pic_box.Image = null; };

            //Refresh fildes
            btn_refresh.Click += delegate
            {
                foreach(Control c in this.Controls)
                {
                    ((BunifuTextBox)c).Text = null;
                    ((Guna2NumericUpDown)c).Value = 0;
                }
                    
              
            };
        }

        // fildes
        public BunifuTextBox empName;
        public Guna2NumericUpDown Age;
        public Guna2CustomRadioButton Male;
        public Guna2CustomRadioButton Female;
        public Guna2PictureBox Photo;
        public Guna2NumericUpDown Phone;
        public BunifuTextBox Email;
        public BunifuTextBox Address;
        public BunifuTextBox JopTitl;
        public Guna2NumericUpDown Salary;
        public Guna2NumericUpDown DepNo;

        //event
        public Guna2Button btnSave;
        public Guna2Button btnCancel;

        //Get Photo 
        public byte[] GetPhoto()
        {
            if(pic_box.Image != Properties.Resources.account) 
            {
                MemoryStream ms = new MemoryStream();
                pic_box.Image.Save(ms, pic_box.Image.RawFormat);
                return ms.GetBuffer();
            }
            else
            {
                return null;
            }
            
        }

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
