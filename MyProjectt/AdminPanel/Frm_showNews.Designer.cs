namespace MyProjectt.AdminPanel
{
    partial class Frm_showNews
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_showNews));
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.NewsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectnews = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Textnews = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Createdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attachfile = new System.Windows.Forms.DataGridViewLinkColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_sendnews = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_editnews = new System.Windows.Forms.ToolStripMenuItem();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.picsearch = new System.Windows.Forms.PictureBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txttext = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dateto = new FreeControls.PersianDateTimePicker();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.datefrom = new FreeControls.PersianDateTimePicker();
            this.txtsubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NewsID,
            this.subjectnews,
            this.Textnews,
            this.Createdate,
            this.Senddate,
            this.Status,
            this.Attachfile});
            this.dataGridViewX1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(1, 43);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewX1.Size = new System.Drawing.Size(694, 150);
            this.dataGridViewX1.TabIndex = 1;
            this.dataGridViewX1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellClick);
            // 
            // NewsID
            // 
            this.NewsID.HeaderText = "NewsID";
            this.NewsID.Name = "NewsID";
            this.NewsID.Visible = false;
            this.NewsID.Width = 90;
            // 
            // subjectnews
            // 
            this.subjectnews.HeaderText = "موضوع خبر";
            this.subjectnews.Name = "subjectnews";
            this.subjectnews.Width = 90;
            // 
            // Textnews
            // 
            this.Textnews.HeaderText = "متن خبر";
            this.Textnews.Name = "Textnews";
            this.Textnews.Width = 200;
            // 
            // Createdate
            // 
            this.Createdate.HeaderText = "تاریخ ایجاد";
            this.Createdate.Name = "Createdate";
            this.Createdate.Width = 90;
            // 
            // Senddate
            // 
            this.Senddate.HeaderText = "تاریخ ارسال";
            this.Senddate.Name = "Senddate";
            this.Senddate.Width = 90;
            // 
            // Status
            // 
            this.Status.HeaderText = "وضعیت";
            this.Status.Name = "Status";
            this.Status.Width = 90;
            // 
            // Attachfile
            // 
            this.Attachfile.HeaderText = "فایل پیوست";
            this.Attachfile.Name = "Attachfile";
            this.Attachfile.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Attachfile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Attachfile.Width = 90;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_sendnews,
            this.btn_editnews});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 48);
            // 
            // btn_sendnews
            // 
            this.btn_sendnews.Name = "btn_sendnews";
            this.btn_sendnews.Size = new System.Drawing.Size(129, 22);
            this.btn_sendnews.Text = "ارسال خبر";
            this.btn_sendnews.Click += new System.EventHandler(this.btn_sendnews_Click_1);
            // 
            // btn_editnews
            // 
            this.btn_editnews.Name = "btn_editnews";
            this.btn_editnews.Size = new System.Drawing.Size(129, 22);
            this.btn_editnews.Text = "ویرایش خبر";
            this.btn_editnews.Click += new System.EventHandler(this.btn_editnews_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.picsearch);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txttext);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.dateto);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.datefrom);
            this.groupPanel1.Controls.Add(this.txtsubject);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(1, 199);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(694, 100);
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
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // picsearch
            // 
            this.picsearch.Image = global::MyProjectt.Properties.Resources.find1;
            this.picsearch.Location = new System.Drawing.Point(8, 24);
            this.picsearch.Name = "picsearch";
            this.picsearch.Size = new System.Drawing.Size(39, 36);
            this.picsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picsearch.TabIndex = 8;
            this.picsearch.TabStop = false;
            this.picsearch.Click += new System.EventHandler(this.picsearch_Click);
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(174, 28);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(26, 23);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "متن :";
            // 
            // txttext
            // 
            // 
            // 
            // 
            this.txttext.Border.Class = "TextBoxBorder";
            this.txttext.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttext.Location = new System.Drawing.Point(75, 31);
            this.txttext.Name = "txttext";
            this.txttext.PreventEnterBeep = true;
            this.txttext.Size = new System.Drawing.Size(100, 20);
            this.txttext.TabIndex = 6;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(298, 28);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(48, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "موضوع :";
            // 
            // dateto
            // 
            this.dateto.BackColor = System.Drawing.Color.White;
            this.dateto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateto.Location = new System.Drawing.Point(352, 29);
            this.dateto.Name = "dateto";
            this.dateto.ShowTime = false;
            this.dateto.Size = new System.Drawing.Size(120, 18);
            this.dateto.TabIndex = 4;
            this.dateto.Text = "persianDateTimePicker1";
            this.dateto.Value = ((FreeControls.PersianDate)(resources.GetObject("dateto.Value")));
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(462, 28);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(48, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "تا تاریخ :";
            // 
            // datefrom
            // 
            this.datefrom.BackColor = System.Drawing.Color.White;
            this.datefrom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.datefrom.Location = new System.Drawing.Point(520, 29);
            this.datefrom.Name = "datefrom";
            this.datefrom.ShowTime = false;
            this.datefrom.Size = new System.Drawing.Size(123, 18);
            this.datefrom.TabIndex = 2;
            this.datefrom.Text = "persianDateTimePicker1";
            this.datefrom.Value = ((FreeControls.PersianDate)(resources.GetObject("datefrom.Value")));
            // 
            // txtsubject
            // 
            // 
            // 
            // 
            this.txtsubject.Border.Class = "TextBoxBorder";
            this.txtsubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsubject.Location = new System.Drawing.Point(206, 31);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.PreventEnterBeep = true;
            this.txtsubject.Size = new System.Drawing.Size(100, 20);
            this.txtsubject.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(633, 24);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(48, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "از تاریخ :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyProjectt.Properties.Resources._1325236148_DeleteRed;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Frm_showNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 311);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_showNews";
            this.Text = "فرم نمایش خبرها";
            this.Load += new System.EventHandler(this.Frm_showNews_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.PictureBox picsearch;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txttext;
        private DevComponents.DotNetBar.LabelX labelX3;
        private FreeControls.PersianDateTimePicker dateto;
        private DevComponents.DotNetBar.LabelX labelX2;
        private FreeControls.PersianDateTimePicker datefrom;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsubject;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_sendnews;
        private System.Windows.Forms.ToolStripMenuItem btn_editnews;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectnews;
        private System.Windows.Forms.DataGridViewTextBoxColumn Textnews;
        private System.Windows.Forms.DataGridViewTextBoxColumn Createdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewLinkColumn Attachfile;
    }
}