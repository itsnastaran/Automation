using MyProjectt.DataLayer;
using MyProjectt.DataLayer.Context;
using MyProjectt.Utility.Convert;
using MyProjectt.ViewModel.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace MyProjectt.Login
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void labelX9_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                if (MessageBox.Show("آیا از  خروج برنامه مطمئن هستید ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    System.Environment.Exit(1);
                }
            }
        }
        private void showdate()
        {
            lbl_date.Text = DateTime.Now.Toshamsi();
        }
        private void ShowTime()
        {
            lbl_hours.Text = DateTime.Now.ToTimeShmsi();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            showdate();
            showIP();
            ShowTime();
            BindInformatinUserType();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowTime();
        }
        private void showIP()
        {
            lbl_ip.Text = System.Environment.MachineName.CNameToIP();
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWord db = new UnitOfWord())
                {
                    if ((int)com_usertype.SelectedValue == 0)
                    {
                        MessageBox.Show("نوع کاربر را باید انتخاب کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var username = txtusername.Text.Trim();
                        var Password = txtpassword.Text.Trim().PasswordToSHA256();
                        int UsercodeType = (int)com_usertype.SelectedValue;
                        var result = db.UserRepository.GetUserLogin(username, Password, UsercodeType);
                        if (result != null)
                        {
                            ListUserVariable.UserID = result.UserID;
                            ListUserVariable.Username = result.UserName;
                            ListUserVariable.Userfirstname = result.UserFirstName;
                            ListUserVariable.UserFamily = result.UserFamily;
                            ListUserVariable.UserTypeCode = (int)result.UserType.CodeType;
                            
                            UserLog Ulog = new UserLog()
                            {
                                ComputerName = System.Environment.MachineName,
                                IPAddress = lbl_ip.Text,
                                EnterDateTime = DateTime.Now,
                                UserID = result.UserID
                            };

                            db.UserLogGRepository.Insert(Ulog);
                            db.Save();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("نام کاربری یا رمز عبور یا نوع کاربری اشتباه است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void BindInformatinUserType()
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                List<ListViewUserType> list = new List<ListViewUserType>();
                list.Add(new ListViewUserType()
                {
                    UserTypeCode = 0,
                    UsertypeID = 0,
                    UserTypeName = "یک مورد را انتخاب کنید"
                });
                list.AddRange(db.Usertype.Get());
                com_usertype.DataSource = list;
                com_usertype.DisplayMember = "UserTypeName";
                com_usertype.ValueMember = "UserTypeCode";
            }
        }
    }
}
