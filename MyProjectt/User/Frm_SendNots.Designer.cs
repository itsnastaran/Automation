namespace MyProjectt.User
{
    partial class Frm_SendNots
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SendNots));
            this.DG_SendNots = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IDNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reciever = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.picsearch = new System.Windows.Forms.PictureBox();
            this.txtreciver = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtsubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dateto = new FreeControls.PersianDateTimePicker();
            this.datefrom = new FreeControls.PersianDateTimePicker();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.DG_SendNots)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picsearch)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_SendNots
            // 
            this.DG_SendNots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_SendNots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDNote,
            this.Subject,
            this.Text,
            this.Reciever,
            this.Senddate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_SendNots.DefaultCellStyle = dataGridViewCellStyle2;
            this.DG_SendNots.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DG_SendNots.Location = new System.Drawing.Point(1, 1);
            this.DG_SendNots.Name = "DG_SendNots";
            this.DG_SendNots.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DG_SendNots.Size = new System.Drawing.Size(754, 248);
            this.DG_SendNots.TabIndex = 0;
            // 
            // IDNote
            // 
            this.IDNote.HeaderText = "IDNote";
            this.IDNote.Name = "IDNote";
            this.IDNote.Visible = false;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "موضوع یادداشت";
            this.Subject.Name = "Subject";
            this.Subject.Width = 170;
            // 
            // Text
            // 
            this.Text.HeaderText = "متن یادداشت";
            this.Text.Name = "Text";
            this.Text.Width = 300;
            // 
            // Reciever
            // 
            this.Reciever.HeaderText = "گیرنده یادداشت";
            this.Reciever.Name = "Reciever";
            this.Reciever.Width = 120;
            // 
            // Senddate
            // 
            this.Senddate.HeaderText = "تاریخ ارسال";
            this.Senddate.Name = "Senddate";
            this.Senddate.Width = 120;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.picsearch);
            this.groupPanel1.Controls.Add(this.txtreciver);
            this.groupPanel1.Controls.Add(this.txtsubject);
            this.groupPanel1.Controls.Add(this.dateto);
            this.groupPanel1.Controls.Add(this.datefrom);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(1, 255);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(754, 100);
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
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // picsearch
            // 
            this.picsearch.Image = global::MyProjectt.Properties.Resources.find1;
            this.picsearch.Location = new System.Drawing.Point(3, 3);
            this.picsearch.Name = "picsearch";
            this.picsearch.Size = new System.Drawing.Size(44, 50);
            this.picsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picsearch.TabIndex = 8;
            this.picsearch.TabStop = false;
            this.picsearch.Click += new System.EventHandler(this.picsearch_Click);
            // 
            // txtreciver
            // 
            // 
            // 
            // 
            this.txtreciver.Border.Class = "TextBoxBorder";
            this.txtreciver.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtreciver.Location = new System.Drawing.Point(53, 23);
            this.txtreciver.Name = "txtreciver";
            this.txtreciver.PreventEnterBeep = true;
            this.txtreciver.Size = new System.Drawing.Size(100, 20);
            this.txtreciver.TabIndex = 7;
            // 
            // txtsubject
            // 
            // 
            // 
            // 
            this.txtsubject.Border.Class = "TextBoxBorder";
            this.txtsubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsubject.Location = new System.Drawing.Point(189, 26);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.PreventEnterBeep = true;
            this.txtsubject.Size = new System.Drawing.Size(100, 20);
            this.txtsubject.TabIndex = 6;
            // 
            // dateto
            // 
            this.dateto.BackColor = System.Drawing.Color.White;
            this.dateto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateto.Location = new System.Drawing.Point(367, 28);
            this.dateto.Name = "dateto";
            this.dateto.ShowTime = false;
            this.dateto.Size = new System.Drawing.Size(130, 18);
            this.dateto.TabIndex = 5;
            this.dateto.Text = "persianDateTimePicker1";
            this.dateto.Value = ((FreeControls.PersianDate)(resources.GetObject("dateto.Value")));
            // 
            // datefrom
            // 
            this.datefrom.BackColor = System.Drawing.Color.White;
            this.datefrom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.datefrom.Location = new System.Drawing.Point(571, 28);
            this.datefrom.Name = "datefrom";
            this.datefrom.ShowTime = false;
            this.datefrom.Size = new System.Drawing.Size(130, 18);
            this.datefrom.TabIndex = 4;
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
            this.labelX4.Location = new System.Drawing.Point(148, 23);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(35, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "گیرنده :";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(284, 23);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(77, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "موضوع یادداشت :";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(479, 23);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(66, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "تا تاریخ :";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(679, 23);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(66, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "از تاریخ :";
            // 
            // Frm_SendNots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 359);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.DG_SendNots);
            this.Location = new System.Drawing.Point(500, 0);
            this.Name = "Frm_SendNots";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.DG_SendNots)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picsearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DG_SendNots;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reciever;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senddate;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtreciver;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsubject;
        private FreeControls.PersianDateTimePicker dateto;
        private FreeControls.PersianDateTimePicker datefrom;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.PictureBox picsearch;
    }
}