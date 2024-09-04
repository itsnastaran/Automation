namespace MyProjectt.User
{
    partial class Frm_AllNotRecive
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AllNotRecive));
            this.DG_SendNots = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID_Not = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Not_Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenderAllNots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateSenders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Pic_search = new System.Windows.Forms.PictureBox();
            this.txtsender = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtsubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dateto = new FreeControls.PersianDateTimePicker();
            this.datefrom = new FreeControls.PersianDateTimePicker();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.DG_SendNots)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_search)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_SendNots
            // 
            this.DG_SendNots.AllowUserToAddRows = false;
            this.DG_SendNots.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DG_SendNots.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_SendNots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_SendNots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Not,
            this.Subject,
            this.Not_Text,
            this.SenderAllNots,
            this.DateSenders});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Mitra", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_SendNots.DefaultCellStyle = dataGridViewCellStyle2;
            this.DG_SendNots.Dock = System.Windows.Forms.DockStyle.Top;
            this.DG_SendNots.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DG_SendNots.Location = new System.Drawing.Point(0, 0);
            this.DG_SendNots.Name = "DG_SendNots";
            this.DG_SendNots.ReadOnly = true;
            this.DG_SendNots.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DG_SendNots.Size = new System.Drawing.Size(939, 300);
            this.DG_SendNots.TabIndex = 1;
            // 
            // ID_Not
            // 
            this.ID_Not.HeaderText = "ID_Not";
            this.ID_Not.Name = "ID_Not";
            this.ID_Not.ReadOnly = true;
            this.ID_Not.Visible = false;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "موضوع یاداشت";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Width = 250;
            // 
            // Not_Text
            // 
            this.Not_Text.HeaderText = "متن یاداشت";
            this.Not_Text.Name = "Not_Text";
            this.Not_Text.ReadOnly = true;
            this.Not_Text.Width = 500;
            // 
            // SenderAllNots
            // 
            this.SenderAllNots.HeaderText = "فرستنده یاداشت";
            this.SenderAllNots.Name = "SenderAllNots";
            this.SenderAllNots.ReadOnly = true;
            this.SenderAllNots.Width = 120;
            // 
            // DateSenders
            // 
            this.DateSenders.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DateSenders.HeaderText = "تاریخ دریافت";
            this.DateSenders.Name = "DateSenders";
            this.DateSenders.ReadOnly = true;
            this.DateSenders.Width = 110;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.Pic_search);
            this.groupPanel1.Controls.Add(this.txtsender);
            this.groupPanel1.Controls.Add(this.txtsubject);
            this.groupPanel1.Controls.Add(this.dateto);
            this.groupPanel1.Controls.Add(this.datefrom);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(0, 306);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1026, 100);
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
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "جستجو";
            // 
            // Pic_search
            // 
            this.Pic_search.Image = global::MyProjectt.Properties.Resources.find1;
            this.Pic_search.Location = new System.Drawing.Point(9, 15);
            this.Pic_search.Name = "Pic_search";
            this.Pic_search.Size = new System.Drawing.Size(57, 50);
            this.Pic_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_search.TabIndex = 33;
            this.Pic_search.TabStop = false;
            this.Pic_search.Click += new System.EventHandler(this.Pic_search_Click);
            // 
            // txtsender
            // 
            // 
            // 
            // 
            this.txtsender.Border.Class = "TextBoxBorder";
            this.txtsender.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsender.Location = new System.Drawing.Point(101, 32);
            this.txtsender.Name = "txtsender";
            this.txtsender.PreventEnterBeep = true;
            this.txtsender.Size = new System.Drawing.Size(134, 20);
            this.txtsender.TabIndex = 24;
            // 
            // txtsubject
            // 
            // 
            // 
            // 
            this.txtsubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsubject.Location = new System.Drawing.Point(293, 30);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.PreventEnterBeep = true;
            this.txtsubject.Size = new System.Drawing.Size(134, 20);
            this.txtsubject.TabIndex = 23;
            // 
            // dateto
            // 
            this.dateto.BackColor = System.Drawing.Color.White;
            this.dateto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateto.Location = new System.Drawing.Point(514, 30);
            this.dateto.Name = "dateto";
            this.dateto.ShowTime = false;
            this.dateto.Size = new System.Drawing.Size(165, 18);
            this.dateto.TabIndex = 21;
            this.dateto.Text = "persianDateTimePicker1";
            this.dateto.Value = ((FreeControls.PersianDate)(resources.GetObject("dateto.Value")));
            // 
            // datefrom
            // 
            this.datefrom.BackColor = System.Drawing.Color.White;
            this.datefrom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.datefrom.Location = new System.Drawing.Point(730, 29);
            this.datefrom.Name = "datefrom";
            this.datefrom.ShowTime = false;
            this.datefrom.Size = new System.Drawing.Size(149, 18);
            this.datefrom.TabIndex = 20;
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
            this.labelX4.Location = new System.Drawing.Point(225, 27);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(49, 23);
            this.labelX4.TabIndex = 19;
            this.labelX4.Text = "فرستنده :";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(424, 29);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(71, 23);
            this.labelX3.TabIndex = 18;
            this.labelX3.Text = "موضوع یادداشت :";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(672, 27);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(42, 23);
            this.labelX2.TabIndex = 17;
            this.labelX2.Text = "تا تاریخ :";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(885, 27);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(40, 23);
            this.labelX1.TabIndex = 16;
            this.labelX1.Text = "از تاریخ :";
            // 
            // Frm_AllNotRecive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 401);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.DG_SendNots);
            this.Name = "Frm_AllNotRecive";
            this.Text = "فرم نمایش یادداشت های دریافتی";
            this.Load += new System.EventHandler(this.Frm_AllNotRecive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_SendNots)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DG_SendNots;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Not;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Not_Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenderAllNots;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateSenders;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsender;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsubject;
        private FreeControls.PersianDateTimePicker dateto;
        private FreeControls.PersianDateTimePicker datefrom;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.PictureBox Pic_search;
    }
}