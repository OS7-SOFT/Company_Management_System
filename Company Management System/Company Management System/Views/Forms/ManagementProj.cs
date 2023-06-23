using Bunifu.UI.WinForms;
using Guna.UI2.WinForms;
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

namespace Company_Management_System.Views.Forms
{
    public partial class ManagementProj : Form
    {
        public ManagementProj()
        {
            InitializeComponent();

            
            //connect fildes
            this.ProjName = txt_name;
            this.ProjImage = pic_box;
            this.DepNo = txt_depNo;
            this.ProjCost = txt_projCost;
            this.Complate = rb_complate;
            this.InProgress = rb_inProgress;
            this.ProjRevenues = txt_revenues;
            this.ProjStartDate = start_date; 
            this.ProjDetails = txt_details;
            //connect Event
            this.BtnSave = btn_save;
            this.BtnCancel = btn_cancel;


            perfomedEvents();
        }


        private void perfomedEvents()
        {
            //  when form loaded
            this.Load += delegate 
            {
                animate.SetAnimateWindow(this);
                checkStatus();
                txt_workDuration.Text = WorkDuration.ToString();
                shadow.SetShadowForm(this);
            };

            //To get work duration
            btn_save.Click += delegate 
            {
                if (rb_complate.Checked)
                    WorkDuration = txt_workDuration.Text.Trim() == "" ? 0 : Convert.ToDouble(txt_workDuration.Text);
                else
                    WorkDuration = calcWorkDuration();  
            };

            //Select image
            btn_select.Click += delegate
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "PNG & JPG Image | *.png ; *.jpg";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (ofd.ShowDialog() == DialogResult.OK)
                    pic_box.Image = new Bitmap(ofd.FileName);

            };

            //Delete image from picturbox
            btn_delete.Click += delegate { pic_box.Image = null; };

            //Check status and show hide panale
            rb_complate.CheckedChanged += delegate 
            {
                checkStatus();
            };



        }

        //Calculate Days
        private double calcWorkDuration()
        {
            DateTime start, end = new DateTime();
            start = start_date.Value;
            end = end_date.Value;
            return (end.Date - start.Date).TotalDays;
        }

        //check status to show and hide control and to get project date
        private void checkStatus()
        {
            if (rb_complate.Checked)
            {
                lbl_startDate.Visible = false;
                lbl_endDate.Visible = false;
                start_date.Visible = false;
                end_date.Visible = false;
                lbl_work.Visible = true;
                lbl_projDate.Visible = true;
                lbl_revenues.Visible = true;
                txt_workDuration.Visible = true;
                txt_revenues.Visible = true;
                project_date.Visible = true;

                ProjDate = project_date;
            }
            else
            {
                lbl_startDate.Visible = true;
                lbl_endDate.Visible = true;
                start_date.Visible = true;
                end_date.Visible = true;
                lbl_work.Visible = false;
                lbl_projDate.Visible = false;
                lbl_revenues.Visible = false;
                txt_workDuration.Visible = false;
                txt_revenues.Visible = false;
                project_date.Visible = false;

                ProjDate = end_date;
            }
        }

        //Check Project is Complete or not
        public bool IsComplate(DateTime currentDate)
        {
            if(currentDate.ToString("d") == DateTime.Now.ToString("d"))
                return true;
            else 
                return false;
        }

        //Get Photo 
        public byte[] GetPhoto()
        {
            if (pic_box.Image != Properties.Resources.Image)
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
                pic_box.Image = Properties.Resources.Image;
        }

        //Fildes
        public BunifuTextBox ProjName;
        public Guna2PictureBox ProjImage;
        public Guna2NumericUpDown DepNo;
        public Guna2NumericUpDown ProjCost;
        public BunifuRadioButton Complate;
        public BunifuRadioButton InProgress;
        public double WorkDuration;
        public Guna2NumericUpDown ProjRevenues;
        public BunifuDatePicker ProjDate;
        public BunifuDatePicker ProjStartDate;
        public RichTextBox ProjDetails;
        

        //Events 
        public Guna2Button BtnSave;
        public Guna2Button BtnCancel;

    }
}
