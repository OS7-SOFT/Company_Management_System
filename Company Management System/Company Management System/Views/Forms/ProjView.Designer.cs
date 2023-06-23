namespace Company_Management_System
{
    partial class ProjView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjView));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.top_panel = new System.Windows.Forms.Panel();
            this.btn_searchProj = new FontAwesome.Sharp.IconButton();
            this.txt_searchProj = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.lbl_empBudjed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_DepCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.right_panel = new System.Windows.Forms.Panel();
            this.btn_deleteProj = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addProj = new Guna.UI2.WinForms.Guna2Button();
            this.btn_editProj = new Guna.UI2.WinForms.Guna2Button();
            this.left_panel = new System.Windows.Forms.Panel();
            this.dgv_proj = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.top_panel.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.left_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proj)).BeginInit();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.AliceBlue;
            this.top_panel.Controls.Add(this.btn_searchProj);
            this.top_panel.Controls.Add(this.txt_searchProj);
            this.top_panel.Controls.Add(this.bunifuCards1);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 15);
            this.top_panel.Size = new System.Drawing.Size(1843, 338);
            this.top_panel.TabIndex = 8;
            // 
            // btn_searchProj
            // 
            this.btn_searchProj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_searchProj.FlatAppearance.BorderSize = 0;
            this.btn_searchProj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_searchProj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_searchProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchProj.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_searchProj.IconColor = System.Drawing.Color.Black;
            this.btn_searchProj.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_searchProj.Location = new System.Drawing.Point(1483, 264);
            this.btn_searchProj.Name = "btn_searchProj";
            this.btn_searchProj.Size = new System.Drawing.Size(75, 56);
            this.btn_searchProj.TabIndex = 4;
            this.btn_searchProj.UseVisualStyleBackColor = true;
            // 
            // txt_searchProj
            // 
            this.txt_searchProj.AcceptsReturn = false;
            this.txt_searchProj.AcceptsTab = false;
            this.txt_searchProj.AnimationSpeed = 200;
            this.txt_searchProj.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_searchProj.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_searchProj.BackColor = System.Drawing.Color.Transparent;
            this.txt_searchProj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_searchProj.BackgroundImage")));
            this.txt_searchProj.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_searchProj.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_searchProj.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_searchProj.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_searchProj.BorderRadius = 20;
            this.txt_searchProj.BorderThickness = 0;
            this.txt_searchProj.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_searchProj.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_searchProj.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchProj.DefaultText = "";
            this.txt_searchProj.FillColor = System.Drawing.Color.AliceBlue;
            this.txt_searchProj.HideSelection = true;
            this.txt_searchProj.IconLeft = null;
            this.txt_searchProj.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_searchProj.IconPadding = 10;
            this.txt_searchProj.IconRight = null;
            this.txt_searchProj.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_searchProj.Lines = new string[0];
            this.txt_searchProj.Location = new System.Drawing.Point(750, 264);
            this.txt_searchProj.MaxLength = 32767;
            this.txt_searchProj.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_searchProj.Modified = false;
            this.txt_searchProj.Multiline = false;
            this.txt_searchProj.Name = "txt_searchProj";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_searchProj.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_searchProj.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_searchProj.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.AliceBlue;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_searchProj.OnIdleState = stateProperties4;
            this.txt_searchProj.Padding = new System.Windows.Forms.Padding(3);
            this.txt_searchProj.PasswordChar = '\0';
            this.txt_searchProj.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txt_searchProj.PlaceholderText = "Search Project";
            this.txt_searchProj.ReadOnly = false;
            this.txt_searchProj.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_searchProj.SelectedText = "";
            this.txt_searchProj.SelectionLength = 0;
            this.txt_searchProj.SelectionStart = 0;
            this.txt_searchProj.ShortcutsEnabled = true;
            this.txt_searchProj.Size = new System.Drawing.Size(727, 56);
            this.txt_searchProj.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_searchProj.TabIndex = 3;
            this.txt_searchProj.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_searchProj.TextMarginBottom = 0;
            this.txt_searchProj.TextMarginLeft = 3;
            this.txt_searchProj.TextMarginTop = 0;
            this.txt_searchProj.TextPlaceholder = "Search Project";
            this.txt_searchProj.UseSystemPasswordChar = false;
            this.txt_searchProj.WordWrap = true;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DodgerBlue;
            this.bunifuCards1.Controls.Add(this.lbl_empBudjed);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.lbl_DepCount);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(15, 13);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 100;
            this.bunifuCards1.Size = new System.Drawing.Size(454, 138);
            this.bunifuCards1.TabIndex = 0;
            // 
            // lbl_empBudjed
            // 
            this.lbl_empBudjed.AutoSize = true;
            this.lbl_empBudjed.BackColor = System.Drawing.Color.Transparent;
            this.lbl_empBudjed.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empBudjed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_empBudjed.Location = new System.Drawing.Point(345, 73);
            this.lbl_empBudjed.Name = "lbl_empBudjed";
            this.lbl_empBudjed.Size = new System.Drawing.Size(56, 28);
            this.lbl_empBudjed.TabIndex = 4;
            this.lbl_empBudjed.Text = "650$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total  Budget of Departments :";
            // 
            // lbl_DepCount
            // 
            this.lbl_DepCount.AutoSize = true;
            this.lbl_DepCount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DepCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DepCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_DepCount.Location = new System.Drawing.Point(270, 17);
            this.lbl_DepCount.Name = "lbl_DepCount";
            this.lbl_DepCount.Size = new System.Drawing.Size(31, 28);
            this.lbl_DepCount.TabIndex = 2;
            this.lbl_DepCount.Text = "15";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Departments :";
            // 
            // right_panel
            // 
            this.right_panel.BackColor = System.Drawing.Color.AliceBlue;
            this.right_panel.Controls.Add(this.btn_deleteProj);
            this.right_panel.Controls.Add(this.btn_addProj);
            this.right_panel.Controls.Add(this.btn_editProj);
            this.right_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.right_panel.Location = new System.Drawing.Point(1604, 338);
            this.right_panel.Name = "right_panel";
            this.right_panel.Size = new System.Drawing.Size(239, 800);
            this.right_panel.TabIndex = 9;
            // 
            // btn_deleteProj
            // 
            this.btn_deleteProj.Animated = true;
            this.btn_deleteProj.BorderRadius = 5;
            this.btn_deleteProj.BorderThickness = 3;
            this.btn_deleteProj.CheckedState.Parent = this.btn_deleteProj;
            this.btn_deleteProj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deleteProj.CustomImages.Parent = this.btn_deleteProj;
            this.btn_deleteProj.FillColor = System.Drawing.Color.Transparent;
            this.btn_deleteProj.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteProj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_deleteProj.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_deleteProj.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_deleteProj.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.btn_deleteProj.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteProj.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_deleteProj.HoverState.Parent = this.btn_deleteProj;
            this.btn_deleteProj.Location = new System.Drawing.Point(43, 221);
            this.btn_deleteProj.Name = "btn_deleteProj";
            this.btn_deleteProj.ShadowDecoration.Parent = this.btn_deleteProj;
            this.btn_deleteProj.Size = new System.Drawing.Size(153, 55);
            this.btn_deleteProj.TabIndex = 16;
            this.btn_deleteProj.Text = "Delete";
            // 
            // btn_addProj
            // 
            this.btn_addProj.Animated = true;
            this.btn_addProj.BorderRadius = 5;
            this.btn_addProj.BorderThickness = 3;
            this.btn_addProj.CheckedState.Parent = this.btn_addProj;
            this.btn_addProj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addProj.CustomImages.Parent = this.btn_addProj;
            this.btn_addProj.FillColor = System.Drawing.Color.Transparent;
            this.btn_addProj.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addProj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_addProj.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_addProj.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_addProj.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_addProj.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addProj.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_addProj.HoverState.Parent = this.btn_addProj;
            this.btn_addProj.Location = new System.Drawing.Point(43, 41);
            this.btn_addProj.Name = "btn_addProj";
            this.btn_addProj.ShadowDecoration.Parent = this.btn_addProj;
            this.btn_addProj.Size = new System.Drawing.Size(153, 55);
            this.btn_addProj.TabIndex = 14;
            this.btn_addProj.Text = "Add";
            // 
            // btn_editProj
            // 
            this.btn_editProj.Animated = true;
            this.btn_editProj.BorderRadius = 5;
            this.btn_editProj.BorderThickness = 3;
            this.btn_editProj.CheckedState.Parent = this.btn_editProj;
            this.btn_editProj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editProj.CustomImages.Parent = this.btn_editProj;
            this.btn_editProj.FillColor = System.Drawing.Color.Transparent;
            this.btn_editProj.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editProj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_editProj.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_editProj.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_editProj.HoverState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_editProj.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editProj.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_editProj.HoverState.Parent = this.btn_editProj;
            this.btn_editProj.Location = new System.Drawing.Point(43, 131);
            this.btn_editProj.Name = "btn_editProj";
            this.btn_editProj.ShadowDecoration.Parent = this.btn_editProj;
            this.btn_editProj.Size = new System.Drawing.Size(153, 55);
            this.btn_editProj.TabIndex = 15;
            this.btn_editProj.Text = "Edit";
            // 
            // left_panel
            // 
            this.left_panel.BackColor = System.Drawing.Color.AliceBlue;
            this.left_panel.Controls.Add(this.dgv_proj);
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.Location = new System.Drawing.Point(0, 338);
            this.left_panel.Name = "left_panel";
            this.left_panel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 15);
            this.left_panel.Size = new System.Drawing.Size(1598, 800);
            this.left_panel.TabIndex = 10;
            // 
            // dgv_proj
            // 
            this.dgv_proj.AllowCustomTheming = false;
            this.dgv_proj.AllowUserToAddRows = false;
            this.dgv_proj.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_proj.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_proj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_proj.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.dgv_proj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_proj.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_proj.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_proj.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_proj.ColumnHeadersHeight = 40;
            this.dgv_proj.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_proj.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_proj.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_proj.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_proj.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_proj.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_proj.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_proj.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_proj.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_proj.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_proj.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv_proj.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_proj.CurrentTheme.Name = null;
            this.dgv_proj.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_proj.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_proj.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_proj.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_proj.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_proj.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_proj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_proj.EnableHeadersVisualStyles = false;
            this.dgv_proj.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_proj.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_proj.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_proj.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_proj.Location = new System.Drawing.Point(15, 0);
            this.dgv_proj.Name = "dgv_proj";
            this.dgv_proj.ReadOnly = true;
            this.dgv_proj.RowHeadersVisible = false;
            this.dgv_proj.RowHeadersWidth = 51;
            this.dgv_proj.RowTemplate.Height = 40;
            this.dgv_proj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_proj.Size = new System.Drawing.Size(1583, 785);
            this.dgv_proj.TabIndex = 0;
            this.dgv_proj.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // ProjView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.left_panel);
            this.Controls.Add(this.right_panel);
            this.Controls.Add(this.top_panel);
            this.Name = "ProjView";
            this.Size = new System.Drawing.Size(1843, 1138);
            this.top_panel.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.right_panel.ResumeLayout(false);
            this.left_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private FontAwesome.Sharp.IconButton btn_searchProj;
        private Bunifu.UI.WinForms.BunifuTextBox txt_searchProj;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label lbl_empBudjed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_DepCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel right_panel;
        private System.Windows.Forms.Panel left_panel;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_proj;
        private Guna.UI2.WinForms.Guna2Button btn_deleteProj;
        private Guna.UI2.WinForms.Guna2Button btn_addProj;
        private Guna.UI2.WinForms.Guna2Button btn_editProj;
    }
}
