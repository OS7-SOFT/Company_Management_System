using Company_Management_System.Logic.Presenter;
using Company_Management_System.Views.Forms;
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

namespace Company_Management_System
{
    public partial class ReportView : UserControl, IRepView
    {
        bool isSuccessful = false;
        bool isEdit;
        string message;
        string id;

        static RepPresenter repPresenter;

        Show_rep showRep = new Show_rep();
        ManagementRep manageRep = new ManagementRep();


        public ReportView()
        {
            InitializeComponent();
            //Size Window when program running
            this.Size = new Size(1580, 926);

            repPresenter = new RepPresenter(this);

            //to Perform method
            performMethod();
        }

        private void performMethod()
        {
            //Search
            btn_searchRep.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txt_searchRep.TextChange += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txt_searchRep.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            //Show Report
            dgv_Rep.DoubleClick += delegate
            {
                id = dgv_Rep.CurrentRow.Cells[0].Value.ToString();
                ShowReportContent?.Invoke(this, EventArgs.Empty);
                showRep.ShowDialog();

            };

            //Close Show Report form
            showRep.BtnClose.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                showRep.Close();
            };

            //Add Report 
            btn_addRep.Click += delegate
            {
                AddEvent?.Invoke(this, EventArgs.Empty);
                manageRep.ShowDialog();
            };

            //Edit Report
            btn_editRep.Click += delegate
            {
                id = dgv_Rep.CurrentRow.Cells[0].Value.ToString();
                EditEvent.Invoke(this, EventArgs.Empty);
                manageRep.ShowDialog();
            };

            showRep.BtnEdit.Click += delegate
            {
                id = dgv_Rep.CurrentRow.Cells[0].Value.ToString();
                EditEvent.Invoke(this, EventArgs.Empty);
                manageRep.ShowDialog();
                showRep.Close();
                
            };

            //Delete Report
            btn_deleteRep.Click += delegate
            {
                var result = MessageBox.Show($"Are you sure you want to delete ({dgv_Rep.CurrentRow.Cells[1].Value}) Report?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    id = dgv_Rep.CurrentRow.Cells[0].Value.ToString();
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(message, "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            };

            showRep.BtnDelete.Click += delegate
            {
                var result = MessageBox.Show($"Are you sure you want to delete ({dgv_Rep.CurrentRow.Cells[1].Value}) Report?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    id = dgv_Rep.CurrentRow.Cells[0].Value.ToString();
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(message, "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showRep.Close();
                }

            };

            //Save 
            manageRep.BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    manageRep.Close();
                    string title = isEdit != true ? "Add Report" : "Edit Report";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(message, "Error in input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            //Cancel 
            manageRep.BtnCancle.Click += delegate
            {
                CancelEvent.Invoke(this, EventArgs.Empty);
                manageRep.Close();
            };

        }


        //Properties
        public string Id { get { return id; } }
        public string Title
        {
            get { return manageRep.Title.Text; }
            set
            {
                manageRep.Title.Text = value;
                showRep.Title.Text = value;
            }
        }
        public string Content 
        {
            get { return manageRep.Content.Text; }
            set
            {
                manageRep.Content.Text = value;
                showRep.Content.Text = value;
            }
        }

        public string Date
        {
            get { return null; }
            set
            {
                showRep.Date.Text = value;
            }
        }

        public string ReportCount
        {
            get { return null; }
            set { lbl_repCount.Text = value; }
        }

        public string SearchValue 
        {
            get { return txt_searchRep.Text; }
            set { txt_searchRep.Text = value; }
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

       

        //events
        public event EventHandler SearchEvent;
        public event EventHandler AddEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler ShowReportContent;

        //Get All Reports
        public void SetDataReports(BindingSource reportList)
        {
           dgv_Rep.DataSource = reportList;
        }

        //Singelton Pattren 
        private static ReportView Object = null;
        public static ReportView Instance()
        {
            if (Object == null)
                Object = new ReportView();
            return Object;
        }
    }
}
