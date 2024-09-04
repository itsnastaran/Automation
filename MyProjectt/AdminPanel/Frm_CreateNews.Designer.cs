namespace MyProjectt.AdminPanel
{
    partial class Frm_CreateNews
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_fileatach = new System.Windows.Forms.Label();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_attachfile = new System.Windows.Forms.Button();
            this.rad_yes = new System.Windows.Forms.RadioButton();
            this.rad_no = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_textnews = new System.Windows.Forms.TextBox();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_fileatach2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl_fileatach
            // 
            this.lbl_fileatach.AutoSize = true;
            this.lbl_fileatach.Location = new System.Drawing.Point(47, 168);
            this.lbl_fileatach.Name = "lbl_fileatach";
            this.lbl_fileatach.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_fileatach.Size = new System.Drawing.Size(0, 13);
            this.lbl_fileatach.TabIndex = 14;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.lbl_fileatach2);
            this.panelEx1.Controls.Add(this.btn_save);
            this.panelEx1.Controls.Add(this.btn_exit);
            this.panelEx1.Controls.Add(this.btn_attachfile);
            this.panelEx1.Controls.Add(this.rad_yes);
            this.panelEx1.Controls.Add(this.rad_no);
            this.panelEx1.Controls.Add(this.label6);
            this.panelEx1.Controls.Add(this.lbl_username);
            this.panelEx1.Controls.Add(this.label4);
            this.panelEx1.Controls.Add(this.lbl_date);
            this.panelEx1.Controls.Add(this.label3);
            this.panelEx1.Controls.Add(this.label2);
            this.panelEx1.Controls.Add(this.txt_textnews);
            this.panelEx1.Controls.Add(this.txt_subject);
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(-5, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(689, 267);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 15;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(372, 220);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 27;
            this.btn_save.Text = "ثبت خبر";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(272, 220);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 26;
            this.btn_exit.Text = "خروج";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_attachfile
            // 
            this.btn_attachfile.Enabled = false;
            this.btn_attachfile.Location = new System.Drawing.Point(284, 146);
            this.btn_attachfile.Name = "btn_attachfile";
            this.btn_attachfile.Size = new System.Drawing.Size(75, 23);
            this.btn_attachfile.TabIndex = 25;
            this.btn_attachfile.Text = "الصاق فایل";
            this.btn_attachfile.UseVisualStyleBackColor = true;
            this.btn_attachfile.Click += new System.EventHandler(this.btn_attachfile_Click);
            // 
            // rad_yes
            // 
            this.rad_yes.AutoSize = true;
            this.rad_yes.Location = new System.Drawing.Point(116, 112);
            this.rad_yes.Name = "rad_yes";
            this.rad_yes.Size = new System.Drawing.Size(43, 17);
            this.rad_yes.TabIndex = 24;
            this.rad_yes.Text = "دارد";
            this.rad_yes.UseVisualStyleBackColor = true;
            this.rad_yes.CheckedChanged += new System.EventHandler(this.rad_yes_CheckedChanged);
            // 
            // rad_no
            // 
            this.rad_no.AutoSize = true;
            this.rad_no.Checked = true;
            this.rad_no.Location = new System.Drawing.Point(185, 112);
            this.rad_no.Name = "rad_no";
            this.rad_no.Size = new System.Drawing.Size(47, 17);
            this.rad_no.TabIndex = 23;
            this.rad_no.TabStop = true;
            this.rad_no.Text = "ندارد";
            this.rad_no.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 112);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "فایل پیوست :";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(206, 65);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_username.Size = new System.Drawing.Size(16, 13);
            this.lbl_username.TabIndex = 21;
            this.lbl_username.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 65);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "کاربر ارسال کننده :";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(209, 27);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_date.Size = new System.Drawing.Size(16, 13);
            this.lbl_date.TabIndex = 19;
            this.lbl_date.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 27);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "تاریخ ایجاد و ارسال خبر :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 72);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "متن خبر :";
            // 
            // txt_textnews
            // 
            this.txt_textnews.Location = new System.Drawing.Point(442, 65);
            this.txt_textnews.Multiline = true;
            this.txt_textnews.Name = "txt_textnews";
            this.txt_textnews.Size = new System.Drawing.Size(158, 125);
            this.txt_textnews.TabIndex = 16;
            // 
            // txt_subject
            // 
            this.txt_subject.Location = new System.Drawing.Point(442, 24);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(158, 20);
            this.txt_subject.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 27);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "موضوع خبر :";
            // 
            // lbl_fileatach2
            // 
            this.lbl_fileatach2.AutoSize = true;
            this.lbl_fileatach2.Location = new System.Drawing.Point(185, 189);
            this.lbl_fileatach2.Name = "lbl_fileatach2";
            this.lbl_fileatach2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_fileatach2.Size = new System.Drawing.Size(16, 13);
            this.lbl_fileatach2.TabIndex = 32;
            this.lbl_fileatach2.Text = "...";
            // 
            // Frm_CreateNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 267);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.lbl_fileatach);
            this.Name = "Frm_CreateNews";
            this.Text = "فرم ایجاد و ارسال خبرنامه";
            this.Load += new System.EventHandler(this.Frm_CreateNews_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbl_fileatach;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_attachfile;
        private System.Windows.Forms.RadioButton rad_yes;
        private System.Windows.Forms.RadioButton rad_no;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_textnews;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_fileatach2;
    }
}