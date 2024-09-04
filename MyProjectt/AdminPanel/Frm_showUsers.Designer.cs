namespace MyProjectt.AdminPanel
{
    partial class Frm_showUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_showuser = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ufamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ucode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ugender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ustatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rad_Onactive = new System.Windows.Forms.RadioButton();
            this.Rad_Active = new System.Windows.Forms.RadioButton();
            this.All_UserStatus = new System.Windows.Forms.RadioButton();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtfamily = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Rad_Meil = new System.Windows.Forms.RadioButton();
            this.Rad_Femail = new System.Windows.Forms.RadioButton();
            this.All_UserGender = new System.Windows.Forms.RadioButton();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.PicSearch = new System.Windows.Forms.PictureBox();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_createUser = new DevComponents.DotNetBar.ButtonX();
            this.btn_editUser = new DevComponents.DotNetBar.ButtonX();
            this.btn_OnactiveUser = new DevComponents.DotNetBar.ButtonX();
            this.btn_Refresh = new DevComponents.DotNetBar.ButtonX();
            this.btn_exit = new DevComponents.DotNetBar.ButtonX();
            this.btn_active = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.DG_showuser)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSearch)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DG_showuser
            // 
            this.DG_showuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_showuser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.Uname,
            this.Ufamily,
            this.Ucode,
            this.Uphone,
            this.Ugender,
            this.Ustatus,
            this.Ubirthday,
            this.Uemail});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_showuser.DefaultCellStyle = dataGridViewCellStyle1;
            this.DG_showuser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DG_showuser.Location = new System.Drawing.Point(0, 41);
            this.DG_showuser.Name = "DG_showuser";
            this.DG_showuser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DG_showuser.Size = new System.Drawing.Size(1008, 215);
            this.DG_showuser.TabIndex = 0;
            this.DG_showuser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_showuser_CellDoubleClick);
            // 
            // UserID
            // 
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.Visible = false;
            // 
            // Uname
            // 
            this.Uname.HeaderText = "نام";
            this.Uname.Name = "Uname";
            this.Uname.Width = 120;
            // 
            // Ufamily
            // 
            this.Ufamily.HeaderText = "نام خانوادگی";
            this.Ufamily.Name = "Ufamily";
            this.Ufamily.Width = 120;
            // 
            // Ucode
            // 
            this.Ucode.HeaderText = "شماره پرسنلی";
            this.Ucode.Name = "Ucode";
            this.Ucode.Width = 120;
            // 
            // Uphone
            // 
            this.Uphone.HeaderText = "شماره تماس";
            this.Uphone.Name = "Uphone";
            this.Uphone.Width = 120;
            // 
            // Ugender
            // 
            this.Ugender.HeaderText = "جنسیت";
            this.Ugender.Name = "Ugender";
            this.Ugender.Width = 120;
            // 
            // Ustatus
            // 
            this.Ustatus.HeaderText = "وضعیت";
            this.Ustatus.Name = "Ustatus";
            this.Ustatus.Width = 120;
            // 
            // Ubirthday
            // 
            this.Ubirthday.HeaderText = "تاریخ تولد";
            this.Ubirthday.Name = "Ubirthday";
            this.Ubirthday.Width = 120;
            // 
            // Uemail
            // 
            this.Uemail.HeaderText = "ایمیل";
            this.Uemail.Name = "Uemail";
            this.Uemail.Width = 120;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.PicSearch);
            this.groupPanel1.Controls.Add(this.panel2);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.panel1);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.txtfamily);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txtname);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(0, 262);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1008, 133);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "جستجو";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Rad_Onactive);
            this.panel1.Controls.Add(this.Rad_Active);
            this.panel1.Controls.Add(this.All_UserStatus);
            this.panel1.Location = new System.Drawing.Point(466, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 123);
            this.panel1.TabIndex = 9;
            // 
            // Rad_Onactive
            // 
            this.Rad_Onactive.AutoSize = true;
            this.Rad_Onactive.Location = new System.Drawing.Point(18, 69);
            this.Rad_Onactive.Name = "Rad_Onactive";
            this.Rad_Onactive.Size = new System.Drawing.Size(64, 17);
            this.Rad_Onactive.TabIndex = 15;
            this.Rad_Onactive.TabStop = true;
            this.Rad_Onactive.Text = "غیرفعال";
            this.Rad_Onactive.UseVisualStyleBackColor = true;
            // 
            // Rad_Active
            // 
            this.Rad_Active.AutoSize = true;
            this.Rad_Active.Location = new System.Drawing.Point(18, 40);
            this.Rad_Active.Name = "Rad_Active";
            this.Rad_Active.Size = new System.Drawing.Size(48, 17);
            this.Rad_Active.TabIndex = 13;
            this.Rad_Active.TabStop = true;
            this.Rad_Active.Text = "فعال";
            this.Rad_Active.UseVisualStyleBackColor = true;
            // 
            // All_UserStatus
            // 
            this.All_UserStatus.AutoSize = true;
            this.All_UserStatus.Location = new System.Drawing.Point(18, 14);
            this.All_UserStatus.Name = "All_UserStatus";
            this.All_UserStatus.Size = new System.Drawing.Size(42, 17);
            this.All_UserStatus.TabIndex = 11;
            this.All_UserStatus.TabStop = true;
            this.All_UserStatus.Text = "همه";
            this.All_UserStatus.UseVisualStyleBackColor = true;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(555, 26);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(56, 23);
            this.labelX3.TabIndex = 8;
            this.labelX3.Text = "وضعیت :";
            // 
            // txtfamily
            // 
            // 
            // 
            // 
            this.txtfamily.Border.Class = "TextBoxBorder";
            this.txtfamily.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtfamily.Location = new System.Drawing.Point(643, 23);
            this.txtfamily.Name = "txtfamily";
            this.txtfamily.PreventEnterBeep = true;
            this.txtfamily.Size = new System.Drawing.Size(100, 20);
            this.txtfamily.TabIndex = 7;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(735, 23);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "نام خانوادگی :";
            // 
            // txtname
            // 
            // 
            // 
            // 
            this.txtname.Border.Class = "TextBoxBorder";
            this.txtname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtname.Location = new System.Drawing.Point(849, 23);
            this.txtname.Name = "txtname";
            this.txtname.PreventEnterBeep = true;
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 5;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(902, 26);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "نام :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Rad_Meil);
            this.panel2.Controls.Add(this.Rad_Femail);
            this.panel2.Controls.Add(this.All_UserGender);
            this.panel2.Location = new System.Drawing.Point(254, -8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 121);
            this.panel2.TabIndex = 11;
            // 
            // Rad_Meil
            // 
            this.Rad_Meil.AutoSize = true;
            this.Rad_Meil.Location = new System.Drawing.Point(18, 69);
            this.Rad_Meil.Name = "Rad_Meil";
            this.Rad_Meil.Size = new System.Drawing.Size(37, 17);
            this.Rad_Meil.TabIndex = 15;
            this.Rad_Meil.TabStop = true;
            this.Rad_Meil.Text = "زن";
            this.Rad_Meil.UseVisualStyleBackColor = true;
            // 
            // Rad_Femail
            // 
            this.Rad_Femail.AutoSize = true;
            this.Rad_Femail.Location = new System.Drawing.Point(18, 40);
            this.Rad_Femail.Name = "Rad_Femail";
            this.Rad_Femail.Size = new System.Drawing.Size(40, 17);
            this.Rad_Femail.TabIndex = 13;
            this.Rad_Femail.TabStop = true;
            this.Rad_Femail.Text = "مرد";
            this.Rad_Femail.UseVisualStyleBackColor = true;
            // 
            // All_UserGender
            // 
            this.All_UserGender.AutoSize = true;
            this.All_UserGender.Location = new System.Drawing.Point(18, 14);
            this.All_UserGender.Name = "All_UserGender";
            this.All_UserGender.Size = new System.Drawing.Size(42, 17);
            this.All_UserGender.TabIndex = 11;
            this.All_UserGender.TabStop = true;
            this.All_UserGender.Text = "همه";
            this.All_UserGender.UseVisualStyleBackColor = true;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(343, 26);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(56, 23);
            this.labelX4.TabIndex = 10;
            this.labelX4.Text = "جنسیت :";
            // 
            // PicSearch
            // 
            this.PicSearch.Image = global::MyProjectt.Properties.Resources.find;
            this.PicSearch.Location = new System.Drawing.Point(54, 34);
            this.PicSearch.Name = "PicSearch";
            this.PicSearch.Size = new System.Drawing.Size(64, 50);
            this.PicSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSearch.TabIndex = 12;
            this.PicSearch.TabStop = false;
            this.PicSearch.Click += new System.EventHandler(this.PicSearch_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btn_active);
            this.groupPanel2.Controls.Add(this.btn_exit);
            this.groupPanel2.Controls.Add(this.btn_Refresh);
            this.groupPanel2.Controls.Add(this.btn_OnactiveUser);
            this.groupPanel2.Controls.Add(this.btn_editUser);
            this.groupPanel2.Controls.Add(this.btn_createUser);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(0, 401);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(1008, 71);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 2;
            // 
            // btn_createUser
            // 
            this.btn_createUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_createUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_createUser.Location = new System.Drawing.Point(670, 15);
            this.btn_createUser.Name = "btn_createUser";
            this.btn_createUser.Size = new System.Drawing.Size(75, 23);
            this.btn_createUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_createUser.TabIndex = 0;
            this.btn_createUser.Text = "ایجاد کاربر";
            this.btn_createUser.Click += new System.EventHandler(this.btn_createUser_Click);
            // 
            // btn_editUser
            // 
            this.btn_editUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_editUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_editUser.Location = new System.Drawing.Point(555, 15);
            this.btn_editUser.Name = "btn_editUser";
            this.btn_editUser.Size = new System.Drawing.Size(75, 23);
            this.btn_editUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_editUser.TabIndex = 1;
            this.btn_editUser.Text = "ویرایش کاربر";
            this.btn_editUser.Click += new System.EventHandler(this.btn_editUser_Click);
            // 
            // btn_OnactiveUser
            // 
            this.btn_OnactiveUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_OnactiveUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_OnactiveUser.Location = new System.Drawing.Point(441, 15);
            this.btn_OnactiveUser.Name = "btn_OnactiveUser";
            this.btn_OnactiveUser.Size = new System.Drawing.Size(75, 23);
            this.btn_OnactiveUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_OnactiveUser.TabIndex = 2;
            this.btn_OnactiveUser.Text = "غیرفعال کردن";
            this.btn_OnactiveUser.Click += new System.EventHandler(this.btn_OnactiveUser_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Refresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Refresh.Location = new System.Drawing.Point(324, 15);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "بروزرسانی";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_exit.Location = new System.Drawing.Point(214, 15);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "خروج";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_active
            // 
            this.btn_active.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_active.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_active.Location = new System.Drawing.Point(93, 20);
            this.btn_active.Name = "btn_active";
            this.btn_active.Size = new System.Drawing.Size(75, 23);
            this.btn_active.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_active.TabIndex = 5;
            this.btn_active.Text = "فعال کردن";
            this.btn_active.Click += new System.EventHandler(this.btn_active_Click);
            // 
            // Frm_showUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 474);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.DG_showuser);
            this.Name = "Frm_showUsers";
            this.Text = "فرم نمایش کاربران سیستم";
            this.Load += new System.EventHandler(this.Frm_showUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_showuser)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSearch)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DG_showuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ufamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ucode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ugender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ustatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uemail;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton All_UserStatus;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtfamily;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtname;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.RadioButton Rad_Onactive;
        private System.Windows.Forms.RadioButton Rad_Active;
        private System.Windows.Forms.PictureBox PicSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton Rad_Meil;
        private System.Windows.Forms.RadioButton Rad_Femail;
        private System.Windows.Forms.RadioButton All_UserGender;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btn_exit;
        private DevComponents.DotNetBar.ButtonX btn_Refresh;
        private DevComponents.DotNetBar.ButtonX btn_OnactiveUser;
        private DevComponents.DotNetBar.ButtonX btn_editUser;
        private DevComponents.DotNetBar.ButtonX btn_createUser;
        private DevComponents.DotNetBar.ButtonX btn_active;
    }
}