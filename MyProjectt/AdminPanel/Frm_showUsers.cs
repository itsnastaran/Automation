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
    public partial class Frm_showUsers : Form
    {

        public Frm_showUsers()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_createUser_Click(object sender, EventArgs e)
        {
            Frm_AddEditUser frm = new Frm_AddEditUser();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BindInformationUser();
            }

        }
        private void BindInformationUser()
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                IEnumerable<DataLayer.User> list = db.UserRepository.GetUser();
                DG_showuser.Rows.Clear();
                
                if (list.Count() != 0)
                {
                   
                    foreach (var item in list)
                    {
                        
                     
                        DG_showuser.Rows.Add(item.UserID, item.UserFirstName, item.UserFamily, item.PersonalCode, item.UserTell, item.Gender==1? "مرد":"زن", item.Activity==1? "فعال":"غیرفعال", item.BirthDate.Value.Toshamsi(), item.UserEmail);
                    }
                }
                else
                {
                    DG_showuser.Rows.Clear();
                }
                DG_showuser.ScrollBars = ScrollBars.Both;
            }

        }

        private void Frm_showUsers_Load(object sender, EventArgs e)
        {
            BindInformationUser();
        }

        private void PicSearch_Click(object sender, EventArgs e)
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                IEnumerable<DataLayer.User> list = db.UserRepository.GetUser(Createsearchstring());
                DG_showuser.Rows.Clear();
                if (list.Count() != 0)
                {
                    foreach (var item in list)
                    {
                        DG_showuser.Rows.Add(item.UserID, item.UserFirstName, item.UserFamily, item.PersonalCode, item.UserTell, item.Gender == 1 ? "مرد" : "زن", item.Activity == 1 ? "فعال" : "غیرفعال", item.BirthDate.Value.Toshamsi(), item.UserEmail);
                    }
                }
                else
                {
                    DG_showuser.Rows.Clear();
                }
                DG_showuser.ScrollBars = ScrollBars.Both;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            BindInformationUser();
        }
        private string Createsearchstring()
        {
            string str = "";
            if (txtname.Text != null)
            {
                str += "and UserFirstName like N'%" + txtname.Text.Trim() + "%'";
            }
            if (txtfamily.Text != null)
            {
                str += "and UserFamily like N'%" + txtfamily.Text.Trim() + "%'";
            }

            if (Rad_Active.Checked)
            {
                str += "and Activity=1";
            }
            if (Rad_Onactive.Checked)
            {
                str += "and Activity=2";
            }
            if (Rad_Meil.Checked)
            {
                str += "and Gender=2";
            }
            if (Rad_Femail.Checked)
            {
                str += "and Gender=1";
            }
            return str;
        }

        private void btn_editUser_Click(object sender, EventArgs e)
        {
            if (DG_showuser.CurrentRow != null)
            {
                int UserId = (int)DG_showuser.CurrentRow.Cells[0].Value;
                Frm_AddEditUser frm = new Frm_AddEditUser();
                frm.UserID_Edite = UserId;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindInformationUser();
                }
            }
            else
            {
                MessageBox.Show("برای ویرایش باید ردیفی را انتخاب کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_OnactiveUser_Click(object sender, EventArgs e)
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                if (DG_showuser.CurrentRow.Selected)
                {
                    string Name = DG_showuser.CurrentRow.Cells["UName"].Value.ToString();
                    string Family = DG_showuser.CurrentRow.Cells["UFamily"].Value.ToString();
                    int UserID = (int)DG_showuser.CurrentRow.Cells[0].Value;
                    if (MessageBox.Show($"آیا از غیر فعال کردن مطمن {Name + " " + Family} هستید ", "غیر فعال کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool isActive = db.UserRepository.onActivityByID(UserID);
                        if (isActive)
                        {
                            db.Save();
                        }
                        else
                        {
                            MessageBox.Show("در انجام عملیات مشکلی بوجود آمده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        return;
                    }
                    BindInformationUser();
                }
                else
                {
                    MessageBox.Show("برای غیر فعال کردن حتما باید کاربری را انتخاب کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_active_Click(object sender, EventArgs e)
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                if (DG_showuser.CurrentRow.Selected)
                {
                    string Name = DG_showuser.CurrentRow.Cells["UName"].Value.ToString();
                    string Family = DG_showuser.CurrentRow.Cells["UFamily"].Value.ToString();
                    int UserID = (int)DG_showuser.CurrentRow.Cells[0].Value;
                    if (MessageBox.Show($"آیا از فعال کردن مطمن {Name + " " + Family} هستید ", " فعال کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool isActive = db.UserRepository.IsctivityByID(UserID);
                        if (isActive)
                        {
                            db.Save();
                        }
                        else
                        {
                            MessageBox.Show("در انجام عملیات مشکلی بوجود آمده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        return;
                    }
                    BindInformationUser();
                }
                else
                {
                    MessageBox.Show("برای فعال کردن حتما باید کاربری را انتخاب کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DG_showuser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DG_showuser.CurrentRow != null)
            {
                int UserId = (int)DG_showuser.CurrentRow.Cells[0].Value;
                Frm_ShowInformationUser frm = new Frm_ShowInformationUser();
                frm.UserID = UserId;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("برای نمایش اطلاعات کابر باید حتما انتخاب کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
