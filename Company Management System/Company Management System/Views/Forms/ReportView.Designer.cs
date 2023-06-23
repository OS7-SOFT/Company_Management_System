namespace Company_Management_System
{
    partial class ReportView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportView));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.top_panel = new System.Windows.Forms.Panel();
            this.btn_searchRep = new FontAwesome.Sharp.IconButton();
            this.txt_searchRep = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.lbl_repCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.right_panel = new System.Windows.Forms.Panel();
            this.btn_deleteRep = new Guna.UI2.WinForms.Guna2Button();
            this.btn_editRep = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addRep = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_Rep = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.top_panel.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.right_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rep)).BeginInit();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.AliceBlue;
            this.top_panel.Controls.Add(this.btn_searchRep);
            this.top_panel.Controls.Add(this.txt_searchRep);
            this.top_panel.Controls.Add(this.bunifuCards1);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 15);
            this.top_panel.Size = new System.Drawing.Size(1843, 338);
            this.top_panel.TabIndex = 8;
            // 
            // btn_searchRep
            // 
            this.btn_searchRep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_searchRep.FlatAppearance.BorderSize = 0;
            this.btn_searchRep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_searchRep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_searchRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchRep.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_searchRep.IconColor = System.Drawing.Color.Black;
            this.btn_searchRep.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_searchRep.Location = new System.Drawing.Point(1483, 264);
            this.btn_searchRep.Name = "btn_searchRep";
            this.btn_searchRep.Size = new System.Drawing.Size(75, 56);
            this.btn_searchRep.TabIndex = 4;
            this.btn_searchRep.UseVisualStyleBackColor = true;
            // 
            // txt_searchRep
            // 
            this.txt_searchRep.AcceptsReturn = false;
            this.txt_searchRep.AcceptsTab = false;
            this.txt_searchRep.AnimationSpeed = 200;
            this.txt_searchRep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_searchRep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_searchRep.BackColor = System.Drawing.Color.Transparent;
            this.txt_searchRep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_searchRep.BackgroundImage")));
            this.txt_searchRep.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_searchRep.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_searchRep.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_searchRep.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_searchRep.BorderRadius = 20;
            this.txt_searchRep.BorderThickness = 0;
            this.txt_searchRep.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_searchRep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_searchRep.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchRep.DefaultText = "";
            this.txt_searchRep.FillColor = System.Drawing.Color.AliceBlue;
            this.txt_searchRep.HideSelection = true;
            this.txt_searchRep.IconLeft = null;
            this.txt_searchRep.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_searchRep.IconPadding = 10;
            this.txt_searchRep.IconRight = null;
            this.txt_searchRep.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_searchRep.Lines = new string[0];
            this.txt_searchRep.Location = new System.Drawing.Point(750, 264);
            this.txt_searchRep.MaxLength = 32767;
            this.txt_searchRep.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_searchRep.Modified = false;
            this.txt_searchRep.Multiline = false;
            this.txt_searchRep.Name = "txt_searchRep";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_searchRep.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_searchRep.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_searchRep.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.AliceBlue;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_searchRep.OnIdleState = stateProperties4;
            this.txt_searchRep.Padding = new System.Windows.Forms.Padding(3);
            this.txt_searchRep.PasswordChar = '\0';
            this.txt_searchRep.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txt_searchRep.PlaceholderText = "Search Department";
            this.txt_searchRep.ReadOnly = false;
            this.txt_searchRep.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_searchRep.SelectedText = "";
            this.txt_searchRep.SelectionLength = 0;
            this.txt_searchRep.SelectionStart = 0;
            this.txt_searchRep.ShortcutsEnabled = true;
            this.txt_searchRep.Size = new System.Drawing.Size(727, 56);
            this.txt_searchRep.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_searchRep.TabIndex = 3;
            this.txt_searchRep.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_searchRep.TextMarginBottom = 0;
            this.txt_searchRep.TextMarginLeft = 3;
            this.txt_searchRep.TextMarginTop = 0;
            this.txt_searchRep.TextPlaceholder = "Search Department";
            this.txt_searchRep.UseSystemPasswordChar = false;
            this.txt_searchRep.WordWrap = true;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DodgerBlue;
            this.bunifuCards1.Controls.Add(this.lbl_repCount);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(15, 13);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 100;
            this.bunifuCards1.Size = new System.Drawing.Size(566, 183);
            this.bunifuCards1.TabIndex = 0;
            // 
            // lbl_repCount
            // 
            this.lbl_repCount.AutoSize = true;
            this.lbl_repCount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_repCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_repCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_repCount.Location = new System.Drawing.Point(302, 17);
            this.lbl_repCount.Name = "lbl_repCount";
            this.lbl_repCount.Size = new System.Drawing.Size(31, 28);
            this.lbl_repCount.TabIndex = 2;
            this.lbl_repCount.Text = "15";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Reports :";
            // 
            // right_panel
            // 
            this.right_panel.BackColor = System.Drawing.Color.AliceBlue;
            this.right_panel.Controls.Add(this.btn_deleteRep);
            this.right_panel.Controls.Add(this.btn_editRep);
            this.right_panel.Controls.Add(this.btn_addRep);
            this.right_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.right_panel.Location = new System.Drawing.Point(1604, 338);
            this.right_panel.Name = "right_panel";
            this.right_panel.Size = new System.Drawing.Size(239, 800);
            this.right_panel.TabIndex = 10;
            // 
            // btn_deleteRep
            // 
            this.btn_deleteRep.Animated = true;
            this.btn_deleteRep.BorderRadius = 5;
            this.btn_deleteRep.BorderThickness = 3;
            this.btn_deleteRep.CheckedState.Parent = this.btn_deleteRep;
            this.btn_deleteRep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deleteRep.CustomImages.Parent = this.btn_deleteRep;
            this.btn_deleteRep.FillColor = System.Drawing.Color.Transparent;
            this.btn_deleteRep.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteRep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_deleteRep.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_deleteRep.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_deleteRep.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.btn_deleteRep.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteRep.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_deleteRep.HoverState.Parent = this.btn_deleteRep;
            this.btn_deleteRep.Location = new System.Drawing.Point(43, 210);
            this.btn_deleteRep.Name = "btn_deleteRep";
            this.btn_deleteRep.ShadowDecoration.Parent = this.btn_deleteRep;
            this.btn_deleteRep.Size = new System.Drawing.Size(153, 55);
            this.btn_deleteRep.TabIndex = 13;
            this.btn_deleteRep.Text = "Delete";
            // 
            // btn_editRep
            // 
            this.btn_editRep.Animated = true;
            this.btn_editRep.BorderRadius = 5;
            this.btn_editRep.BorderThickness = 3;
            this.btn_editRep.CheckedState.Parent = this.btn_editRep;
            this.btn_editRep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editRep.CustomImages.Parent = this.btn_editRep;
            this.btn_editRep.FillColor = System.Drawing.Color.Transparent;
            this.btn_editRep.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editRep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_editRep.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_editRep.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_editRep.HoverState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_editRep.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editRep.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_editRep.HoverState.Parent = this.btn_editRep;
            this.btn_editRep.Location = new System.Drawing.Point(43, 120);
            this.btn_editRep.Name = "btn_editRep";
            this.btn_editRep.ShadowDecoration.Parent = this.btn_editRep;
            this.btn_editRep.Size = new System.Drawing.Size(153, 55);
            this.btn_editRep.TabIndex = 12;
            this.btn_editRep.Text = "Edit";
            // 
            // btn_addRep
            // 
            this.btn_addRep.Animated = true;
            this.btn_addRep.BorderRadius = 5;
            this.btn_addRep.BorderThickness = 3;
            this.btn_addRep.CheckedState.Parent = this.btn_addRep;
            this.btn_addRep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addRep.CustomImages.Parent = this.btn_addRep;
            this.btn_addRep.FillColor = System.Drawing.Color.Transparent;
            this.btn_addRep.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addRep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_addRep.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_addRep.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_addRep.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_addRep.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addRep.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_addRep.HoverState.Parent = this.btn_addRep;
            this.btn_addRep.Location = new System.Drawing.Point(43, 30);
            this.btn_addRep.Name = "btn_addRep";
            this.btn_addRep.ShadowDecoration.Parent = this.btn_addRep;
            this.btn_addRep.Size = new System.Drawing.Size(153, 55);
            this.btn_addRep.TabIndex = 11;
            this.btn_addRep.Text = "Add";
            // 
            // dgv_Rep
            // 
            this.dgv_Rep.AllowCustomTheming = false;
            this.dgv_Rep.AllowUserToAddRows = false;
            this.dgv_Rep.AllowUserToDeleteRows = false;
            this.dgv_Rep.AllowUserToResizeColumns = false;
            this.dgv_Rep.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_Rep.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Rep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Rep.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.dgv_Rep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Rep.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Rep.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Rep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Rep.ColumnHeadersHeight = 40;
            this.dgv_Rep.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_Rep.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_Rep.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_Rep.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_Rep.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_Rep.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_Rep.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_Rep.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_Rep.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_Rep.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Rep.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv_Rep.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Rep.CurrentTheme.Name = null;
            this.dgv_Rep.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Rep.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_Rep.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_Rep.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_Rep.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Rep.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Rep.EnableHeadersVisualStyles = false;
            this.dgv_Rep.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_Rep.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_Rep.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_Rep.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Rep.Location = new System.Drawing.Point(15, 338);
            this.dgv_Rep.Name = "dgv_Rep";
            this.dgv_Rep.ReadOnly = true;
            this.dgv_Rep.RowHeadersVisible = false;
            this.dgv_Rep.RowHeadersWidth = 51;
            this.dgv_Rep.RowTemplate.Height = 40;
            this.dgv_Rep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Rep.Size = new System.Drawing.Size(1589, 800);
            this.dgv_Rep.TabIndex = 9;
            this.dgv_Rep.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.right_panel);
            this.Controls.Add(this.dgv_Rep);
            this.Controls.Add(this.top_panel);
            this.Name = "ReportView";
            this.Size = new System.Drawing.Size(1843, 1138);
            this.top_panel.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.right_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private FontAwesome.Sharp.IconButton btn_searchRep;
        private Bunifu.UI.WinForms.BunifuTextBox txt_searchRep;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label lbl_repCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel right_panel;
        private Guna.UI2.WinForms.Guna2Button btn_deleteRep;
        private Guna.UI2.WinForms.Guna2Button btn_editRep;
        private Guna.UI2.WinForms.Guna2Button btn_addRep;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_Rep;
    }
}
