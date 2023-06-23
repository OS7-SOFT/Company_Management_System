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
    public partial class Load_form : Form
    {
        public Load_form()
        {
            InitializeComponent();

            loading();
        }

        private void loading()
        {
            timer1.Tick += delegate
            {
                timer1.Enabled = true;
                progressBar1.Increment(3);
                if (progressBar1.Value == 100)
                {

                    Main_Window main = new Main_Window();
                    main.Show();
                    this.Close();
                    timer1.Stop();
                    timer1.Enabled = false;

                }
            };
        }

    }
}
