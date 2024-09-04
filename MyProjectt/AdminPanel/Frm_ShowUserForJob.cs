using MyProjectt.DataLayer;
using MyProjectt.DataLayer.Context;
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
    public partial class Frm_ShowUserForJob : Form
    {
        public Frm_ShowUserForJob()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ShowUserForJob_Load(object sender, EventArgs e)
        {
            BindInfoUser();
        }
        private void BindInfoUser()
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                IEnumerable<DataLayer.User> list = db.UserRepository.GetUser().Where(x => x.Activity == 1);
                DG_ShowUser.Rows.Clear();
                if (list.Count() > 0)
                {
                    foreach (var item in list)
                    {
                        DG_ShowUser.Rows.Add(item.UserID, item.UserFirstName, item.UserFamily, item.Gender==1? "مرد":"زن", item.PersonalCode);
                    }
                }
                else
                {
                    DG_ShowUser.Rows.Clear();
                }
            }
        }

        private void picsearch_Click(object sender, EventArgs e)
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                IEnumerable<DataLayer.User> list = db.UserRepository.GetUser(GetSearch()).Where(x => x.Activity == 1);
                DG_ShowUser.Rows.Clear();
                if (list.Count() > 0)
                {
                    foreach (var item in list)
                    {
                        DG_ShowUser.Rows.Add(item.UserID, item.UserFirstName, item.UserFamily, item.Gender, item.PersonalCode);
                    }
                }
                else
                {
                    DG_ShowUser.Rows.Clear();
                }
            }
        }
        private string GetSearch()
        {
            string Str = "";
            if (txtname.Text != null)
            {
                Str += " and UserFirstName like '%" + txtname.Text.Trim() + "%'";
            }
            if (txtfamily.Text != null)
            {
                Str += " and UserFamily like '%" + txtfamily.Text.Trim() + "%'";
            }
            if (txtpersonal.Text != null)
            {
                Str += "and PersonalCode like '%" + txtpersonal.Text.Trim() + "%'";
            }
            return Str;
        }

        private void btn_jobhistory_Click(object sender, EventArgs e)
        {
            if (DG_ShowUser.CurrentRow.Selected)
            {
                int userID = (int)DG_ShowUser.CurrentRow.Cells[0].Value;
                Frm_JobHistory frm = new Frm_JobHistory();
                frm.UserID = userID;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("برای انتساب نمایش تاریخچه شغل باید ، شخصی را انتخاب کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
