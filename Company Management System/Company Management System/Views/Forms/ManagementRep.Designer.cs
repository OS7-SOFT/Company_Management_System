namespace Company_Management_System.Views.Forms
{
    partial class ManagementRep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementRep));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.animateWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txt_RepTitle = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txt_content = new System.Windows.Forms.RichTextBox();
            this.btn_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.shadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.SuspendLayout();
            // 
            // animateWindow
            // 
            this.animateWindow.Interval = 200;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(38, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 31);
            this.label6.TabIndex = 75;
            this.label6.Text = "Report Title";
            // 
            // txt_RepTitle
            // 
            this.txt_RepTitle.AcceptsReturn = false;
            this.txt_RepTitle.AcceptsTab = false;
            this.txt_RepTitle.AnimationSpeed = 200;
            this.txt_RepTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_RepTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_RepTitle.BackColor = System.Drawing.Color.Transparent;
            this.txt_RepTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_RepTitle.BackgroundImage")));
            this.txt_RepTitle.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_RepTitle.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_RepTitle.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_RepTitle.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_RepTitle.BorderRadius = 20;
            this.txt_RepTitle.BorderThickness = 1;
            this.txt_RepTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_RepTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_RepTitle.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RepTitle.DefaultText = "";
            this.txt_RepTitle.FillColor = System.Drawing.Color.White;
            this.txt_RepTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_RepTitle.HideSelection = true;
            this.txt_RepTitle.IconLeft = null;
            this.txt_RepTitle.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_RepTitle.IconPadding = 10;
            this.txt_RepTitle.IconRight = null;
            this.txt_RepTitle.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_RepTitle.Lines = new string[0];
            this.txt_RepTitle.Location = new System.Drawing.Point(25, 70);
            this.txt_RepTitle.MaxLength = 32767;
            this.txt_RepTitle.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_RepTitle.Modified = false;
            this.txt_RepTitle.Multiline = false;
            this.txt_RepTitle.Name = "txt_RepTitle";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_RepTitle.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_RepTitle.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_RepTitle.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_RepTitle.OnIdleState = stateProperties4;
            this.txt_RepTitle.Padding = new System.Windows.Forms.Padding(3);
            this.txt_RepTitle.PasswordChar = '\0';
            this.txt_RepTitle.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_RepTitle.PlaceholderText = "";
            this.txt_RepTitle.ReadOnly = false;
            this.txt_RepTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_RepTitle.SelectedText = "";
            this.txt_RepTitle.SelectionLength = 0;
            this.txt_RepTitle.SelectionStart = 0;
            this.txt_RepTitle.ShortcutsEnabled = true;
            this.txt_RepTitle.Size = new System.Drawing.Size(409, 51);
            this.txt_RepTitle.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_RepTitle.TabIndex = 74;
            this.txt_RepTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_RepTitle.TextMarginBottom = 0;
            this.txt_RepTitle.TextMarginLeft = 3;
            this.txt_RepTitle.TextMarginTop = 0;
            this.txt_RepTitle.TextPlaceholder = "";
            this.txt_RepTitle.UseSystemPasswordChar = false;
            this.txt_RepTitle.WordWrap = true;
            // 
            // txt_content
            // 
            this.txt_content.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_content.Location = new System.Drawing.Point(25, 139);
            this.txt_content.Name = "txt_content";
            this.txt_content.Size = new System.Drawing.Size(983, 688);
            this.txt_content.TabIndex = 76;
            this.txt_content.Text = "";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.Animated = true;
            this.btn_refresh.BorderRadius = 5;
            this.btn_refresh.BorderThickness = 3;
            this.btn_refresh.CheckedState.Parent = this.btn_refresh;
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.CustomImages.Parent = this.btn_refresh;
            this.btn_refresh.FillColor = System.Drawing.Color.Transparent;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_refresh.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_refresh.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_refresh.HoverState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_refresh.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.HoverState.Parent = this.btn_refresh;
            this.btn_refresh.Location = new System.Drawing.Point(533, 856);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.ShadowDecoration.Parent = this.btn_refresh;
            this.btn_refresh.Size = new System.Drawing.Size(144, 56);
            this.btn_refresh.TabIndex = 79;
            this.btn_refresh.Tag = "";
            this.btn_refresh.Text = "Refresh";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Animated = true;
            this.btn_cancel.BorderRadius = 5;
            this.btn_cancel.BorderThickness = 3;
            this.btn_cancel.CheckedState.Parent = this.btn_cancel;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.CustomImages.Parent = this.btn_cancel;
            this.btn_cancel.FillColor = System.Drawing.Color.Transparent;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_cancel.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_cancel.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_cancel.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.btn_cancel.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.HoverState.Parent = this.btn_cancel;
            this.btn_cancel.Location = new System.Drawing.Point(877, 856);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.ShadowDecoration.Parent = this.btn_cancel;
            this.btn_cancel.Size = new System.Drawing.Size(144, 56);
            this.btn_cancel.TabIndex = 78;
            this.btn_cancel.Text = "Cancel";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Animated = true;
            this.btn_save.BorderRadius = 5;
            this.btn_save.BorderThickness = 3;
            this.btn_save.CheckedState.Parent = this.btn_save;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.CustomImages.Parent = this.btn_save;
            this.btn_save.FillColor = System.Drawing.Color.Transparent;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_save.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_save.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_save.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_save.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_save.HoverState.Parent = this.btn_save;
            this.btn_save.Location = new System.Drawing.Point(705, 856);
            this.btn_save.Name = "btn_save";
            this.btn_save.ShadowDecoration.Parent = this.btn_save;
            this.btn_save.Size = new System.Drawing.Size(144, 56);
            this.btn_save.TabIndex = 77;
            this.btn_save.Text = "Save";
            // 
            // ManagementRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 924);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_content);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_RepTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagementRep";
            this.Text = "ManagementRep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow animateWindow;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuTextBox txt_RepTitle;
        private System.Windows.Forms.RichTextBox txt_content;
        private Guna.UI2.WinForms.Guna2Button btn_refresh;
        private Guna.UI2.WinForms.Guna2Button btn_cancel;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private Guna.UI2.WinForms.Guna2ShadowForm shadow;
    }
}