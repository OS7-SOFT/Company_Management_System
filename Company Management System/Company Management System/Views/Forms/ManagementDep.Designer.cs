namespace Company_Management_System
{
    partial class ManagementDep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementDep));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.txt_depName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.managerIdValue = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.budgetValue = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.shadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.animate = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.managerIdValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetValue)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_depName
            // 
            this.txt_depName.AcceptsReturn = false;
            this.txt_depName.AcceptsTab = false;
            this.txt_depName.AnimationSpeed = 200;
            this.txt_depName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_depName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_depName.BackColor = System.Drawing.Color.Transparent;
            this.txt_depName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_depName.BackgroundImage")));
            this.txt_depName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_depName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_depName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_depName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_depName.BorderRadius = 20;
            this.txt_depName.BorderThickness = 1;
            this.txt_depName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_depName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_depName.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_depName.DefaultText = "";
            this.txt_depName.FillColor = System.Drawing.Color.White;
            this.txt_depName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_depName.HideSelection = true;
            this.txt_depName.IconLeft = null;
            this.txt_depName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_depName.IconPadding = 10;
            this.txt_depName.IconRight = null;
            this.txt_depName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_depName.Lines = new string[0];
            this.txt_depName.Location = new System.Drawing.Point(24, 61);
            this.txt_depName.MaxLength = 32767;
            this.txt_depName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_depName.Modified = false;
            this.txt_depName.Multiline = false;
            this.txt_depName.Name = "txt_depName";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_depName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_depName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_depName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_depName.OnIdleState = stateProperties4;
            this.txt_depName.Padding = new System.Windows.Forms.Padding(3);
            this.txt_depName.PasswordChar = '\0';
            this.txt_depName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_depName.PlaceholderText = "";
            this.txt_depName.ReadOnly = false;
            this.txt_depName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_depName.SelectedText = "";
            this.txt_depName.SelectionLength = 0;
            this.txt_depName.SelectionStart = 0;
            this.txt_depName.ShortcutsEnabled = true;
            this.txt_depName.Size = new System.Drawing.Size(409, 51);
            this.txt_depName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_depName.TabIndex = 20;
            this.txt_depName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_depName.TextMarginBottom = 0;
            this.txt_depName.TextMarginLeft = 3;
            this.txt_depName.TextMarginTop = 0;
            this.txt_depName.TextPlaceholder = "";
            this.toolTip1.SetToolTip(this.txt_depName, "Enter Department Name");
            this.txt_depName.UseSystemPasswordChar = false;
            this.txt_depName.WordWrap = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 6000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 20;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // managerIdValue
            // 
            this.managerIdValue.BackColor = System.Drawing.Color.Transparent;
            this.managerIdValue.BorderRadius = 10;
            this.managerIdValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.managerIdValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.managerIdValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.managerIdValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.managerIdValue.DisabledState.Parent = this.managerIdValue;
            this.managerIdValue.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.managerIdValue.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.managerIdValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.managerIdValue.FocusedState.Parent = this.managerIdValue;
            this.managerIdValue.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerIdValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.managerIdValue.Location = new System.Drawing.Point(24, 170);
            this.managerIdValue.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.managerIdValue.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.managerIdValue.Name = "managerIdValue";
            this.managerIdValue.ShadowDecoration.Parent = this.managerIdValue;
            this.managerIdValue.Size = new System.Drawing.Size(272, 46);
            this.managerIdValue.TabIndex = 65;
            this.toolTip1.SetToolTip(this.managerIdValue, "Enter Manager ID");
            // 
            // budgetValue
            // 
            this.budgetValue.BackColor = System.Drawing.Color.Transparent;
            this.budgetValue.BorderRadius = 10;
            this.budgetValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.budgetValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.budgetValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.budgetValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.budgetValue.DisabledState.Parent = this.budgetValue;
            this.budgetValue.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.budgetValue.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.budgetValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.budgetValue.FocusedState.Parent = this.budgetValue;
            this.budgetValue.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.budgetValue.Location = new System.Drawing.Point(24, 277);
            this.budgetValue.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.budgetValue.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.budgetValue.Name = "budgetValue";
            this.budgetValue.ShadowDecoration.Parent = this.budgetValue;
            this.budgetValue.Size = new System.Drawing.Size(409, 46);
            this.budgetValue.TabIndex = 66;
            this.toolTip1.SetToolTip(this.budgetValue, "Enter Budget");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 44;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(38, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 31);
            this.label2.TabIndex = 45;
            this.label2.Text = "Budget";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(38, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 31);
            this.label3.TabIndex = 46;
            this.label3.Text = "Manager ID";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancel.Animated = true;
            this.btn_cancel.BorderRadius = 5;
            this.btn_cancel.BorderThickness = 3;
            this.btn_cancel.CheckedState.Parent = this.btn_cancel;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.CustomImages.Parent = this.btn_cancel;
            this.btn_cancel.FillColor = System.Drawing.Color.Transparent;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_cancel.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_cancel.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_cancel.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.btn_cancel.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.HoverState.Parent = this.btn_cancel;
            this.btn_cancel.Location = new System.Drawing.Point(242, 375);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.ShadowDecoration.Parent = this.btn_cancel;
            this.btn_cancel.Size = new System.Drawing.Size(119, 48);
            this.btn_cancel.TabIndex = 64;
            this.btn_cancel.Text = "Cancel";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.Animated = true;
            this.btn_save.BorderRadius = 5;
            this.btn_save.BorderThickness = 3;
            this.btn_save.CheckedState.Parent = this.btn_save;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.CustomImages.Parent = this.btn_save;
            this.btn_save.FillColor = System.Drawing.Color.Transparent;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_save.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_save.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_save.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_save.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_save.HoverState.Parent = this.btn_save;
            this.btn_save.Location = new System.Drawing.Point(107, 375);
            this.btn_save.Name = "btn_save";
            this.btn_save.ShadowDecoration.Parent = this.btn_save;
            this.btn_save.Size = new System.Drawing.Size(119, 48);
            this.btn_save.TabIndex = 63;
            this.btn_save.Text = "Save";
            // 
            // animate
            // 
            this.animate.Interval = 200;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // ManagementDep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 446);
            this.Controls.Add(this.budgetValue);
            this.Controls.Add(this.managerIdValue);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_depName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagementDep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Edit_Dep";
            ((System.ComponentModel.ISupportInitialize)(this.managerIdValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTextBox txt_depName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btn_cancel;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private Guna.UI2.WinForms.Guna2ShadowForm shadow;
        private Guna.UI2.WinForms.Guna2NumericUpDown managerIdValue;
        private Guna.UI2.WinForms.Guna2NumericUpDown budgetValue;
        private Guna.UI2.WinForms.Guna2AnimateWindow animate;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}