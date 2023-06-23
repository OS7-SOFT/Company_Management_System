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
    public partial class ManagementBudgt : Form
    {

        public ManagementBudgt()
        {
            InitializeComponent();
            //Connect Controls
            this.Capital = capitalValue;
            this.Save = btn_save;
            this.Cancel = btn_cancel;

            //Set Form shadow and animated
            this.Load += delegate
            {
                animated.SetAnimateWindow(this);
                shadow.SetShadowForm(this);
            };
        }

        public Guna2NumericUpDown Capital;
        public Guna2Button Save;
        public Guna2Button Cancel;
       
        
    }
}
