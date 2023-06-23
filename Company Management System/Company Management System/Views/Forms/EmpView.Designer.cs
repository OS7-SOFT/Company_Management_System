namespace Company_Management_System
{
    partial class EmpView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpView));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.left_panel = new System.Windows.Forms.Panel();
            this.dgv_emp = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.top_panel = new System.Windows.Forms.Panel();
            this.btn_searchEmp = new FontAwesome.Sharp.IconButton();
            this.txt_SearchEmp = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.lbl_salaryYear = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_salaryMonth = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_salaryDay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_empMaleCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_empFemalCount = new System.Windows.Forms.Label();
            this.lbl_empCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.right_panel = new System.Windows.Forms.Panel();
            this.btn_deleteEmp = new Guna.UI2.WinForms.Guna2Button();
            this.btn_editEmp = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addEmp = new Guna.UI2.WinForms.Guna2Button();
            this.left_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emp)).BeginInit();
            this.top_panel.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // left_panel
            // 
            this.left_panel.Controls.Add(this.dgv_emp);
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.Location = new System.Drawing.Point(0, 338);
            this.left_panel.Name = "left_panel";
            this.left_panel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 15);
            this.left_panel.Size = new System.Drawing.Size(1598, 800);
            this.left_panel.TabIndex = 1;
            // 
            // dgv_emp
            // 
            this.dgv_emp.AllowCustomTheming = false;
            this.dgv_emp.AllowUserToAddRows = false;
            this.dgv_emp.AllowUserToDeleteRows = false;
            this.dgv_emp.AllowUserToResizeColumns = false;
            this.dgv_emp.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgv_emp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_emp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_emp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.dgv_emp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_emp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_emp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_emp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_emp.ColumnHeadersHeight = 40;
            this.dgv_emp.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_emp.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_emp.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_emp.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_emp.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_emp.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_emp.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_emp.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_emp.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_emp.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_emp.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv_emp.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_emp.CurrentTheme.Name = null;
            this.dgv_emp.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_emp.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_emp.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_emp.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_emp.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_emp.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_emp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_emp.EnableHeadersVisualStyles = false;
            this.dgv_emp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_emp.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_emp.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_emp.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_emp.Location = new System.Drawing.Point(15, 0);
            this.dgv_emp.Name = "dgv_emp";
            this.dgv_emp.ReadOnly = true;
            this.dgv_emp.RowHeadersVisible = false;
            this.dgv_emp.RowHeadersWidth = 51;
            this.dgv_emp.RowTemplate.Height = 40;
            this.dgv_emp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_emp.Size = new System.Drawing.Size(1583, 785);
            this.dgv_emp.TabIndex = 0;
            this.dgv_emp.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // top_panel
            // 
            this.top_panel.Controls.Add(this.btn_searchEmp);
            this.top_panel.Controls.Add(this.txt_SearchEmp);
            this.top_panel.Controls.Add(this.bunifuCards2);
            this.top_panel.Controls.Add(this.bunifuCards1);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 15);
            this.top_panel.Size = new System.Drawing.Size(1843, 338);
            this.top_panel.TabIndex = 1;
            // 
            // btn_searchEmp
            // 
            this.btn_searchEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_searchEmp.FlatAppearance.BorderSize = 0;
            this.btn_searchEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_searchEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_searchEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchEmp.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_searchEmp.IconColor = System.Drawing.Color.Black;
            this.btn_searchEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_searchEmp.Location = new System.Drawing.Point(1483, 264);
            this.btn_searchEmp.Name = "btn_searchEmp";
            this.btn_searchEmp.Size = new System.Drawing.Size(75, 56);
            this.btn_searchEmp.TabIndex = 4;
            this.btn_searchEmp.UseVisualStyleBackColor = true;
            // 
            // txt_SearchEmp
            // 
            this.txt_SearchEmp.AcceptsReturn = false;
            this.txt_SearchEmp.AcceptsTab = false;
            this.txt_SearchEmp.AnimationSpeed = 200;
            this.txt_SearchEmp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_SearchEmp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_SearchEmp.BackColor = System.Drawing.Color.Transparent;
            this.txt_SearchEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_SearchEmp.BackgroundImage")));
            this.txt_SearchEmp.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_SearchEmp.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_SearchEmp.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_SearchEmp.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_SearchEmp.BorderRadius = 20;
            this.txt_SearchEmp.BorderThickness = 0;
            this.txt_SearchEmp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_SearchEmp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchEmp.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchEmp.DefaultText = "";
            this.txt_SearchEmp.FillColor = System.Drawing.Color.AliceBlue;
            this.txt_SearchEmp.HideSelection = true;
            this.txt_SearchEmp.IconLeft = null;
            this.txt_SearchEmp.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchEmp.IconPadding = 10;
            this.txt_SearchEmp.IconRight = null;
            this.txt_SearchEmp.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchEmp.Lines = new string[0];
            this.txt_SearchEmp.Location = new System.Drawing.Point(750, 264);
            this.txt_SearchEmp.MaxLength = 32767;
            this.txt_SearchEmp.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_SearchEmp.Modified = false;
            this.txt_SearchEmp.Multiline = false;
            this.txt_SearchEmp.Name = "txt_SearchEmp";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_SearchEmp.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_SearchEmp.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_SearchEmp.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.AliceBlue;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_SearchEmp.OnIdleState = stateProperties8;
            this.txt_SearchEmp.Padding = new System.Windows.Forms.Padding(3);
            this.txt_SearchEmp.PasswordChar = '\0';
            this.txt_SearchEmp.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txt_SearchEmp.PlaceholderText = "Search Employee";
            this.txt_SearchEmp.ReadOnly = false;
            this.txt_SearchEmp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_SearchEmp.SelectedText = "";
            this.txt_SearchEmp.SelectionLength = 0;
            this.txt_SearchEmp.SelectionStart = 0;
            this.txt_SearchEmp.ShortcutsEnabled = true;
            this.txt_SearchEmp.Size = new System.Drawing.Size(727, 56);
            this.txt_SearchEmp.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_SearchEmp.TabIndex = 3;
            this.txt_SearchEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_SearchEmp.TextMarginBottom = 0;
            this.txt_SearchEmp.TextMarginLeft = 3;
            this.txt_SearchEmp.TextMarginTop = 0;
            this.txt_SearchEmp.TextPlaceholder = "Search Employee";
            this.txt_SearchEmp.UseSystemPasswordChar = false;
            this.txt_SearchEmp.WordWrap = true;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.DodgerBlue;
            this.bunifuCards2.Controls.Add(this.lbl_salaryYear);
            this.bunifuCards2.Controls.Add(this.label8);
            this.bunifuCards2.Controls.Add(this.lbl_salaryMonth);
            this.bunifuCards2.Controls.Add(this.label5);
            this.bunifuCards2.Controls.Add(this.lbl_salaryDay);
            this.bunifuCards2.Controls.Add(this.label3);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(453, 13);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 100;
            this.bunifuCards2.Size = new System.Drawing.Size(572, 179);
            this.bunifuCards2.TabIndex = 1;
            // 
            // lbl_salaryYear
            // 
            this.lbl_salaryYear.AutoSize = true;
            this.lbl_salaryYear.BackColor = System.Drawing.Color.Transparent;
            this.lbl_salaryYear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salaryYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_salaryYear.Location = new System.Drawing.Point(273, 114);
            this.lbl_salaryYear.Name = "lbl_salaryYear";
            this.lbl_salaryYear.Size = new System.Drawing.Size(80, 28);
            this.lbl_salaryYear.TabIndex = 8;
            this.lbl_salaryYear.Text = "$ 282M";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(14, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total Salaries  in year :";
            // 
            // lbl_salaryMonth
            // 
            this.lbl_salaryMonth.AutoSize = true;
            this.lbl_salaryMonth.BackColor = System.Drawing.Color.Transparent;
            this.lbl_salaryMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salaryMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_salaryMonth.Location = new System.Drawing.Point(273, 65);
            this.lbl_salaryMonth.Name = "lbl_salaryMonth";
            this.lbl_salaryMonth.Size = new System.Drawing.Size(96, 28);
            this.lbl_salaryMonth.TabIndex = 6;
            this.lbl_salaryMonth.Text = "$ 0.783M";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(14, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total Salaries  Per Month :";
            // 
            // lbl_salaryDay
            // 
            this.lbl_salaryDay.AutoSize = true;
            this.lbl_salaryDay.BackColor = System.Drawing.Color.Transparent;
            this.lbl_salaryDay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salaryDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_salaryDay.Location = new System.Drawing.Point(273, 20);
            this.lbl_salaryDay.Name = "lbl_salaryDay";
            this.lbl_salaryDay.Size = new System.Drawing.Size(85, 28);
            this.lbl_salaryDay.TabIndex = 4;
            this.lbl_salaryDay.Text = "$ 23.5M";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(14, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Salaries  Per Day :";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DodgerBlue;
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.lbl_empMaleCount);
            this.bunifuCards1.Controls.Add(this.label6);
            this.bunifuCards1.Controls.Add(this.lbl_empFemalCount);
            this.bunifuCards1.Controls.Add(this.lbl_empCount);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(15, 13);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 100;
            this.bunifuCards1.Size = new System.Drawing.Size(395, 179);
            this.bunifuCards1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(13, 117);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(188, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fmale                   :";
            // 
            // lbl_empMaleCount
            // 
            this.lbl_empMaleCount.AutoSize = true;
            this.lbl_empMaleCount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_empMaleCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empMaleCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_empMaleCount.Location = new System.Drawing.Point(274, 68);
            this.lbl_empMaleCount.Name = "lbl_empMaleCount";
            this.lbl_empMaleCount.Size = new System.Drawing.Size(50, 28);
            this.lbl_empMaleCount.TabIndex = 6;
            this.lbl_empMaleCount.Text = "1168";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(13, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Male                     :";
            // 
            // lbl_empFemalCount
            // 
            this.lbl_empFemalCount.AutoSize = true;
            this.lbl_empFemalCount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_empFemalCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empFemalCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_empFemalCount.Location = new System.Drawing.Point(271, 117);
            this.lbl_empFemalCount.Name = "lbl_empFemalCount";
            this.lbl_empFemalCount.Size = new System.Drawing.Size(53, 28);
            this.lbl_empFemalCount.TabIndex = 4;
            this.lbl_empFemalCount.Text = "1289";
            // 
            // lbl_empCount
            // 
            this.lbl_empCount.AutoSize = true;
            this.lbl_empCount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_empCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_empCount.Location = new System.Drawing.Point(274, 20);
            this.lbl_empCount.Name = "lbl_empCount";
            this.lbl_empCount.Size = new System.Drawing.Size(57, 28);
            this.lbl_empCount.TabIndex = 2;
            this.lbl_empCount.Text = "2457";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employees Count  :";
            // 
            // right_panel
            // 
            this.right_panel.Controls.Add(this.btn_deleteEmp);
            this.right_panel.Controls.Add(this.btn_editEmp);
            this.right_panel.Controls.Add(this.btn_addEmp);
            this.right_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right_panel.Location = new System.Drawing.Point(1598, 338);
            this.right_panel.Name = "right_panel";
            this.right_panel.Size = new System.Drawing.Size(245, 800);
            this.right_panel.TabIndex = 2;
            // 
            // btn_deleteEmp
            // 
            this.btn_deleteEmp.Animated = true;
            this.btn_deleteEmp.BorderRadius = 5;
            this.btn_deleteEmp.BorderThickness = 3;
            this.btn_deleteEmp.CheckedState.Parent = this.btn_deleteEmp;
            this.btn_deleteEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deleteEmp.CustomImages.Parent = this.btn_deleteEmp;
            this.btn_deleteEmp.FillColor = System.Drawing.Color.Transparent;
            this.btn_deleteEmp.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_deleteEmp.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_deleteEmp.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_deleteEmp.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.btn_deleteEmp.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteEmp.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_deleteEmp.HoverState.Parent = this.btn_deleteEmp;
            this.btn_deleteEmp.Location = new System.Drawing.Point(46, 227);
            this.btn_deleteEmp.Name = "btn_deleteEmp";
            this.btn_deleteEmp.ShadowDecoration.Parent = this.btn_deleteEmp;
            this.btn_deleteEmp.Size = new System.Drawing.Size(153, 55);
            this.btn_deleteEmp.TabIndex = 10;
            this.btn_deleteEmp.Text = "Delete";
            // 
            // btn_editEmp
            // 
            this.btn_editEmp.Animated = true;
            this.btn_editEmp.BorderRadius = 5;
            this.btn_editEmp.BorderThickness = 3;
            this.btn_editEmp.CheckedState.Parent = this.btn_editEmp;
            this.btn_editEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editEmp.CustomImages.Parent = this.btn_editEmp;
            this.btn_editEmp.FillColor = System.Drawing.Color.Transparent;
            this.btn_editEmp.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_editEmp.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_editEmp.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_editEmp.HoverState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_editEmp.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editEmp.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_editEmp.HoverState.Parent = this.btn_editEmp;
            this.btn_editEmp.Location = new System.Drawing.Point(46, 137);
            this.btn_editEmp.Name = "btn_editEmp";
            this.btn_editEmp.ShadowDecoration.Parent = this.btn_editEmp;
            this.btn_editEmp.Size = new System.Drawing.Size(153, 55);
            this.btn_editEmp.TabIndex = 9;
            this.btn_editEmp.Text = "Edit";
            // 
            // btn_addEmp
            // 
            this.btn_addEmp.Animated = true;
            this.btn_addEmp.BorderRadius = 5;
            this.btn_addEmp.BorderThickness = 3;
            this.btn_addEmp.CheckedState.Parent = this.btn_addEmp;
            this.btn_addEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addEmp.CustomImages.Parent = this.btn_addEmp;
            this.btn_addEmp.FillColor = System.Drawing.Color.Transparent;
            this.btn_addEmp.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_addEmp.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_addEmp.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_addEmp.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_addEmp.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addEmp.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_addEmp.HoverState.Parent = this.btn_addEmp;
            this.btn_addEmp.Location = new System.Drawing.Point(46, 47);
            this.btn_addEmp.Name = "btn_addEmp";
            this.btn_addEmp.ShadowDecoration.Parent = this.btn_addEmp;
            this.btn_addEmp.Size = new System.Drawing.Size(153, 55);
            this.btn_addEmp.TabIndex = 8;
            this.btn_addEmp.Text = "Add";
            // 
            // EmpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.right_panel);
            this.Controls.Add(this.left_panel);
            this.Controls.Add(this.top_panel);
            this.Name = "EmpView";
            this.Size = new System.Drawing.Size(1843, 1138);
            this.left_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emp)).EndInit();
            this.top_panel.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.right_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel left_panel;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel right_panel;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_emp;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.UI.WinForms.BunifuTextBox txt_SearchEmp;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_empCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_empMaleCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_empFemalCount;
        private System.Windows.Forms.Label lbl_salaryDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_salaryYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_salaryMonth;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btn_searchEmp;
        private Guna.UI2.WinForms.Guna2Button btn_addEmp;
        private Guna.UI2.WinForms.Guna2Button btn_deleteEmp;
        private Guna.UI2.WinForms.Guna2Button btn_editEmp;
    }
}
