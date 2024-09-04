using MyProjectt.DataLayer.Context;
using MyProjectt.Utility.Convert;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectt.AdminPanel
{
    public partial class Frm_ShowInformationUser : Form
    {
        public int UserID = 0;
        public Frm_ShowInformationUser()
        {
            InitializeComponent();
        }

        private void Frm_ShowInformationUser_Load(object sender, EventArgs e)
        {
            BindInformation();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BindInformation()
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                if (UserID != 0)
                {
                    var result = db.UserRepository.GetUserByID(UserID);
                    if (result != null)
                    {
                        lblname.Text = result.UserFirstName;
                        lblfamily.Text = result.UserFamily;
                        lblemail.Text = result.UserEmail;
                        lblpersonal.Text = result.PersonalCode;
                        lblphone.Text = result.UserTell;
                        lblbirthday.Text = result.BirthDate.Value.Toshamsi();
                        if (result.Gender == 1)
                        {
                            lblgender.Text = "مرد";
                        }
                        else if (result.Gender == 2)
                        {
                            lblgender.Text = "زن";
                        }
                        if (result.Activity == 1)
                        {
                            lblstatus.Text = "فعال";
                        }
                        else if (result.Activity == 2)
                        {
                            lblgender.Text = "غیرفعال";
                        }
                        
                        lblusername.Text = result.UserName;
                        Pic_UserImage.ImageLocation = Application.StartupPath + "/Image/" + result.UserImage;
                        Pic_Usersig.ImageLocation = Application.StartupPath + "/Image/" + result.UserSignatures;
                        var result2 = db.USetJobRepository.GetUserjobbyUserID(UserID);
                        if(result2!=null)
                        {
                            lbljob.Text = result2.Job.JobName;
                        }
                    }
                    else
                    {
                        var ResUserInfo = db.UserRepository.GetUserByID(UserID);
                        lblname.Text = ResUserInfo.UserFirstName;
                        lblfamily.Text = ResUserInfo.UserFamily;
                        lblemail.Text = ResUserInfo.UserEmail;
                        lblpersonal.Text = ResUserInfo.PersonalCode;
                        lblphone.Text = ResUserInfo.UserTell;
                        lbljob.Text = "شغل ندارد";
                        lblbirthday.Text = ResUserInfo.BirthDate.Value.Toshamsi();
                        lblgender.Text = ResUserInfo.Gender.ToString();
                        lblstatus.Text = ResUserInfo.Activity.ToString();
                        lblusername.Text = ResUserInfo.UserName;
                        Pic_UserImage.ImageLocation = Application.StartupPath + "/Image/" + ResUserInfo.UserImage;
                        Pic_Usersig.ImageLocation = Application.StartupPath + "/Image/" + ResUserInfo.UserSignatures;
                    }
                }
                else
                {
                    MessageBox.Show("در ارتباط با سیستم مشکلی بوجود آمده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
