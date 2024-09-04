namespace MyProjectt.User
{
    partial class Frm_ShowDraft
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
            this.DG_Show_Draft = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.Picserach = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Rad_SecurityAney = new System.Windows.Forms.RadioButton();
            this.Rad_Securityins = new System.Windows.Forms.RadioButton();
            this.Rad_SecurityNormal = new System.Windows.Forms.RadioButton();
            this.Rad_AllSecurity = new System.Windows.Forms.RadioButton();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rad_ActionM = new System.Windows.Forms.RadioButton();
            this.Rad_ActionS = new System.Windows.Forms.RadioButton();
            this.Rad_Actionnormal = new System.Windows.Forms.RadioButton();
            this.Rad_allAction = new System.Windows.Forms.RadioButton();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txt_subject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.Btn_EditLetter = new DevComponents.DotNetBar.ButtonX();
            this.Btn_Deletefromdraft = new DevComponents.DotNetBar.ButtonX();
            this.Btn_sendletter = new DevComponents.DotNetBar.ButtonX();
            this.LetterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectLetter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LatterNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecurityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LatterTypeAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LetterFollow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LetterAttachment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnswerDedlaine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lettertype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Show_Draft)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picserach)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DG_Show_Draft
            // 
            this.DG_Show_Draft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Show_Draft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LetterID,
            this.SubjectLetter,
            this.LatterNumber,
            this.CreateDate,
            this.SecurityType,
            this.LatterTypeAction,
            this.LetterFollow,
            this.LetterAttachment,
            this.AnswerDedlaine,
            this.Lettertype,
            this.ST});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_Show_Draft.DefaultCellStyle = dataGridViewCellStyle1;
            this.DG_Show_Draft.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DG_Show_Draft.Location = new System.Drawing.Point(1, 1);
            this.DG_Show_Draft.Name = "DG_Show_Draft";
            this.DG_Show_Draft.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DG_Show_Draft.Size = new System.Drawing.Size(938, 189);
            this.DG_Show_Draft.TabIndex = 0;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.panelEx1);
            this.groupPanel1.Controls.Add(this.Picserach);
            this.groupPanel1.Controls.Add(this.panel2);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.panel1);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.txt_subject);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(1, 196);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(938, 139);
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
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(-3, 127);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(740, 45);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 2;
            this.panelEx1.Text = "panelEx1";
            // 
            // Picserach
            // 
            this.Picserach.Image = global::MyProjectt.Properties.Resources.find;
            this.Picserach.Location = new System.Drawing.Point(84, 27);
            this.Picserach.Name = "Picserach";
            this.Picserach.Size = new System.Drawing.Size(64, 50);
            this.Picserach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picserach.TabIndex = 28;
            this.Picserach.TabStop = false;
            this.Picserach.Click += new System.EventHandler(this.Picserach_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Rad_SecurityAney);
            this.panel2.Controls.Add(this.Rad_Securityins);
            this.panel2.Controls.Add(this.Rad_SecurityNormal);
            this.panel2.Controls.Add(this.Rad_AllSecurity);
            this.panel2.Location = new System.Drawing.Point(234, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 100);
            this.panel2.TabIndex = 27;
            // 
            // Rad_SecurityAney
            // 
            this.Rad_SecurityAney.AutoSize = true;
            this.Rad_SecurityAney.Location = new System.Drawing.Point(14, 65);
            this.Rad_SecurityAney.Name = "Rad_SecurityAney";
            this.Rad_SecurityAney.Size = new System.Drawing.Size(43, 17);
            this.Rad_SecurityAney.TabIndex = 3;
            this.Rad_SecurityAney.Text = "آنی";
            this.Rad_SecurityAney.UseVisualStyleBackColor = true;
            // 
            // Rad_Securityins
            // 
            this.Rad_Securityins.AutoSize = true;
            this.Rad_Securityins.Location = new System.Drawing.Point(69, 65);
            this.Rad_Securityins.Name = "Rad_Securityins";
            this.Rad_Securityins.Size = new System.Drawing.Size(52, 17);
            this.Rad_Securityins.TabIndex = 2;
            this.Rad_Securityins.Text = "فوری";
            this.Rad_Securityins.UseVisualStyleBackColor = true;
            // 
            // Rad_SecurityNormal
            // 
            this.Rad_SecurityNormal.AutoSize = true;
            this.Rad_SecurityNormal.Location = new System.Drawing.Point(14, 20);
            this.Rad_SecurityNormal.Name = "Rad_SecurityNormal";
            this.Rad_SecurityNormal.Size = new System.Drawing.Size(51, 17);
            this.Rad_SecurityNormal.TabIndex = 1;
            this.Rad_SecurityNormal.Text = "عادی";
            this.Rad_SecurityNormal.UseVisualStyleBackColor = true;
            // 
            // Rad_AllSecurity
            // 
            this.Rad_AllSecurity.AutoSize = true;
            this.Rad_AllSecurity.Checked = true;
            this.Rad_AllSecurity.Location = new System.Drawing.Point(77, 20);
            this.Rad_AllSecurity.Name = "Rad_AllSecurity";
            this.Rad_AllSecurity.Size = new System.Drawing.Size(42, 17);
            this.Rad_AllSecurity.TabIndex = 0;
            this.Rad_AllSecurity.TabStop = true;
            this.Rad_AllSecurity.Text = "همه";
            this.Rad_AllSecurity.UseVisualStyleBackColor = true;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(596, 31);
            this.labelX8.Name = "labelX8";
            this.labelX8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX8.Size = new System.Drawing.Size(51, 23);
            this.labelX8.TabIndex = 26;
            this.labelX8.Text = "فوریت نامه :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Rad_ActionM);
            this.panel1.Controls.Add(this.Rad_ActionS);
            this.panel1.Controls.Add(this.Rad_Actionnormal);
            this.panel1.Controls.Add(this.Rad_allAction);
            this.panel1.Location = new System.Drawing.Point(460, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 100);
            this.panel1.TabIndex = 25;
            // 
            // Rad_ActionM
            // 
            this.Rad_ActionM.AutoSize = true;
            this.Rad_ActionM.Location = new System.Drawing.Point(77, 65);
            this.Rad_ActionM.Name = "Rad_ActionM";
            this.Rad_ActionM.Size = new System.Drawing.Size(49, 17);
            this.Rad_ActionM.TabIndex = 3;
            this.Rad_ActionM.Text = "سری";
            this.Rad_ActionM.UseVisualStyleBackColor = true;
            // 
            // Rad_ActionS
            // 
            this.Rad_ActionS.AutoSize = true;
            this.Rad_ActionS.Location = new System.Drawing.Point(14, 65);
            this.Rad_ActionS.Name = "Rad_ActionS";
            this.Rad_ActionS.Size = new System.Drawing.Size(60, 17);
            this.Rad_ActionS.TabIndex = 2;
            this.Rad_ActionS.Text = "محرمانه";
            this.Rad_ActionS.UseVisualStyleBackColor = true;
            // 
            // Rad_Actionnormal
            // 
            this.Rad_Actionnormal.AutoSize = true;
            this.Rad_Actionnormal.Location = new System.Drawing.Point(14, 20);
            this.Rad_Actionnormal.Name = "Rad_Actionnormal";
            this.Rad_Actionnormal.Size = new System.Drawing.Size(51, 17);
            this.Rad_Actionnormal.TabIndex = 1;
            this.Rad_Actionnormal.Text = "عادی";
            this.Rad_Actionnormal.UseVisualStyleBackColor = true;
            // 
            // Rad_allAction
            // 
            this.Rad_allAction.AutoSize = true;
            this.Rad_allAction.Checked = true;
            this.Rad_allAction.Location = new System.Drawing.Point(77, 20);
            this.Rad_allAction.Name = "Rad_allAction";
            this.Rad_allAction.Size = new System.Drawing.Size(42, 17);
            this.Rad_allAction.TabIndex = 0;
            this.Rad_allAction.TabStop = true;
            this.Rad_allAction.Text = "همه";
            this.Rad_allAction.UseVisualStyleBackColor = true;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(359, 34);
            this.labelX7.Name = "labelX7";
            this.labelX7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX7.Size = new System.Drawing.Size(51, 23);
            this.labelX7.TabIndex = 24;
            this.labelX7.Text = "طبقه بندی :";
            // 
            // txt_subject
            // 
            // 
            // 
            // 
            this.txt_subject.Border.Class = "TextBoxBorder";
            this.txt_subject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_subject.Location = new System.Drawing.Point(665, 34);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.PreventEnterBeep = true;
            this.txt_subject.Size = new System.Drawing.Size(162, 20);
            this.txt_subject.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(805, 34);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "موضوع نامه :";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.Btn_EditLetter);
            this.panelEx2.Controls.Add(this.Btn_Deletefromdraft);
            this.panelEx2.Controls.Add(this.Btn_sendletter);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Location = new System.Drawing.Point(1, 341);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(938, 54);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 2;
            // 
            // Btn_EditLetter
            // 
            this.Btn_EditLetter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_EditLetter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_EditLetter.Location = new System.Drawing.Point(257, 16);
            this.Btn_EditLetter.Name = "Btn_EditLetter";
            this.Btn_EditLetter.Size = new System.Drawing.Size(75, 30);
            this.Btn_EditLetter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Btn_EditLetter.TabIndex = 2;
            this.Btn_EditLetter.Text = "ویرایش نامه";
            this.Btn_EditLetter.Click += new System.EventHandler(this.Btn_EditLetter_Click);
            // 
            // Btn_Deletefromdraft
            // 
            this.Btn_Deletefromdraft.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_Deletefromdraft.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_Deletefromdraft.Location = new System.Drawing.Point(371, 16);
            this.Btn_Deletefromdraft.Name = "Btn_Deletefromdraft";
            this.Btn_Deletefromdraft.Size = new System.Drawing.Size(75, 29);
            this.Btn_Deletefromdraft.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Btn_Deletefromdraft.TabIndex = 1;
            this.Btn_Deletefromdraft.Text = "حذف از پیشنویس";
            this.Btn_Deletefromdraft.Click += new System.EventHandler(this.Btn_Deletefromdraft_Click);
            // 
            // Btn_sendletter
            // 
            this.Btn_sendletter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_sendletter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_sendletter.Location = new System.Drawing.Point(504, 16);
            this.Btn_sendletter.Name = "Btn_sendletter";
            this.Btn_sendletter.Size = new System.Drawing.Size(75, 29);
            this.Btn_sendletter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Btn_sendletter.TabIndex = 0;
            this.Btn_sendletter.Text = "ارسال نامه";
            this.Btn_sendletter.Click += new System.EventHandler(this.Btn_sendletter_Click);
            // 
            // LetterID
            // 
            this.LetterID.HeaderText = "LetterID";
            this.LetterID.Name = "LetterID";
            this.LetterID.Visible = false;
            // 
            // SubjectLetter
            // 
            this.SubjectLetter.HeaderText = "موضوع نامه";
            this.SubjectLetter.Name = "SubjectLetter";
            this.SubjectLetter.Width = 125;
            // 
            // LatterNumber
            // 
            this.LatterNumber.HeaderText = "شماره نامه";
            this.LatterNumber.Name = "LatterNumber";
            this.LatterNumber.Width = 110;
            // 
            // CreateDate
            // 
            this.CreateDate.HeaderText = "تاریخ ایجاد";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.Width = 110;
            // 
            // SecurityType
            // 
            this.SecurityType.HeaderText = "فوریت نامه";
            this.SecurityType.Name = "SecurityType";
            this.SecurityType.Width = 110;
            // 
            // LatterTypeAction
            // 
            this.LatterTypeAction.HeaderText = "نوع اقدام";
            this.LatterTypeAction.Name = "LatterTypeAction";
            this.LatterTypeAction.Width = 110;
            // 
            // LetterFollow
            // 
            this.LetterFollow.HeaderText = "پیگیری";
            this.LetterFollow.Name = "LetterFollow";
            this.LetterFollow.Width = 110;
            // 
            // LetterAttachment
            // 
            this.LetterAttachment.HeaderText = "پیوست";
            this.LetterAttachment.Name = "LetterAttachment";
            this.LetterAttachment.Width = 110;
            // 
            // AnswerDedlaine
            // 
            this.AnswerDedlaine.HeaderText = "تاریخ پاسخ";
            this.AnswerDedlaine.Name = "AnswerDedlaine";
            this.AnswerDedlaine.Width = 110;
            // 
            // Lettertype
            // 
            this.Lettertype.HeaderText = "نوع سند";
            this.Lettertype.Name = "Lettertype";
            this.Lettertype.Visible = false;
            // 
            // ST
            // 
            this.ST.HeaderText = "ST";
            this.ST.Name = "ST";
            this.ST.Visible = false;
            // 
            // Frm_ShowDraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 395);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.DG_Show_Draft);
            this.Name = "Frm_ShowDraft";
            this.Text = "پیش نویس ها";
            this.Load += new System.EventHandler(this.Frm_ShowDraft_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Show_Draft)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picserach)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEx2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DG_Show_Draft;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_subject;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.PictureBox Picserach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton Rad_SecurityAney;
        private System.Windows.Forms.RadioButton Rad_Securityins;
        private System.Windows.Forms.RadioButton Rad_SecurityNormal;
        private System.Windows.Forms.RadioButton Rad_AllSecurity;
        private DevComponents.DotNetBar.LabelX labelX8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Rad_ActionM;
        private System.Windows.Forms.RadioButton Rad_ActionS;
        private System.Windows.Forms.RadioButton Rad_Actionnormal;
        private System.Windows.Forms.RadioButton Rad_allAction;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.ButtonX Btn_Deletefromdraft;
        private DevComponents.DotNetBar.ButtonX Btn_sendletter;
        private DevComponents.DotNetBar.ButtonX Btn_EditLetter;
        private System.Windows.Forms.DataGridViewTextBoxColumn LetterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectLetter;
        private System.Windows.Forms.DataGridViewTextBoxColumn LatterNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecurityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn LatterTypeAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn LetterFollow;
        private System.Windows.Forms.DataGridViewTextBoxColumn LetterAttachment;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnswerDedlaine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lettertype;
        private System.Windows.Forms.DataGridViewTextBoxColumn ST;
    }
}