namespace MyProjectt.AdminPanel
{
    partial class Frm_JobHistory
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btn_exit = new DevComponents.DotNetBar.ButtonX();
            this.btn_print = new DevComponents.DotNetBar.ButtonX();
            this.btn_deletejob = new DevComponents.DotNetBar.ButtonX();
            this.btn_setjob = new DevComponents.DotNetBar.ButtonX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.lbl_fullname = new DevComponents.DotNetBar.LabelX();
            this.DG_JobHistory = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.USID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setdatejob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateendjob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_JobHistory)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btn_exit);
            this.panelEx1.Controls.Add(this.btn_print);
            this.panelEx1.Controls.Add(this.btn_deletejob);
            this.panelEx1.Controls.Add(this.btn_setjob);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(1, 247);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(651, 65);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 2;
            // 
            // btn_exit
            // 
            this.btn_exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_exit.Location = new System.Drawing.Point(77, 28);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "خروج";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_print
            // 
            this.btn_print.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_print.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_print.Location = new System.Drawing.Point(234, 28);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_print.TabIndex = 2;
            this.btn_print.Text = "پرینت";
            // 
            // btn_deletejob
            // 
            this.btn_deletejob.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_deletejob.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_deletejob.Location = new System.Drawing.Point(365, 28);
            this.btn_deletejob.Name = "btn_deletejob";
            this.btn_deletejob.Size = new System.Drawing.Size(75, 23);
            this.btn_deletejob.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_deletejob.TabIndex = 1;
            this.btn_deletejob.Text = "گرفتن شغل";
            this.btn_deletejob.Click += new System.EventHandler(this.btn_deletejob_Click);
            // 
            // btn_setjob
            // 
            this.btn_setjob.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_setjob.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_setjob.Location = new System.Drawing.Point(500, 28);
            this.btn_setjob.Name = "btn_setjob";
            this.btn_setjob.Size = new System.Drawing.Size(75, 23);
            this.btn_setjob.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_setjob.TabIndex = 0;
            this.btn_setjob.Text = "انتساب شغل";
            this.btn_setjob.Click += new System.EventHandler(this.btn_setjob_Click);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.lbl_fullname);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Location = new System.Drawing.Point(-8, -1);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(660, 52);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 6;
            this.panelEx2.Click += new System.EventHandler(this.panelEx2_Click);
            // 
            // lbl_fullname
            // 
            // 
            // 
            // 
            this.lbl_fullname.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_fullname.Location = new System.Drawing.Point(293, 15);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_fullname.Size = new System.Drawing.Size(75, 23);
            this.lbl_fullname.TabIndex = 1;
            this.lbl_fullname.Text = "...";
            // 
            // DG_JobHistory
            // 
            this.DG_JobHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_JobHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USID,
            this.FullName,
            this.JobName,
            this.setdatejob,
            this.dateendjob,
            this.status});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_JobHistory.DefaultCellStyle = dataGridViewCellStyle1;
            this.DG_JobHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DG_JobHistory.Location = new System.Drawing.Point(-3, 3);
            this.DG_JobHistory.Name = "DG_JobHistory";
            this.DG_JobHistory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DG_JobHistory.Size = new System.Drawing.Size(645, 150);
            this.DG_JobHistory.TabIndex = 0;
            // 
            // USID
            // 
            this.USID.HeaderText = "USID";
            this.USID.Name = "USID";
            this.USID.Visible = false;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "نام و نام خانوادگی";
            this.FullName.Name = "FullName";
            this.FullName.Width = 120;
            // 
            // JobName
            // 
            this.JobName.HeaderText = "عنوان شغل";
            this.JobName.Name = "JobName";
            this.JobName.Width = 120;
            // 
            // setdatejob
            // 
            this.setdatejob.HeaderText = "تاریخ انتساب";
            this.setdatejob.Name = "setdatejob";
            this.setdatejob.Width = 120;
            // 
            // dateendjob
            // 
            this.dateendjob.HeaderText = "تاریخ عزل";
            this.dateendjob.Name = "dateendjob";
            this.dateendjob.Width = 120;
            // 
            // status
            // 
            this.status.HeaderText = "وضعیت";
            this.status.Name = "status";
            this.status.Width = 120;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.DG_JobHistory);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(1, 57);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(651, 184);
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
            this.groupPanel1.Text = "تاریخچه مشاغل";
            // 
            // Frm_JobHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 310);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.groupPanel1);
            this.Name = "Frm_JobHistory";
            this.Text = "فرم نمایش تاریخچه مشاغل";
            this.Load += new System.EventHandler(this.Frm_JobHistory_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_JobHistory)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btn_exit;
        private DevComponents.DotNetBar.ButtonX btn_print;
        private DevComponents.DotNetBar.ButtonX btn_deletejob;
        private DevComponents.DotNetBar.ButtonX btn_setjob;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.LabelX lbl_fullname;
        private DevComponents.DotNetBar.Controls.DataGridViewX DG_JobHistory;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn USID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn setdatejob;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateendjob;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}