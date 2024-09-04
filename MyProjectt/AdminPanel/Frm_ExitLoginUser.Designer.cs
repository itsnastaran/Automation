namespace MyProjectt.AdminPanel
{
    partial class Frm_ExitLoginUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ExitLoginUser));
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.UserLogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComputerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPComputer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEnter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateExit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txt_fullname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_IP = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_computername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.datefrom = new FreeControls.PersianDateTimePicker();
            this.dateto = new FreeControls.PersianDateTimePicker();
            this.Time_from = new System.Windows.Forms.DateTimePicker();
            this.Time_to = new System.Windows.Forms.DateTimePicker();
            this.pic_search = new System.Windows.Forms.PictureBox();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserLogID,
            this.FullName,
            this.ComputerName,
            this.IPComputer,
            this.DateEnter,
            this.DateExit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(1, 32);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewX1.Size = new System.Drawing.Size(695, 150);
            this.dataGridViewX1.TabIndex = 0;
            // 
            // UserLogID
            // 
            this.UserLogID.HeaderText = "UserLogID";
            this.UserLogID.Name = "UserLogID";
            this.UserLogID.Visible = false;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "نام و نام خانوادگی";
            this.FullName.Name = "FullName";
            this.FullName.Width = 130;
            // 
            // ComputerName
            // 
            this.ComputerName.HeaderText = "نام کامپیوتر";
            this.ComputerName.Name = "ComputerName";
            this.ComputerName.Width = 130;
            // 
            // IPComputer
            // 
            this.IPComputer.HeaderText = "آی پی کامپیوتر";
            this.IPComputer.Name = "IPComputer";
            this.IPComputer.Width = 130;
            // 
            // DateEnter
            // 
            this.DateEnter.HeaderText = "تاریخ و ساعت ورود";
            this.DateEnter.Name = "DateEnter";
            this.DateEnter.Width = 130;
            // 
            // DateExit
            // 
            this.DateExit.HeaderText = "تاریخ و ساعت خروج";
            this.DateExit.Name = "DateExit";
            this.DateExit.Width = 130;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.pic_search);
            this.groupPanel1.Controls.Add(this.Time_to);
            this.groupPanel1.Controls.Add(this.Time_from);
            this.groupPanel1.Controls.Add(this.dateto);
            this.groupPanel1.Controls.Add(this.datefrom);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txt_computername);
            this.groupPanel1.Controls.Add(this.txt_IP);
            this.groupPanel1.Controls.Add(this.txt_fullname);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(1, 188);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(695, 125);
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
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(605, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "نام و نام خانوادگی :";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(605, 32);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(60, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "شماره آی پی :";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(608, 61);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(57, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "نام کامپیوتر :";
            // 
            // txt_fullname
            // 
            // 
            // 
            // 
            this.txt_fullname.Border.Class = "TextBoxBorder";
            this.txt_fullname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_fullname.Location = new System.Drawing.Point(462, 9);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.PreventEnterBeep = true;
            this.txt_fullname.Size = new System.Drawing.Size(100, 20);
            this.txt_fullname.TabIndex = 3;
            // 
            // txt_IP
            // 
            // 
            // 
            // 
            this.txt_IP.Border.Class = "TextBoxBorder";
            this.txt_IP.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_IP.Location = new System.Drawing.Point(462, 35);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.PreventEnterBeep = true;
            this.txt_IP.Size = new System.Drawing.Size(100, 20);
            this.txt_IP.TabIndex = 4;
            // 
            // txt_computername
            // 
            // 
            // 
            // 
            this.txt_computername.Border.Class = "TextBoxBorder";
            this.txt_computername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_computername.Location = new System.Drawing.Point(462, 64);
            this.txt_computername.Name = "txt_computername";
            this.txt_computername.PreventEnterBeep = true;
            this.txt_computername.Size = new System.Drawing.Size(100, 20);
            this.txt_computername.TabIndex = 5;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(344, 9);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(57, 23);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "از تاریخ :";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(344, 38);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX5.Size = new System.Drawing.Size(57, 23);
            this.labelX5.TabIndex = 7;
            this.labelX5.Text = "از ساعت :";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(170, 41);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(57, 23);
            this.labelX6.TabIndex = 11;
            this.labelX6.Text = "تا ساعت :";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(170, 12);
            this.labelX7.Name = "labelX7";
            this.labelX7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX7.Size = new System.Drawing.Size(57, 23);
            this.labelX7.TabIndex = 10;
            this.labelX7.Text = "تا تاریخ :";
            // 
            // datefrom
            // 
            this.datefrom.BackColor = System.Drawing.Color.White;
            this.datefrom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.datefrom.Location = new System.Drawing.Point(248, 14);
            this.datefrom.Name = "datefrom";
            this.datefrom.ShowTime = false;
            this.datefrom.Size = new System.Drawing.Size(102, 18);
            this.datefrom.TabIndex = 14;
            this.datefrom.Text = "persianDateTimePicker1";
            this.datefrom.Value = ((FreeControls.PersianDate)(resources.GetObject("datefrom.Value")));
            // 
            // dateto
            // 
            this.dateto.BackColor = System.Drawing.Color.White;
            this.dateto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateto.Location = new System.Drawing.Point(74, 14);
            this.dateto.Name = "dateto";
            this.dateto.ShowTime = false;
            this.dateto.Size = new System.Drawing.Size(102, 18);
            this.dateto.TabIndex = 15;
            this.dateto.Text = "persianDateTimePicker1";
            this.dateto.Value = ((FreeControls.PersianDate)(resources.GetObject("dateto.Value")));
            // 
            // Time_from
            // 
            this.Time_from.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Time_from.Location = new System.Drawing.Point(248, 41);
            this.Time_from.Name = "Time_from";
            this.Time_from.Size = new System.Drawing.Size(102, 20);
            this.Time_from.TabIndex = 17;
            this.Time_from.ValueChanged += new System.EventHandler(this.Time_from_ValueChanged);
            // 
            // Time_to
            // 
            this.Time_to.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Time_to.Location = new System.Drawing.Point(74, 41);
            this.Time_to.Name = "Time_to";
            this.Time_to.Size = new System.Drawing.Size(102, 20);
            this.Time_to.TabIndex = 18;
            // 
            // pic_search
            // 
            this.pic_search.Image = global::MyProjectt.Properties.Resources.find;
            this.pic_search.Location = new System.Drawing.Point(8, 14);
            this.pic_search.Name = "pic_search";
            this.pic_search.Size = new System.Drawing.Size(60, 50);
            this.pic_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_search.TabIndex = 19;
            this.pic_search.TabStop = false;
            this.pic_search.Click += new System.EventHandler(this.pic_search_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.buttonX2);
            this.panelEx1.Controls.Add(this.buttonX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(1, 319);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(695, 44);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 2;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(465, 13);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "تهیه گزارش";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(310, 13);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 1;
            this.buttonX2.Text = "خروج";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // Frm_ExitLoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 367);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.dataGridViewX1);
            this.Name = "Frm_ExitLoginUser";
            this.Text = "کنترل ورود و خروج کاربران";
            this.Load += new System.EventHandler(this.Frm_ExitLoginUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPComputer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEnter;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateExit;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.DateTimePicker Time_from;
        private FreeControls.PersianDateTimePicker dateto;
        private FreeControls.PersianDateTimePicker datefrom;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_computername;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_IP;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_fullname;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.PictureBox pic_search;
        private System.Windows.Forms.DateTimePicker Time_to;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}