using MyProjectt.DataLayer;
using MyProjectt.DataLayer.Context;
using MyProjectt.Utility.Convert;
using MyProjectt.ViewModel.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;
using MyProjectt.DataLayer.Repository;

namespace MyProjectt.AdminPanel
{
    public partial class Frm_AddEditUser : Form
    {
        public int UserID_Edite { get; set; } = 0;
        public Frm_AddEditUser()
        {
            InitializeComponent();
        }

        private void persianDateTimePicker1_ValueChanged(object sender, FreeControls.PersianMonthCalendarEventArgs e)
        {

        }

        private void Frm_AddEditUser_Load(object sender, EventArgs e)
        {
            Lbl_date.Text = DateTime.Now.Toshamsi();
            BindInformationUserType();

            if (UserID_Edite == 0)
            {
                //Insert
                Lbl_Title.Text = "فرم ثبت پرسنل";
            }
            else
            {
                //Update
                using (UnitOfWord db = new UnitOfWord())
                {
                    var result = db.UserGRepository.GetByID(UserID_Edite);
                    Lbl_Title.Text = $"فرم ویرایش پرسنل {result.UserFirstName + " " + result.UserFamily}";
                    txt_Name.Text = result.UserFirstName;
                    txt_Family.Text = result.UserFamily;
                    txt_Phone.Text = result.UserTell;
                    txt_Personalcode.Text = result.PersonalCode;
                    txt_Username.Text = result.UserName;
                    pic_User.ImageLocation = Application.StartupPath + "/Image/" + result.UserImage;
                    pic_Sig.ImageLocation = Application.StartupPath + "/Image/" + result.UserSignatures;
                    txt_date.Value = result.BirthDate.Value;
                    txt_Email.Text = result.UserEmail;
                    txt_password.Text = result.Password;
                    if (result.Gender == 1)
                    {
                        rad_Man.Checked = true;
                    }
                    else
                    {
                        rad_Woman.Checked = true;
                    }

                    txt_Username.ReadOnly = true;
                    txt_password.ReadOnly = true;
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                string UserImageName = SaveUserPic();
                string UsersigName = SaveUserSig();
                if (UserImageName == "Null")
                {
                    MessageBox.Show("تصویر کاربر نمی تواند خالی باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (UsersigName == "Null")
                {
                    MessageBox.Show("امضاء کاربر نمی تواند خالی باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ((int)com_Usertype.SelectedValue == 0)
                {
                    MessageBox.Show("نوع کاربر باید انتخاب شود", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (BaseValidator.IsFormValid(this.components))
                    {

                        DateTime BirsDay;
                        BirsDay = txt_date.Value;
                        byte Activity = 0;
                        if (rad_Man.Checked)
                        {
                            Activity = 1;
                        }
                        else
                        {
                            Activity = 2;
                        }

                        MyProjectt.DataLayer.User ouser = new MyProjectt.DataLayer.User()
                        {
                            
                            UserFirstName = txt_Name.Text.Trim(),
                            UserFamily = txt_Family.Text.Trim(),
                            CreateDate = DateTime.Now,
                            Password = txt_password.Text.PasswordToSHA256(),
                            PersonalCode = txt_Personalcode.Text.Trim(),
                            UserEmail = txt_Email.Text.Trim(),
                            Activity = 1,
                            Gender = Activity,
                            BirthDate = BirsDay,
                            UserName = txt_Username.Text.Trim(),
                            UserTell = txt_Phone.Text.Trim(),
                            UserImage = UserImageName,
                            UserSignatures = UsersigName,
                            UserTypeID = (int)com_Usertype.SelectedValue

                        };

                        if (UserID_Edite == 0)
                        {

                            var result = db.UserRepository.GetUserNameByRepetitious(txt_Username.Text);
                            if (result)
                            {
                                MessageBox.Show("این نام کاربری از قبل در سیستم موجود است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            //Insert;

                            bool issucess = db.UserGRepository.Insert(ouser);

                            if (issucess)
                            {
                                MessageBox.Show("عملیات با موفقیت انجام شد", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                MessageBox.Show("عملیات با شکست مواجه شد", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            ouser.UserID = UserID_Edite;
                            ouser.Password = db.UserRepository.GetUserByID(UserID_Edite).Password;
                            bool issucess = db.UserGRepository.Update(ouser);
                            if (issucess)
                            {
                                MessageBox.Show("عملیات با موفقیت انجام شد", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                MessageBox.Show("عملیات با شکست مواجه شد", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        db.Save();

                    }
                }
            }
        }

        private void pic_User_Click(object sender, EventArgs e)
        {
            openFileDia.Filter = "Image File (*.png;*.jpg;*.bmp) | *.png;*.jpg;*.bmp";
            openFileDia.FileName = "";
            if (openFileDia.ShowDialog() == DialogResult.OK)
            {
                pic_User.ImageLocation = openFileDia.FileName;
            }
        }

        private void pic_Sig_Click(object sender, EventArgs e)
        {
            openFileDia.Filter = "Image File (*.png;*.jpg;*.bmp) | *.png;*.jpg;*.bmp";
            openFileDia.FileName = "";
            if (openFileDia.ShowDialog() == DialogResult.OK)
            {
                pic_Sig.ImageLocation = openFileDia.FileName;
            }
        }
        private string SaveUserPic()
        {
            if (pic_User.ImageLocation != null)
            {
                string User_Image = Guid.NewGuid() + Path.GetExtension(pic_User.ImageLocation);
                string PathImage = Application.StartupPath + "/Image/";
                if (!Directory.Exists(PathImage))
                {
                    Directory.CreateDirectory(PathImage);
                }
                string User_Image2 = Guid.NewGuid() + Path.GetExtension(pic_User.ImageLocation);
                try
                {
                    pic_User.Image.Save(PathImage + User_Image);
                }
                catch
                {
                    using (Bitmap bmp=(Bitmap)pic_User.Image.Clone())
                    {
                        bmp.Save(PathImage +"f"+ User_Image,bmp.RawFormat);
                    }
                }
                return User_Image;
            }
            else
            {
                return "Null";
            }
        }
        private string SaveUserPic2()
        {
            if (pic_User.ImageLocation != null)
            {
                string User_Image = Guid.NewGuid() + Path.GetExtension(pic_User.ImageLocation);
                string PathImage = Application.StartupPath + "/Image/";
                string PathImage2 = Application.StartupPath + "/Image/";
                if (!Directory.Exists(PathImage))
                {
                    Directory.CreateDirectory(PathImage);
                }
                
                pic_User.Image.Save(PathImage2 + User_Image);
                return User_Image;
            }
            else
            {
                return "Null";
            }
        }
        private String SaveUserSig()
        {
            if (pic_Sig.ImageLocation != null)
            {
                string UserSig = Guid.NewGuid() + Path.GetExtension(pic_Sig.ImageLocation);
                string PathImage = Application.StartupPath + "/Image/";
                if (!Directory.Exists(PathImage))
                {
                    Directory.CreateDirectory(PathImage);
                }
                try
                {
                    pic_Sig.Image.Save(PathImage + UserSig);
                }
                catch
                {
                    using (Bitmap bmp = (Bitmap)pic_Sig.Image.Clone())
                    {
                        bmp.Save(PathImage + "f" + UserSig,bmp.RawFormat);
                    }
                }
                return UserSig;
            }
            else
            {
                return "Null";
            }

        }

        private void BindInformationUserType()
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                List<ListViewUserType> list = new List<ListViewUserType>();
                list.Add(new ListViewUserType()
                {
                    UserTypeCode = 0,
                    UsertypeID = 0,
                    UserTypeName = "یکی را باید انتخاب کنید"
                });
                list.AddRange(db.Usertype.Get());
                com_Usertype.DataSource = list;
                com_Usertype.DisplayMember = "UserTypeName";
                com_Usertype.ValueMember = "UsertypeID";
            }
        }
    }
}
