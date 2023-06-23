namespace Company_Management_System
{
    partial class Main_Window
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Window));
            this.anim_userControl = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.main_panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.SideBar_panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.icon_content = new System.Windows.Forms.Panel();
            this.active = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_home = new FontAwesome.Sharp.IconButton();
            this.btn_emp = new FontAwesome.Sharp.IconButton();
            this.btn_dep = new FontAwesome.Sharp.IconButton();
            this.btn_proj = new FontAwesome.Sharp.IconButton();
            this.btn_report = new FontAwesome.Sharp.IconButton();
            this.btn_budget = new FontAwesome.Sharp.IconButton();
            this.btn_exit = new FontAwesome.Sharp.IconButton();
            this.icon_company = new System.Windows.Forms.PictureBox();
            this.lbl_companyName = new System.Windows.Forms.Label();
            this.lbl_companyName1 = new System.Windows.Forms.Label();
            this.changeColor = new Bunifu.UI.WinForms.BunifuColorTransition(this.components);
            this.shadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ganimation = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.home_window1 = new Company_Management_System.Home_window();
            this.main_panel.SuspendLayout();
            this.SideBar_panel.SuspendLayout();
            this.icon_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_company)).BeginInit();
            this.SuspendLayout();
            // 
            // anim_userControl
            // 
            this.anim_userControl.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Scale;
            this.anim_userControl.Cursor = System.Windows.Forms.Cursors.AppStarting;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.anim_userControl.DefaultAnimation = animation1;
            this.anim_userControl.TimeStep = 0.08F;
            // 
            // main_panel
            // 
            this.main_panel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.main_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("main_panel.BackgroundImage")));
            this.main_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_panel.BorderColor = System.Drawing.Color.Transparent;
            this.main_panel.BorderRadius = 3;
            this.main_panel.BorderThickness = 1;
            this.main_panel.Controls.Add(this.home_window1);
            this.anim_userControl.SetDecoration(this.main_panel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(100, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.ShowBorders = true;
            this.main_panel.Size = new System.Drawing.Size(1818, 1028);
            this.main_panel.TabIndex = 11;
            // 
            // SideBar_panel
            // 
            this.SideBar_panel.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SideBar_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SideBar_panel.BackgroundImage")));
            this.SideBar_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SideBar_panel.BorderColor = System.Drawing.Color.DarkGray;
            this.SideBar_panel.BorderRadius = 10;
            this.SideBar_panel.BorderThickness = 2;
            this.SideBar_panel.Controls.Add(this.icon_content);
            this.SideBar_panel.Controls.Add(this.btn_exit);
            this.SideBar_panel.Controls.Add(this.icon_company);
            this.SideBar_panel.Controls.Add(this.lbl_companyName);
            this.SideBar_panel.Controls.Add(this.lbl_companyName1);
            this.anim_userControl.SetDecoration(this.SideBar_panel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.SideBar_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar_panel.Location = new System.Drawing.Point(0, 0);
            this.SideBar_panel.Name = "SideBar_panel";
            this.SideBar_panel.ShowBorders = true;
            this.SideBar_panel.Size = new System.Drawing.Size(100, 1028);
            this.SideBar_panel.TabIndex = 10;
            // 
            // icon_content
            // 
            this.icon_content.BackColor = System.Drawing.Color.Transparent;
            this.icon_content.Controls.Add(this.active);
            this.icon_content.Controls.Add(this.btn_home);
            this.icon_content.Controls.Add(this.btn_emp);
            this.icon_content.Controls.Add(this.btn_dep);
            this.icon_content.Controls.Add(this.btn_proj);
            this.icon_content.Controls.Add(this.btn_report);
            this.icon_content.Controls.Add(this.btn_budget);
            this.anim_userControl.SetDecoration(this.icon_content, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.icon_content.Location = new System.Drawing.Point(3, 247);
            this.icon_content.Name = "icon_content";
            this.icon_content.Size = new System.Drawing.Size(91, 604);
            this.icon_content.TabIndex = 2;
            // 
            // active
            // 
            this.active.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.active.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.active.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("active.BackgroundImage")));
            this.active.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.active.BorderColor = System.Drawing.Color.DodgerBlue;
            this.active.BorderRadius = 5;
            this.active.BorderThickness = 1;
            this.anim_userControl.SetDecoration(this.active, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.active.Location = new System.Drawing.Point(-3, 6);
            this.active.Name = "active";
            this.active.ShowBorders = true;
            this.active.Size = new System.Drawing.Size(11, 68);
            this.active.TabIndex = 1;
            // 
            // btn_home
            // 
            this.btn_home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anim_userControl.SetDecoration(this.btn_home, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Ubuntu", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_home.IconColor = System.Drawing.Color.DodgerBlue;
            this.btn_home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_home.IconSize = 41;
            this.btn_home.Location = new System.Drawing.Point(22, 15);
            this.btn_home.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(35, 50);
            this.btn_home.TabIndex = 9;
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_home.UseVisualStyleBackColor = false;
            // 
            // btn_emp
            // 
            this.btn_emp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_emp.BackColor = System.Drawing.Color.Transparent;
            this.btn_emp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anim_userControl.SetDecoration(this.btn_emp, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btn_emp.FlatAppearance.BorderSize = 0;
            this.btn_emp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_emp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emp.Font = new System.Drawing.Font("Ubuntu", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emp.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btn_emp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_emp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_emp.IconSize = 40;
            this.btn_emp.Location = new System.Drawing.Point(22, 273);
            this.btn_emp.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_emp.Name = "btn_emp";
            this.btn_emp.Size = new System.Drawing.Size(35, 50);
            this.btn_emp.TabIndex = 6;
            this.btn_emp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_emp.UseVisualStyleBackColor = false;
            // 
            // btn_dep
            // 
            this.btn_dep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_dep.BackColor = System.Drawing.Color.Transparent;
            this.btn_dep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anim_userControl.SetDecoration(this.btn_dep, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btn_dep.FlatAppearance.BorderSize = 0;
            this.btn_dep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_dep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_dep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dep.Font = new System.Drawing.Font("Ubuntu", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dep.IconChar = FontAwesome.Sharp.IconChar.BuildingUser;
            this.btn_dep.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_dep.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_dep.IconSize = 40;
            this.btn_dep.Location = new System.Drawing.Point(22, 359);
            this.btn_dep.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_dep.Name = "btn_dep";
            this.btn_dep.Size = new System.Drawing.Size(35, 50);
            this.btn_dep.TabIndex = 7;
            this.btn_dep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dep.UseVisualStyleBackColor = false;
            // 
            // btn_proj
            // 
            this.btn_proj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_proj.BackColor = System.Drawing.Color.Transparent;
            this.btn_proj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anim_userControl.SetDecoration(this.btn_proj, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btn_proj.FlatAppearance.BorderSize = 0;
            this.btn_proj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_proj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_proj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proj.Font = new System.Drawing.Font("Ubuntu", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proj.IconChar = FontAwesome.Sharp.IconChar.ProjectDiagram;
            this.btn_proj.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_proj.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_proj.IconSize = 40;
            this.btn_proj.Location = new System.Drawing.Point(22, 187);
            this.btn_proj.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_proj.Name = "btn_proj";
            this.btn_proj.Size = new System.Drawing.Size(35, 50);
            this.btn_proj.TabIndex = 5;
            this.btn_proj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_proj.UseVisualStyleBackColor = false;
            // 
            // btn_report
            // 
            this.btn_report.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_report.BackColor = System.Drawing.Color.Transparent;
            this.btn_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anim_userControl.SetDecoration(this.btn_report, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btn_report.FlatAppearance.BorderSize = 0;
            this.btn_report.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("Ubuntu", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btn_report.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_report.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_report.IconSize = 40;
            this.btn_report.Location = new System.Drawing.Point(22, 445);
            this.btn_report.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(35, 50);
            this.btn_report.TabIndex = 8;
            this.btn_report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_report.UseVisualStyleBackColor = false;
            // 
            // btn_budget
            // 
            this.btn_budget.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_budget.BackColor = System.Drawing.Color.Transparent;
            this.btn_budget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anim_userControl.SetDecoration(this.btn_budget, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btn_budget.FlatAppearance.BorderSize = 0;
            this.btn_budget.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_budget.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_budget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_budget.Font = new System.Drawing.Font("Ubuntu", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_budget.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_budget.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.btn_budget.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_budget.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_budget.IconSize = 40;
            this.btn_budget.Location = new System.Drawing.Point(22, 101);
            this.btn_budget.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_budget.Name = "btn_budget";
            this.btn_budget.Size = new System.Drawing.Size(35, 50);
            this.btn_budget.TabIndex = 4;
            this.btn_budget.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_budget.UseVisualStyleBackColor = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anim_userControl.SetDecoration(this.btn_exit, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Ubuntu", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btn_exit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_exit.IconSize = 40;
            this.btn_exit.Location = new System.Drawing.Point(25, 967);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(50, 50);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // icon_company
            // 
            this.icon_company.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.icon_company.BackColor = System.Drawing.Color.Transparent;
            this.anim_userControl.SetDecoration(this.icon_company, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.icon_company.Image = global::Company_Management_System.Properties.Resources.logo;
            this.icon_company.Location = new System.Drawing.Point(15, 10);
            this.icon_company.Margin = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.icon_company.Name = "icon_company";
            this.icon_company.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.icon_company.Size = new System.Drawing.Size(70, 57);
            this.icon_company.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_company.TabIndex = 0;
            this.icon_company.TabStop = false;
            // 
            // lbl_companyName
            // 
            this.lbl_companyName.AutoSize = true;
            this.anim_userControl.SetDecoration(this.lbl_companyName, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbl_companyName.Font = new System.Drawing.Font("ChunkFive Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_companyName.Location = new System.Drawing.Point(348, 268);
            this.lbl_companyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_companyName.Name = "lbl_companyName";
            this.lbl_companyName.Size = new System.Drawing.Size(202, 41);
            this.lbl_companyName.TabIndex = 1;
            this.lbl_companyName.Text = "OS7-SOFT";
            // 
            // lbl_companyName1
            // 
            this.lbl_companyName1.AutoSize = true;
            this.anim_userControl.SetDecoration(this.lbl_companyName1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbl_companyName1.Font = new System.Drawing.Font("ChunkFive Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_companyName1.Location = new System.Drawing.Point(378, 309);
            this.lbl_companyName1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_companyName1.Name = "lbl_companyName1";
            this.lbl_companyName1.Size = new System.Drawing.Size(143, 32);
            this.lbl_companyName1.TabIndex = 2;
            this.lbl_companyName1.Text = "Company";
            // 
            // changeColor
            // 
            this.changeColor.AutoTransition = false;
            this.changeColor.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))),
        System.Drawing.Color.DodgerBlue};
            this.changeColor.EndColor = System.Drawing.Color.White;
            this.changeColor.Interval = 10;
            this.changeColor.ProgessValue = 0;
            this.changeColor.StartColor = System.Drawing.Color.White;
            this.changeColor.TransitionControl = null;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // ganimation
            // 
            this.ganimation.Interval = 200;
            // 
            // home_window1
            // 
            this.anim_userControl.SetDecoration(this.home_window1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.home_window1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_window1.IsSuccessful = false;
            this.home_window1.Location = new System.Drawing.Point(0, 0);
            this.home_window1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.home_window1.Message = null;
            this.home_window1.Name = "home_window1";
            this.home_window1.Size = new System.Drawing.Size(1818, 1028);
            this.home_window1.TabIndex = 0;
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1918, 1028);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.SideBar_panel);
            this.anim_userControl.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1918, 1028);
            this.Name = "Main_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Window";
            this.main_panel.ResumeLayout(false);
            this.SideBar_panel.ResumeLayout(false);
            this.SideBar_panel.PerformLayout();
            this.icon_content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon_company)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox icon_company;
        private System.Windows.Forms.Label lbl_companyName;
        private System.Windows.Forms.Label lbl_companyName1;
        private FontAwesome.Sharp.IconButton btn_report;
        private FontAwesome.Sharp.IconButton btn_dep;
        private FontAwesome.Sharp.IconButton btn_emp;
        private FontAwesome.Sharp.IconButton btn_proj;
        private FontAwesome.Sharp.IconButton btn_budget;
        private Bunifu.UI.WinForms.BunifuPanel SideBar_panel;
        private Bunifu.UI.WinForms.BunifuPanel main_panel;
        private FontAwesome.Sharp.IconButton btn_exit;
        private Bunifu.UI.WinForms.BunifuPanel active;
        private System.Windows.Forms.Panel icon_content;
        private Bunifu.UI.WinForms.BunifuTransition anim_userControl;
        private Bunifu.UI.WinForms.BunifuColorTransition changeColor;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm;
        private Home_window home_window1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2AnimateWindow ganimation;
        private FontAwesome.Sharp.IconButton btn_home;
    }
}