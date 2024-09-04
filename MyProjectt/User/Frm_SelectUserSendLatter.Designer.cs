namespace MyProjectt.User
{
    partial class Frm_SelectUserSendLatter
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
            this.DG_ShowUser = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ReciveUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTjoblevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectUser = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Grop_discriptionLetter = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.Rich_description = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtfullname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Picserach = new System.Windows.Forms.PictureBox();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Btn_Send = new DevComponents.DotNetBar.ButtonX();
            this.Btn_Exit = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ShowUser)).BeginInit();
            this.Grop_discriptionLetter.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picserach)).BeginInit();
            this.groupPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DG_ShowUser
            // 
            this.DG_ShowUser.AllowUserToAddRows = false;
            this.DG_ShowUser.AllowUserToDeleteRows = false;
            this.DG_ShowUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_ShowUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReciveUserID,
            this.Fullname,
            this.JobName,
            this.DTjoblevel,
            this.SelectUser});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Mitra", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_ShowUser.DefaultCellStyle = dataGridViewCellStyle1;
            this.DG_ShowUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DG_ShowUser.Location = new System.Drawing.Point(1, 0);
            this.DG_ShowUser.Name = "DG_ShowUser";
            this.DG_ShowUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DG_ShowUser.Size = new System.Drawing.Size(360, 181);
            this.DG_ShowUser.TabIndex = 1;
            // 
            // ReciveUserID
            // 
            this.ReciveUserID.HeaderText = "ReciveUserID";
            this.ReciveUserID.Name = "ReciveUserID";
            this.ReciveUserID.Visible = false;
            // 
            // Fullname
            // 
            this.Fullname.HeaderText = "نام و نام خانوادگی";
            this.Fullname.Name = "Fullname";
            this.Fullname.Width = 135;
            // 
            // JobName
            // 
            this.JobName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JobName.HeaderText = "نام شغل";
            this.JobName.Name = "JobName";
            // 
            // DTjoblevel
            // 
            this.DTjoblevel.HeaderText = "DTjoblevel";
            this.DTjoblevel.Name = "DTjoblevel";
            this.DTjoblevel.Visible = false;
            // 
            // SelectUser
            // 
            this.SelectUser.HeaderText = "انتخاب";
            this.SelectUser.Name = "SelectUser";
            this.SelectUser.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Grop_discriptionLetter
            // 
            this.Grop_discriptionLetter.CanvasColor = System.Drawing.SystemColors.Control;
            this.Grop_discriptionLetter.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.Grop_discriptionLetter.Controls.Add(this.Rich_description);
            this.Grop_discriptionLetter.Controls.Add(this.labelX1);
            this.Grop_discriptionLetter.DisabledBackColor = System.Drawing.Color.Empty;
            this.Grop_discriptionLetter.Location = new System.Drawing.Point(1, 187);
            this.Grop_discriptionLetter.Name = "Grop_discriptionLetter";
            this.Grop_discriptionLetter.Size = new System.Drawing.Size(360, 100);
            // 
            // 
            // 
            this.Grop_discriptionLetter.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.Grop_discriptionLetter.Style.BackColorGradientAngle = 90;
            this.Grop_discriptionLetter.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.Grop_discriptionLetter.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Grop_discriptionLetter.Style.BorderBottomWidth = 1;
            this.Grop_discriptionLetter.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.Grop_discriptionLetter.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Grop_discriptionLetter.Style.BorderLeftWidth = 1;
            this.Grop_discriptionLetter.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Grop_discriptionLetter.Style.BorderRightWidth = 1;
            this.Grop_discriptionLetter.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Grop_discriptionLetter.Style.BorderTopWidth = 1;
            this.Grop_discriptionLetter.Style.CornerDiameter = 4;
            this.Grop_discriptionLetter.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.Grop_discriptionLetter.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.Grop_discriptionLetter.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.Grop_discriptionLetter.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.Grop_discriptionLetter.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.Grop_discriptionLetter.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Grop_discriptionLetter.TabIndex = 2;
            this.Grop_discriptionLetter.Text = "توضیحات نامه";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(277, 15);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(68, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "توضیحات نامه :";
            // 
            // Rich_description
            // 
            // 
            // 
            // 
            this.Rich_description.BackgroundStyle.Class = "RichTextBoxBorder";
            this.Rich_description.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Rich_description.Location = new System.Drawing.Point(38, 7);
            this.Rich_description.Name = "Rich_description";
            this.Rich_description.Rtf = "{\\rtf1\\fbidis\\ansi\\ansicpg1256\\deff0\\deflang1065{\\fonttbl{\\f0\\fnil\\fcharset0 Micr" +
    "osoft Sans Serif;}}\r\n\\viewkind4\\uc1\\pard\\ltrpar\\f0\\fs17\\par\r\n}\r\n";
            this.Rich_description.Size = new System.Drawing.Size(233, 69);
            this.Rich_description.TabIndex = 1;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.Picserach);
            this.groupPanel2.Controls.Add(this.txtfullname);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(1, 295);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(360, 83);
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
            this.groupPanel2.TabIndex = 3;
            this.groupPanel2.Text = "جستجو";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(264, 15);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(81, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "نام و نام خانوادگی :";
            // 
            // txtfullname
            // 
            // 
            // 
            // 
            this.txtfullname.Border.Class = "TextBoxBorder";
            this.txtfullname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtfullname.Location = new System.Drawing.Point(113, 15);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.PreventEnterBeep = true;
            this.txtfullname.Size = new System.Drawing.Size(158, 20);
            this.txtfullname.TabIndex = 1;
            this.txtfullname.TextChanged += new System.EventHandler(this.txtfullname_TextChanged);
            // 
            // Picserach
            // 
            this.Picserach.Image = global::MyProjectt.Properties.Resources.find;
            this.Picserach.Location = new System.Drawing.Point(38, 3);
            this.Picserach.Name = "Picserach";
            this.Picserach.Size = new System.Drawing.Size(64, 50);
            this.Picserach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picserach.TabIndex = 29;
            this.Picserach.TabStop = false;
            this.Picserach.Click += new System.EventHandler(this.Picserach_Click);
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.Btn_Exit);
            this.groupPanel3.Controls.Add(this.Btn_Send);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Location = new System.Drawing.Point(1, 384);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(360, 47);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 4;
            // 
            // Btn_Send
            // 
            this.Btn_Send.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_Send.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_Send.Location = new System.Drawing.Point(223, 7);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(75, 23);
            this.Btn_Send.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Btn_Send.TabIndex = 0;
            this.Btn_Send.Text = "ارسال";
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_Exit.Location = new System.Drawing.Point(122, 7);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Btn_Exit.TabIndex = 1;
            this.Btn_Exit.Text = "خروج";
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Frm_SelectUserSendLatter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 431);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.Grop_discriptionLetter);
            this.Controls.Add(this.DG_ShowUser);
            this.Name = "Frm_SelectUserSendLatter";
            this.Text = "فرم ارسال نامه";
            this.Load += new System.EventHandler(this.Frm_SelectUserSendLatter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_ShowUser)).EndInit();
            this.Grop_discriptionLetter.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picserach)).EndInit();
            this.groupPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DG_ShowUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReciveUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTjoblevel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectUser;
        private DevComponents.DotNetBar.Controls.GroupPanel Grop_discriptionLetter;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx Rich_description;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtfullname;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.PictureBox Picserach;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.ButtonX Btn_Exit;
        private DevComponents.DotNetBar.ButtonX Btn_Send;
    }
}