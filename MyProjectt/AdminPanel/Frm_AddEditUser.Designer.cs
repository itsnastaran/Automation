namespace MyProjectt.AdminPanel
{
    partial class Frm_AddEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddEditUser));
            this.openFileDia = new System.Windows.Forms.OpenFileDialog();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator4 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator5 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator6 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator7 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.Lbl_date = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pic_Sig = new System.Windows.Forms.PictureBox();
            this.pic_User = new System.Windows.Forms.PictureBox();
            this.rad_Man = new System.Windows.Forms.RadioButton();
            this.rad_Woman = new System.Windows.Forms.RadioButton();
            this.com_Usertype = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_date = new FreeControls.PersianDateTimePicker();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.txt_Personalcode = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Family = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDia
            // 
            this.openFileDia.FileName = "openFileDialog1";
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txt_Name;
            this.requiredFieldValidator1.ErrorMessage = "نام نمیتواند خالی باشد";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txt_Family;
            this.requiredFieldValidator2.ErrorMessage = "نام نمیتواند خالی باشد";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator3.ControlToValidate = this.txt_Username;
            this.requiredFieldValidator3.ErrorMessage = "نام نمیتواند خالی باشد";
            this.requiredFieldValidator3.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator3.Icon")));
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator4.ControlToValidate = this.txt_password;
            this.requiredFieldValidator4.ErrorMessage = "نام نمیتواند خالی باشد";
            this.requiredFieldValidator4.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator4.Icon")));
            // 
            // requiredFieldValidator5
            // 
            this.requiredFieldValidator5.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator5.ControlToValidate = this.txt_Email;
            this.requiredFieldValidator5.ErrorMessage = "نام نمیتواند خالی باشد";
            this.requiredFieldValidator5.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator5.Icon")));
            // 
            // requiredFieldValidator6
            // 
            this.requiredFieldValidator6.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator6.ControlToValidate = this.txt_Phone;
            this.requiredFieldValidator6.ErrorMessage = "نام نمیتواند خالی باشد";
            this.requiredFieldValidator6.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator6.Icon")));
            // 
            // requiredFieldValidator7
            // 
            this.requiredFieldValidator7.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator7.ControlToValidate = this.txt_Personalcode;
            this.requiredFieldValidator7.ErrorMessage = "نام نمیتواند خالی باشد";
            this.requiredFieldValidator7.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator7.Icon")));
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.Lbl_date);
            this.panelEx1.Controls.Add(this.btn_Save);
            this.panelEx1.Controls.Add(this.btn_Exit);
            this.panelEx1.Controls.Add(this.pic_Sig);
            this.panelEx1.Controls.Add(this.pic_User);
            this.panelEx1.Controls.Add(this.rad_Man);
            this.panelEx1.Controls.Add(this.rad_Woman);
            this.panelEx1.Controls.Add(this.com_Usertype);
            this.panelEx1.Controls.Add(this.label7);
            this.panelEx1.Controls.Add(this.label8);
            this.panelEx1.Controls.Add(this.label6);
            this.panelEx1.Controls.Add(this.txt_date);
            this.panelEx1.Controls.Add(this.Lbl_Title);
            this.panelEx1.Controls.Add(this.txt_Personalcode);
            this.panelEx1.Controls.Add(this.txt_Phone);
            this.panelEx1.Controls.Add(this.label9);
            this.panelEx1.Controls.Add(this.label10);
            this.panelEx1.Controls.Add(this.txt_Email);
            this.panelEx1.Controls.Add(this.txt_password);
            this.panelEx1.Controls.Add(this.txt_Username);
            this.panelEx1.Controls.Add(this.txt_Family);
            this.panelEx1.Controls.Add(this.txt_Name);
            this.panelEx1.Controls.Add(this.label5);
            this.panelEx1.Controls.Add(this.label4);
            this.panelEx1.Controls.Add(this.label3);
            this.panelEx1.Controls.Add(this.label2);
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(-7, -3);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(770, 333);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 42;
            // 
            // Lbl_date
            // 
            this.Lbl_date.AutoSize = true;
            this.Lbl_date.Location = new System.Drawing.Point(96, 19);
            this.Lbl_date.Name = "Lbl_date";
            this.Lbl_date.Size = new System.Drawing.Size(41, 13);
            this.Lbl_date.TabIndex = 68;
            this.Lbl_date.Text = "label11";
            // 
            // btn_Save
            // 
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Save.Location = new System.Drawing.Point(94, 286);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 67;
            this.btn_Save.Text = "ثبت";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.ForeColor = System.Drawing.Color.Red;
            this.btn_Exit.Location = new System.Drawing.Point(13, 286);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 66;
            this.btn_Exit.Text = "انصراف";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pic_Sig
            // 
            this.pic_Sig.Image = global::MyProjectt.Properties.Resources.signature;
            this.pic_Sig.Location = new System.Drawing.Point(34, 148);
            this.pic_Sig.Name = "pic_Sig";
            this.pic_Sig.Size = new System.Drawing.Size(100, 99);
            this.pic_Sig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Sig.TabIndex = 65;
            this.pic_Sig.TabStop = false;
            this.pic_Sig.Click += new System.EventHandler(this.pic_Sig_Click);
            // 
            // pic_User
            // 
            this.pic_User.Image = global::MyProjectt.Properties.Resources.defaultuserpic;
            this.pic_User.Location = new System.Drawing.Point(34, 45);
            this.pic_User.Name = "pic_User";
            this.pic_User.Size = new System.Drawing.Size(100, 93);
            this.pic_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_User.TabIndex = 64;
            this.pic_User.TabStop = false;
            this.pic_User.Click += new System.EventHandler(this.pic_User_Click);
            // 
            // rad_Man
            // 
            this.rad_Man.AutoSize = true;
            this.rad_Man.Location = new System.Drawing.Point(277, 204);
            this.rad_Man.Name = "rad_Man";
            this.rad_Man.Size = new System.Drawing.Size(40, 17);
            this.rad_Man.TabIndex = 63;
            this.rad_Man.TabStop = true;
            this.rad_Man.Text = "مرد";
            this.rad_Man.UseVisualStyleBackColor = true;
            // 
            // rad_Woman
            // 
            this.rad_Woman.AutoSize = true;
            this.rad_Woman.Location = new System.Drawing.Point(356, 204);
            this.rad_Woman.Name = "rad_Woman";
            this.rad_Woman.Size = new System.Drawing.Size(37, 17);
            this.rad_Woman.TabIndex = 62;
            this.rad_Woman.TabStop = true;
            this.rad_Woman.Text = "زن";
            this.rad_Woman.UseVisualStyleBackColor = true;
            // 
            // com_Usertype
            // 
            this.com_Usertype.FormattingEnabled = true;
            this.com_Usertype.Location = new System.Drawing.Point(277, 246);
            this.com_Usertype.Name = "com_Usertype";
            this.com_Usertype.Size = new System.Drawing.Size(142, 21);
            this.com_Usertype.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Badr", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(434, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 27);
            this.label7.TabIndex = 60;
            this.label7.Text = "نوع کاربری";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Badr", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(434, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 27);
            this.label8.TabIndex = 59;
            this.label8.Text = "جنسیت";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Badr", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(437, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 27);
            this.label6.TabIndex = 58;
            this.label6.Text = "تاریخ تولد";
            // 
            // txt_date
            // 
            this.txt_date.BackColor = System.Drawing.Color.White;
            this.txt_date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_date.Location = new System.Drawing.Point(277, 139);
            this.txt_date.Name = "txt_date";
            this.txt_date.ShowTime = false;
            this.txt_date.Size = new System.Drawing.Size(145, 18);
            this.txt_date.TabIndex = 57;
            this.txt_date.Text = "persianDateTimePicker1";
            this.txt_date.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_date.Value")));
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Location = new System.Drawing.Point(456, 23);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(49, 13);
            this.Lbl_Title.TabIndex = 56;
            this.Lbl_Title.Text = "..............";
            // 
            // txt_Personalcode
            // 
            this.txt_Personalcode.Location = new System.Drawing.Point(277, 100);
            this.txt_Personalcode.Name = "txt_Personalcode";
            this.txt_Personalcode.Size = new System.Drawing.Size(145, 20);
            this.txt_Personalcode.TabIndex = 55;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(277, 52);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(145, 20);
            this.txt_Phone.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Badr", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(437, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 27);
            this.label9.TabIndex = 53;
            this.label9.Text = "شماره پرسنلی";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Badr", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(437, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 27);
            this.label10.TabIndex = 52;
            this.label10.Text = "شماره تماس";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(528, 247);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(145, 20);
            this.txt_Email.TabIndex = 51;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(528, 204);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(145, 20);
            this.txt_password.TabIndex = 50;
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(528, 149);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(145, 20);
            this.txt_Username.TabIndex = 49;
            // 
            // txt_Family
            // 
            this.txt_Family.Location = new System.Drawing.Point(528, 100);
            this.txt_Family.Name = "txt_Family";
            this.txt_Family.Size = new System.Drawing.Size(145, 20);
            this.txt_Family.TabIndex = 48;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(528, 52);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(145, 20);
            this.txt_Name.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Badr", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(688, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 27);
            this.label5.TabIndex = 46;
            this.label5.Text = "ایمیل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Badr", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(688, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 27);
            this.label4.TabIndex = 45;
            this.label4.Text = "رمز عبور";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Badr", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(688, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 27);
            this.label3.TabIndex = 44;
            this.label3.Text = "نام کاربری";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Badr", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(688, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 27);
            this.label2.TabIndex = 43;
            this.label2.Text = "نام خانوادگی";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Badr", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(688, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 27);
            this.label1.TabIndex = 42;
            this.label1.Text = "نام";
            // 
            // Frm_AddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 329);
            this.Controls.Add(this.panelEx1);
            this.Name = "Frm_AddEditUser";
            this.Text = "فرم افزودن کاربران سیستم";
            this.Load += new System.EventHandler(this.Frm_AddEditUser_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDia;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator4;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator5;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator6;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator7;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Label Lbl_date;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.PictureBox pic_Sig;
        private System.Windows.Forms.PictureBox pic_User;
        private System.Windows.Forms.RadioButton rad_Man;
        private System.Windows.Forms.RadioButton rad_Woman;
        private System.Windows.Forms.ComboBox com_Usertype;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private FreeControls.PersianDateTimePicker txt_date;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.TextBox txt_Personalcode;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Family;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}