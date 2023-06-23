using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Bunifu.UI.WinForms;
using Bunifu.Framework.UI;
using Guna.UI2.WinForms;
using Company_Management_System.Views.Interface;
using Company_Management_System.Logic.Presenter;
using Company_Management_System.Views.Forms;

namespace Company_Management_System
{
    public partial class ProjView : UserControl, IProjView
    {
        private string id;
        private string message;
        private bool isSuccessful;
        private bool isEdit;


        ProjPresenter projPresenter;
        ManagementProj manageProj = new ManagementProj();
        Show_proj_info showProj = new Show_proj_info();

        //Constructor
        public ProjView()
        {
            InitializeComponent();
            //Size Window when program running
            this.Size = new Size(1580, 926);
            projPresenter = new ProjPresenter(this);
            //
            perfomedEvents();
            

        }


        
        private void perfomedEvents()
        {
            //to check if any project is complated
            this.Load += delegate { CheckProjectIsComplete(); };

            //Search Project
            btn_searchProj.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txt_searchProj.TextChange += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txt_searchProj.KeyDown += (sawd, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            //Show Project Info
            dgv_proj.DoubleClick += delegate
            {
                id = dgv_proj.CurrentRow.Cells[0].Value.ToString();
                ShowProjInfoEvent?.Invoke(this, EventArgs.Empty);
                showProj.ShowDialog();
            };
            //Close showproject form
            showProj.Close.Click += delegate 
            {
                showProj.Close();
                CancelEvent?.Invoke(this, EventArgs.Empty);
            };

            //Add Project
            btn_addProj.Click += delegate
            {
                AddEvent?.Invoke(this, EventArgs.Empty);
                manageProj.ShowDialog();
            };

            //Edit Project
            btn_editProj.Click += delegate
            {
                id = dgv_proj.CurrentRow.Cells[0].Value.ToString();
                EditEvent?.Invoke(this, EventArgs.Empty);
                manageProj.ShowDialog();

            };
            showProj.Edit.Click += delegate
            {
                id = dgv_proj.CurrentRow.Cells[0].Value.ToString();
                EditEvent?.Invoke(this, EventArgs.Empty);
                manageProj.ShowDialog();
                showProj.Close();

            };

            //Delete Project
            btn_deleteProj.Click += delegate
            {
                var result = MessageBox.Show($"Are you sure you want to delete ({dgv_proj.CurrentRow.Cells[1].Value}) Project ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    id = dgv_proj.CurrentRow.Cells[0].Value.ToString();
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(message, "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            showProj.Delete.Click += delegate
            {
                var result = MessageBox.Show($"Are you sure you want to delete ({dgv_proj.CurrentRow.Cells[1].Value}) Project ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    id = dgv_proj.CurrentRow.Cells[0].Value.ToString();
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(message, "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showProj.Close();
                }
            };

            ////Save 
            manageProj.BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    string title = isEdit != true ? "Add Department" : "Edit Department";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    manageProj.Close();
                }
                else
                    MessageBox.Show(message, "Error in input", MessageBoxButtons.OK, MessageBoxIcon.Error);

            };

            //Cancel
            manageProj.BtnCancel.Click += delegate
            {

                CancelEvent?.Invoke(this, EventArgs.Empty);
                manageProj.Close();
            };

        }


        //Propertes
        public string Id
        {
            get { return id; }
            set { showProj.Id.Text = value; }
        }
        public string ProjName
        {
            get { return manageProj.ProjName.Text; }
            set
            {
                manageProj.ProjName.Text = value;
                showProj.ProjName.Text = value;
            }
        }
        public byte[] ProjImage
        {
            get { return manageProj.GetPhoto(); }
            set
            {
                manageProj.SetImage(value);
                showProj.SetImage(value);
            }
        }
        public string DepNo
        {
            get { return manageProj.DepNo.Text; }
            set
            {
                manageProj.DepNo.Text = value;
                showProj.DepNO.Text = value;
            }
        }
        public bool ProjStatus
        {
            get { return manageProj.Complate.Checked; }
            set
            {
                manageProj.Complate.Checked= value;
                manageProj.InProgress.Checked= !value;
                showProj.ProjStatus.Text = value ? "Complete" : "In Progress";
            }
        }
        public string ProjStartDate
        {
            get { return manageProj.ProjStartDate.Value.ToString(); }
            set
            {
                manageProj.ProjStartDate.Value = Convert.ToDateTime(value);
                showProj.ProjStartDate.Text = value;
            }
        }
        public string ProjDate
        {
            get { return manageProj.ProjDate.Value.ToString(); }
            set 
            { 
                manageProj.ProjDate.Value = Convert.ToDateTime(value);
                showProj.ProjDate.Text = value;
            }
        }
        public double WorkDuration
        {
            get { return manageProj.WorkDuration; }
            set
            {
                manageProj.WorkDuration = value;
                showProj.WorkDuration.Text = value.ToString();
            }
        }
        public string ProjCost
        {
            get { return manageProj.ProjCost.Text; }
            set
            {
                manageProj.ProjCost.Text = value;
                showProj.ProjCost.Text = "$"+value;
            }
        }
        public string ProjRevenues
        {
            get { return manageProj.ProjRevenues.Text;  }
            set
            {
                manageProj.ProjRevenues.Text = value;
                showProj.ProjRevenues.Text = "$" + value;
            }
        }
        public string ProjProfits
        {
            get { return null; }
            set { showProj.ProjProfit.Text = "$" + value; }
        }
        public string ProjLosses
        {
            get { return null; }
            set { showProj.ProjLosses.Text = "$" + value; }   
        }
        public string ProjDetails
        {
            get { return manageProj.ProjDetails.Text; }
            set
            {
                manageProj.ProjDetails.Text = value;
                showProj.ProjDetails.Text = value;
            }
        }
        public string SearchValue
        {
            get { return txt_searchProj.Text; }
            set { txt_searchProj.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }




        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler ShowProjInfoEvent;
        public event EventHandler ProjectComplete;
        public event EventHandler ExtendProjectTime;

        //Methodes
        public void SetDataProject(BindingSource projlist)
        {
            dgv_proj.DataSource = projlist;
        }

        //Check if any project complete 
        private void CheckProjectIsComplete()
        {
            for (int i = 0; i < dgv_proj.Rows.Count; i++)
            {
                string status = dgv_proj.Rows[i].Cells[3].Value.ToString();
                DateTime currentDate = Convert.ToDateTime(dgv_proj.Rows[i].Cells[4].Value);
                if (status == "In Progres" && currentDate.ToString("d") == DateTime.Now.ToString("d"))
                {
                    
                    var result = MessageBox.Show($"IS Complate ({ dgv_proj.Rows[i].Cells[1].Value.ToString()}) Project ?", "Project Complete Today", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    id = dgv_proj.Rows[i].Cells[0].Value.ToString();
                    EditEvent?.Invoke(this, EventArgs.Empty);
                    if (result == DialogResult.Yes)
                    {

                        foreach (Control item in manageProj.Controls)
                        {
                            if (item.Name == "rb_complate")
                                ((BunifuRadioButton)item).Checked = true;
                        }

                        foreach (Control item in manageProj.Controls)
                        {
                            if (item.Name == "txt_revenues" || item.Name == "btn_save" || item.Name == "btn_cancel")
                                continue;
                            item.Enabled = false;
                        }
                        
                        
                    }
                    else if (result == DialogResult.No)
                    {
                        foreach (Control item in manageProj.Controls)
                        {
                            if (item.Name == "end_date" || item.Name == "btn_save" || item.Name == "btn_cancel")
                                continue;
                            item.Enabled = false;
                        }
                    }
                    manageProj.ShowDialog();
                }
            }
            foreach (Control item in manageProj.Controls)
            {
                item.Enabled = true;
            }

        }


        //Singelton Pattren 
        private static ProjView Object = null;
        public static ProjView Instance()
        {
            if (Object == null)
                Object = new ProjView();
            return Object;
        }

    }
}
