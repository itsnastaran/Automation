﻿namespace MyProjectt.User
{
    partial class Frm_SendLatters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SendLatters));
            this.DG_ReciveAllLetters = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Pic_search = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Rad_FlowFalse = new System.Windows.Forms.RadioButton();
            this.Rad_FlowTrue = new System.Windows.Forms.RadioButton();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Rad_AtachFalse = new System.Windows.Forms.RadioButton();
            this.Rad_AtachTrue = new System.Windows.Forms.RadioButton();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Rad_IsReadFalse = new System.Windows.Forms.RadioButton();
            this.Rad_IsReadTrue = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Rad_BayganiFalse = new System.Windows.Forms.RadioButton();
            this.Rad_BayganiTrue = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Rad_LAAniy = new System.Windows.Forms.RadioButton();
            this.Rad_LAFori = new System.Windows.Forms.RadioButton();
            this.Rad_LANormal = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rad_SSeri = new System.Windows.Forms.RadioButton();
            this.Rad_SMahramane = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Rad_SNormal = new System.Windows.Forms.RadioButton();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtsubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtletterref = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtreciver = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtletternumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dateto = new FreeControls.PersianDateTimePicker();
            this.datefrom = new FreeControls.PersianDateTimePicker();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.savefiles = new System.Windows.Forms.SaveFileDialog();
            this.LetterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecurityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAtction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LatterNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LatterSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserReciveLatters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Security = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LatterAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ByganiType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LatterType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnswerDedlain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtachmentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LattterRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latterflow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileAtachment = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ReciveAllLetters)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_search)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DG_ReciveAllLetters
            // 
            this.DG_ReciveAllLetters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_ReciveAllLetters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LetterID,
            this.SecurityType,
            this.LAtction,
            this.LatterNumber,
            this.LatterSubject,
            this.UserReciveLatters,
            this.Security,
            this.LatterAction,
            this.ByganiType,
            this.LatterType,
            this.AnswerDedlain,
            this.AtachmentType,
            this.LattterRef,
            this.SendDate,
            this.Latterflow,
            this.FileAtachment});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_ReciveAllLetters.DefaultCellStyle = dataGridViewCellStyle1;
            this.DG_ReciveAllLetters.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.DG_ReciveAllLetters.Location = new System.Drawing.Point(2, 1);
            this.DG_ReciveAllLetters.Name = "DG_ReciveAllLetters";
            this.DG_ReciveAllLetters.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DG_ReciveAllLetters.Size = new System.Drawing.Size(942, 321);
            this.DG_ReciveAllLetters.TabIndex = 0;
            this.DG_ReciveAllLetters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_ReciveAllLetters_CellClick);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.Pic_search);
            this.groupPanel1.Controls.Add(this.panel6);
            this.groupPanel1.Controls.Add(this.labelX12);
            this.groupPanel1.Controls.Add(this.panel5);
            this.groupPanel1.Controls.Add(this.labelX11);
            this.groupPanel1.Controls.Add(this.panel4);
            this.groupPanel1.Controls.Add(this.labelX10);
            this.groupPanel1.Controls.Add(this.panel3);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.panel2);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.panel1);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.txtsubject);
            this.groupPanel1.Controls.Add(this.txtletterref);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.txtreciver);
            this.groupPanel1.Controls.Add(this.txtletternumber);
            this.groupPanel1.Controls.Add(this.dateto);
            this.groupPanel1.Controls.Add(this.datefrom);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(2, 329);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(936, 193);
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
            // Pic_search
            // 
            this.Pic_search.Image = global::MyProjectt.Properties.Resources.find1;
            this.Pic_search.Location = new System.Drawing.Point(3, 95);
            this.Pic_search.Name = "Pic_search";
            this.Pic_search.Size = new System.Drawing.Size(57, 50);
            this.Pic_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_search.TabIndex = 32;
            this.Pic_search.TabStop = false;
            this.Pic_search.Click += new System.EventHandler(this.Pic_search_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.Rad_FlowFalse);
            this.panel6.Controls.Add(this.Rad_FlowTrue);
            this.panel6.Controls.Add(this.radioButton20);
            this.panel6.Location = new System.Drawing.Point(76, 63);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(62, 100);
            this.panel6.TabIndex = 31;
            // 
            // Rad_FlowFalse
            // 
            this.Rad_FlowFalse.AutoSize = true;
            this.Rad_FlowFalse.Location = new System.Drawing.Point(14, 65);
            this.Rad_FlowFalse.Name = "Rad_FlowFalse";
            this.Rad_FlowFalse.Size = new System.Drawing.Size(47, 17);
            this.Rad_FlowFalse.TabIndex = 3;
            this.Rad_FlowFalse.Text = "ندارد";
            this.Rad_FlowFalse.UseVisualStyleBackColor = true;
            // 
            // Rad_FlowTrue
            // 
            this.Rad_FlowTrue.AutoSize = true;
            this.Rad_FlowTrue.Location = new System.Drawing.Point(14, 42);
            this.Rad_FlowTrue.Name = "Rad_FlowTrue";
            this.Rad_FlowTrue.Size = new System.Drawing.Size(43, 17);
            this.Rad_FlowTrue.TabIndex = 1;
            this.Rad_FlowTrue.Text = "دارد";
            this.Rad_FlowTrue.UseVisualStyleBackColor = true;
            // 
            // radioButton20
            // 
            this.radioButton20.AutoSize = true;
            this.radioButton20.Checked = true;
            this.radioButton20.Location = new System.Drawing.Point(14, 19);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(42, 17);
            this.radioButton20.TabIndex = 0;
            this.radioButton20.TabStop = true;
            this.radioButton20.Text = "همه";
            this.radioButton20.UseVisualStyleBackColor = true;
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(144, 88);
            this.labelX12.Name = "labelX12";
            this.labelX12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX12.Size = new System.Drawing.Size(32, 23);
            this.labelX12.TabIndex = 30;
            this.labelX12.Text = "پیگیری :";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.Rad_AtachFalse);
            this.panel5.Controls.Add(this.Rad_AtachTrue);
            this.panel5.Controls.Add(this.radioButton17);
            this.panel5.Location = new System.Drawing.Point(182, 63);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(62, 100);
            this.panel5.TabIndex = 29;
            // 
            // Rad_AtachFalse
            // 
            this.Rad_AtachFalse.AutoSize = true;
            this.Rad_AtachFalse.Location = new System.Drawing.Point(14, 65);
            this.Rad_AtachFalse.Name = "Rad_AtachFalse";
            this.Rad_AtachFalse.Size = new System.Drawing.Size(47, 17);
            this.Rad_AtachFalse.TabIndex = 3;
            this.Rad_AtachFalse.Text = "ندارد";
            this.Rad_AtachFalse.UseVisualStyleBackColor = true;
            // 
            // Rad_AtachTrue
            // 
            this.Rad_AtachTrue.AutoSize = true;
            this.Rad_AtachTrue.Location = new System.Drawing.Point(13, 40);
            this.Rad_AtachTrue.Name = "Rad_AtachTrue";
            this.Rad_AtachTrue.Size = new System.Drawing.Size(43, 17);
            this.Rad_AtachTrue.TabIndex = 1;
            this.Rad_AtachTrue.Text = "دارد";
            this.Rad_AtachTrue.UseVisualStyleBackColor = true;
            // 
            // radioButton17
            // 
            this.radioButton17.AutoSize = true;
            this.radioButton17.Checked = true;
            this.radioButton17.Location = new System.Drawing.Point(14, 19);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(42, 17);
            this.radioButton17.TabIndex = 0;
            this.radioButton17.TabStop = true;
            this.radioButton17.Text = "همه";
            this.radioButton17.UseVisualStyleBackColor = true;
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(246, 86);
            this.labelX11.Name = "labelX11";
            this.labelX11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX11.Size = new System.Drawing.Size(32, 23);
            this.labelX11.TabIndex = 28;
            this.labelX11.Text = "پیوست :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.Rad_IsReadFalse);
            this.panel4.Controls.Add(this.Rad_IsReadTrue);
            this.panel4.Controls.Add(this.radioButton14);
            this.panel4.Location = new System.Drawing.Point(284, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(98, 100);
            this.panel4.TabIndex = 27;
            // 
            // Rad_IsReadFalse
            // 
            this.Rad_IsReadFalse.AutoSize = true;
            this.Rad_IsReadFalse.Location = new System.Drawing.Point(14, 65);
            this.Rad_IsReadFalse.Name = "Rad_IsReadFalse";
            this.Rad_IsReadFalse.Size = new System.Drawing.Size(83, 17);
            this.Rad_IsReadFalse.TabIndex = 3;
            this.Rad_IsReadFalse.Text = "خوانده نشده";
            this.Rad_IsReadFalse.UseVisualStyleBackColor = true;
            // 
            // Rad_IsReadTrue
            // 
            this.Rad_IsReadTrue.AutoSize = true;
            this.Rad_IsReadTrue.Location = new System.Drawing.Point(14, 42);
            this.Rad_IsReadTrue.Name = "Rad_IsReadTrue";
            this.Rad_IsReadTrue.Size = new System.Drawing.Size(79, 17);
            this.Rad_IsReadTrue.TabIndex = 1;
            this.Rad_IsReadTrue.Text = "خوانده شده";
            this.Rad_IsReadTrue.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Checked = true;
            this.radioButton14.Location = new System.Drawing.Point(14, 19);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(42, 17);
            this.radioButton14.TabIndex = 0;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "همه";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(383, 88);
            this.labelX10.Name = "labelX10";
            this.labelX10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX10.Size = new System.Drawing.Size(51, 23);
            this.labelX10.TabIndex = 26;
            this.labelX10.Text = "خوانده شدن :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.Rad_BayganiFalse);
            this.panel3.Controls.Add(this.Rad_BayganiTrue);
            this.panel3.Controls.Add(this.radioButton12);
            this.panel3.Location = new System.Drawing.Point(440, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(108, 100);
            this.panel3.TabIndex = 25;
            // 
            // Rad_BayganiFalse
            // 
            this.Rad_BayganiFalse.AutoSize = true;
            this.Rad_BayganiFalse.Location = new System.Drawing.Point(14, 65);
            this.Rad_BayganiFalse.Name = "Rad_BayganiFalse";
            this.Rad_BayganiFalse.Size = new System.Drawing.Size(87, 17);
            this.Rad_BayganiFalse.TabIndex = 3;
            this.Rad_BayganiFalse.Text = "بایگانی ندارد";
            this.Rad_BayganiFalse.UseVisualStyleBackColor = true;
            // 
            // Rad_BayganiTrue
            // 
            this.Rad_BayganiTrue.AutoSize = true;
            this.Rad_BayganiTrue.Location = new System.Drawing.Point(14, 42);
            this.Rad_BayganiTrue.Name = "Rad_BayganiTrue";
            this.Rad_BayganiTrue.Size = new System.Drawing.Size(83, 17);
            this.Rad_BayganiTrue.TabIndex = 1;
            this.Rad_BayganiTrue.Text = "بایگانی دارد";
            this.Rad_BayganiTrue.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Checked = true;
            this.radioButton12.Location = new System.Drawing.Point(14, 19);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(42, 17);
            this.radioButton12.TabIndex = 0;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "همه";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(527, 88);
            this.labelX9.Name = "labelX9";
            this.labelX9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX9.Size = new System.Drawing.Size(51, 23);
            this.labelX9.TabIndex = 24;
            this.labelX9.Text = "بایگانی :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Rad_LAAniy);
            this.panel2.Controls.Add(this.Rad_LAFori);
            this.panel2.Controls.Add(this.Rad_LANormal);
            this.panel2.Controls.Add(this.radioButton8);
            this.panel2.Location = new System.Drawing.Point(584, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 100);
            this.panel2.TabIndex = 23;
            // 
            // Rad_LAAniy
            // 
            this.Rad_LAAniy.AutoSize = true;
            this.Rad_LAAniy.Location = new System.Drawing.Point(14, 65);
            this.Rad_LAAniy.Name = "Rad_LAAniy";
            this.Rad_LAAniy.Size = new System.Drawing.Size(43, 17);
            this.Rad_LAAniy.TabIndex = 3;
            this.Rad_LAAniy.Text = "آنی";
            this.Rad_LAAniy.UseVisualStyleBackColor = true;
            // 
            // Rad_LAFori
            // 
            this.Rad_LAFori.AutoSize = true;
            this.Rad_LAFori.Location = new System.Drawing.Point(69, 65);
            this.Rad_LAFori.Name = "Rad_LAFori";
            this.Rad_LAFori.Size = new System.Drawing.Size(52, 17);
            this.Rad_LAFori.TabIndex = 2;
            this.Rad_LAFori.Text = "فوری";
            this.Rad_LAFori.UseVisualStyleBackColor = true;
            // 
            // Rad_LANormal
            // 
            this.Rad_LANormal.AutoSize = true;
            this.Rad_LANormal.Location = new System.Drawing.Point(14, 20);
            this.Rad_LANormal.Name = "Rad_LANormal";
            this.Rad_LANormal.Size = new System.Drawing.Size(51, 17);
            this.Rad_LANormal.TabIndex = 1;
            this.Rad_LANormal.Text = "عادی";
            this.Rad_LANormal.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Checked = true;
            this.radioButton8.Location = new System.Drawing.Point(77, 20);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(42, 17);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "همه";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(694, 88);
            this.labelX8.Name = "labelX8";
            this.labelX8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX8.Size = new System.Drawing.Size(51, 23);
            this.labelX8.TabIndex = 22;
            this.labelX8.Text = "نوع اقدام :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Rad_SSeri);
            this.panel1.Controls.Add(this.Rad_SMahramane);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.Rad_SNormal);
            this.panel1.Location = new System.Drawing.Point(752, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 100);
            this.panel1.TabIndex = 21;
            // 
            // Rad_SSeri
            // 
            this.Rad_SSeri.AutoSize = true;
            this.Rad_SSeri.Location = new System.Drawing.Point(14, 65);
            this.Rad_SSeri.Name = "Rad_SSeri";
            this.Rad_SSeri.Size = new System.Drawing.Size(49, 17);
            this.Rad_SSeri.TabIndex = 3;
            this.Rad_SSeri.Text = "سری";
            this.Rad_SSeri.UseVisualStyleBackColor = true;
            // 
            // Rad_SMahramane
            // 
            this.Rad_SMahramane.AutoSize = true;
            this.Rad_SMahramane.Location = new System.Drawing.Point(69, 65);
            this.Rad_SMahramane.Name = "Rad_SMahramane";
            this.Rad_SMahramane.Size = new System.Drawing.Size(60, 17);
            this.Rad_SMahramane.TabIndex = 2;
            this.Rad_SMahramane.Text = "محرمانه";
            this.Rad_SMahramane.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(14, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "عادی";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Rad_SNormal
            // 
            this.Rad_SNormal.AutoSize = true;
            this.Rad_SNormal.Checked = true;
            this.Rad_SNormal.Location = new System.Drawing.Point(77, 20);
            this.Rad_SNormal.Name = "Rad_SNormal";
            this.Rad_SNormal.Size = new System.Drawing.Size(42, 17);
            this.Rad_SNormal.TabIndex = 0;
            this.Rad_SNormal.TabStop = true;
            this.Rad_SNormal.Text = "همه";
            this.Rad_SNormal.UseVisualStyleBackColor = true;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(876, 88);
            this.labelX7.Name = "labelX7";
            this.labelX7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX7.Size = new System.Drawing.Size(51, 23);
            this.labelX7.TabIndex = 20;
            this.labelX7.Text = "طبقه بندی :";
            // 
            // txtsubject
            // 
            // 
            // 
            // 
            this.txtsubject.Border.Class = "TextBoxBorder";
            this.txtsubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsubject.Location = new System.Drawing.Point(182, 14);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.PreventEnterBeep = true;
            this.txtsubject.Size = new System.Drawing.Size(100, 20);
            this.txtsubject.TabIndex = 19;
            // 
            // txtletterref
            // 
            // 
            // 
            // 
            this.txtletterref.Border.Class = "TextBoxBorder";
            this.txtletterref.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtletterref.Location = new System.Drawing.Point(44, 14);
            this.txtletterref.Name = "txtletterref";
            this.txtletterref.PreventEnterBeep = true;
            this.txtletterref.Size = new System.Drawing.Size(96, 20);
            this.txtletterref.TabIndex = 18;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(128, 12);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX5.Size = new System.Drawing.Size(48, 23);
            this.labelX5.TabIndex = 17;
            this.labelX5.Text = "عطف به :";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(284, 14);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(38, 23);
            this.labelX6.TabIndex = 16;
            this.labelX6.Text = "موضوع :";
            // 
            // txtreciver
            // 
            // 
            // 
            // 
            this.txtreciver.Border.Class = "TextBoxBorder";
            this.txtreciver.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtreciver.Location = new System.Drawing.Point(483, 17);
            this.txtreciver.Name = "txtreciver";
            this.txtreciver.PreventEnterBeep = true;
            this.txtreciver.Size = new System.Drawing.Size(100, 20);
            this.txtreciver.TabIndex = 15;
            // 
            // txtletternumber
            // 
            // 
            // 
            // 
            this.txtletternumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtletternumber.Location = new System.Drawing.Point(333, 16);
            this.txtletternumber.Name = "txtletternumber";
            this.txtletternumber.PreventEnterBeep = true;
            this.txtletternumber.Size = new System.Drawing.Size(100, 20);
            this.txtletternumber.TabIndex = 14;
            // 
            // dateto
            // 
            this.dateto.BackColor = System.Drawing.Color.White;
            this.dateto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateto.Location = new System.Drawing.Point(623, 19);
            this.dateto.Name = "dateto";
            this.dateto.ShowTime = false;
            this.dateto.Size = new System.Drawing.Size(115, 18);
            this.dateto.TabIndex = 13;
            this.dateto.Text = "persianDateTimePicker1";
            this.dateto.Value = ((FreeControls.PersianDate)(resources.GetObject("dateto.Value")));
            // 
            // datefrom
            // 
            this.datefrom.BackColor = System.Drawing.Color.White;
            this.datefrom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.datefrom.Location = new System.Drawing.Point(781, 19);
            this.datefrom.Name = "datefrom";
            this.datefrom.ShowTime = false;
            this.datefrom.Size = new System.Drawing.Size(110, 18);
            this.datefrom.TabIndex = 12;
            this.datefrom.Text = "persianDateTimePicker1";
            this.datefrom.Value = ((FreeControls.PersianDate)(resources.GetObject("datefrom.Value")));
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(428, 14);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(49, 23);
            this.labelX4.TabIndex = 11;
            this.labelX4.Text = "شماره نامه :";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(577, 16);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(38, 23);
            this.labelX3.TabIndex = 10;
            this.labelX3.Text = "گیرنده :";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(733, 16);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(42, 23);
            this.labelX2.TabIndex = 9;
            this.labelX2.Text = "تا تاریخ :";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(888, 16);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(40, 23);
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "از تاریخ :";
            // 
            // LetterID
            // 
            this.LetterID.HeaderText = "LetterID";
            this.LetterID.Name = "LetterID";
            this.LetterID.Visible = false;
            // 
            // SecurityType
            // 
            this.SecurityType.HeaderText = "SecurityType";
            this.SecurityType.Name = "SecurityType";
            this.SecurityType.Visible = false;
            // 
            // LAtction
            // 
            this.LAtction.HeaderText = "LAtction";
            this.LAtction.Name = "LAtction";
            this.LAtction.Visible = false;
            // 
            // LatterNumber
            // 
            this.LatterNumber.HeaderText = "شماره نامه";
            this.LatterNumber.Name = "LatterNumber";
            this.LatterNumber.Width = 120;
            // 
            // LatterSubject
            // 
            this.LatterSubject.HeaderText = "موضوع";
            this.LatterSubject.Name = "LatterSubject";
            this.LatterSubject.Width = 120;
            // 
            // UserReciveLatters
            // 
            this.UserReciveLatters.HeaderText = "گیرنده";
            this.UserReciveLatters.Name = "UserReciveLatters";
            this.UserReciveLatters.Width = 120;
            // 
            // Security
            // 
            this.Security.HeaderText = "طبقه بندی";
            this.Security.Name = "Security";
            this.Security.Width = 120;
            // 
            // LatterAction
            // 
            this.LatterAction.HeaderText = "فوریت";
            this.LatterAction.Name = "LatterAction";
            this.LatterAction.Width = 120;
            // 
            // ByganiType
            // 
            this.ByganiType.HeaderText = "بایگانی";
            this.ByganiType.Name = "ByganiType";
            // 
            // LatterType
            // 
            this.LatterType.HeaderText = "نوع سند";
            this.LatterType.Name = "LatterType";
            this.LatterType.Visible = false;
            // 
            // AnswerDedlain
            // 
            this.AnswerDedlain.HeaderText = "مهلت پاسخ";
            this.AnswerDedlain.Name = "AnswerDedlain";
            // 
            // AtachmentType
            // 
            this.AtachmentType.HeaderText = "پیوست";
            this.AtachmentType.Name = "AtachmentType";
            // 
            // LattterRef
            // 
            this.LattterRef.HeaderText = "عطف به";
            this.LattterRef.Name = "LattterRef";
            // 
            // SendDate
            // 
            this.SendDate.HeaderText = "تاریخ ارسال";
            this.SendDate.Name = "SendDate";
            // 
            // Latterflow
            // 
            this.Latterflow.HeaderText = "پیگیری";
            this.Latterflow.Name = "Latterflow";
            // 
            // FileAtachment
            // 
            this.FileAtachment.HeaderText = "دانلود فایل پیوست";
            this.FileAtachment.Name = "FileAtachment";
            this.FileAtachment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FileAtachment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Frm_SendLatters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 524);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.DG_ReciveAllLetters);
            this.Name = "Frm_SendLatters";
            this.Text = "نمایش نامه های صادره";
            this.Load += new System.EventHandler(this.Frm_SendLatters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_ReciveAllLetters)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_search)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DG_ReciveAllLetters;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.PictureBox Pic_search;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton Rad_FlowFalse;
        private System.Windows.Forms.RadioButton Rad_FlowTrue;
        private System.Windows.Forms.RadioButton radioButton20;
        private DevComponents.DotNetBar.LabelX labelX12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton Rad_AtachFalse;
        private System.Windows.Forms.RadioButton Rad_AtachTrue;
        private System.Windows.Forms.RadioButton radioButton17;
        private DevComponents.DotNetBar.LabelX labelX11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton Rad_IsReadFalse;
        private System.Windows.Forms.RadioButton Rad_IsReadTrue;
        private System.Windows.Forms.RadioButton radioButton14;
        private DevComponents.DotNetBar.LabelX labelX10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton Rad_BayganiFalse;
        private System.Windows.Forms.RadioButton Rad_BayganiTrue;
        private System.Windows.Forms.RadioButton radioButton12;
        private DevComponents.DotNetBar.LabelX labelX9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton Rad_LAAniy;
        private System.Windows.Forms.RadioButton Rad_LAFori;
        private System.Windows.Forms.RadioButton Rad_LANormal;
        private System.Windows.Forms.RadioButton radioButton8;
        private DevComponents.DotNetBar.LabelX labelX8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Rad_SSeri;
        private System.Windows.Forms.RadioButton Rad_SMahramane;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton Rad_SNormal;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsubject;
        private DevComponents.DotNetBar.Controls.TextBoxX txtletterref;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtreciver;
        private DevComponents.DotNetBar.Controls.TextBoxX txtletternumber;
        private FreeControls.PersianDateTimePicker dateto;
        private FreeControls.PersianDateTimePicker datefrom;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.SaveFileDialog savefiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn LetterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecurityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn LAtction;
        private System.Windows.Forms.DataGridViewTextBoxColumn LatterNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn LatterSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserReciveLatters;
        private System.Windows.Forms.DataGridViewTextBoxColumn Security;
        private System.Windows.Forms.DataGridViewTextBoxColumn LatterAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ByganiType;
        private System.Windows.Forms.DataGridViewTextBoxColumn LatterType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnswerDedlain;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtachmentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn LattterRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latterflow;
        private System.Windows.Forms.DataGridViewLinkColumn FileAtachment;
    }
}