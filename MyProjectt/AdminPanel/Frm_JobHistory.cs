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
using MyProjectt.Utility.Convert;

namespace MyProjectt.AdminPanel
{
    public partial class Frm_JobHistory : Form
    {
        public int UserID = 0;
        public Frm_JobHistory()
        {
            InitializeComponent();
        }

        private void Frm_JobHistory_Load(object sender, EventArgs e)
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                if (UserID != 0)
                {
                    var result = db.UserRepository.GetUserByID(UserID);
                    lbl_fullname.Text = result.UserFirstName + " " + result.UserFamily;

                    bindInformation();
                    
                }
            }
        }
        private void bindInformation()
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                IEnumerable<UserSetJob> list = db.USetJobRepository.GetUserJobByID(UserID);
                if (list.Count() != 0)
                {
                    DG_JobHistory.Rows.Clear();
                    foreach (var item in list)
                    {
                        DG_JobHistory.Rows.Add(item.SID, item.User.UserFirstName+" "+item.User.UserFamily, item.Job.JobName, item.SetDateJob, item.EndDateJob != null ? item.EndDateJob.Value.Toshamsi() : "", item.Status==1? "فعال":"غیرفعال");
                    }
                }
                else
                {
                    DG_JobHistory.Rows.Clear();
                    DG_JobHistory.Rows.Add("هیچ شغلی اختصاص نیافته است");
                }
            }
        }
        private bool ChekeSetJob(int UID)
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                bool ischeck = db.USetJobRepository.GetCheackSetjobUserByID(UID);
                if (ischeck)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_setjob_Click(object sender, EventArgs e)
        {
            if (ChekeSetJob(UserID))
            {
                MessageBox.Show("این کاربر از قبل شغل دارد در سیستم ، برای انتساب شغل باید شغل جاری عزل شود", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Frm_SetUserJob frm = new Frm_SetUserJob();
                frm.lbl_fullname.Text = lbl_fullname.Text;
                frm.UserID = UserID;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    bindInformation();
                }
            }
        }

        private void btn_deletejob_Click(object sender, EventArgs e)
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                if (MessageBox.Show($"آیا از گرفتن شغل {lbl_fullname.Text} مطمن هستید", "هشدار گرفتن شغل", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ChekeSetJob(UserID))
                    {
                        bool issuccess = db.USetJobRepository.DeleteUserJob(UserID, DateTime.Now);
                        if (issuccess)
                        {
                            MessageBox.Show("عملیات با موفقیت انجام شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("عملیات با شکست مواجه شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("این کاربر از قبل در سازمان شغلی ندارد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    db.Save();
                    bindInformation();
                }
            }
        }

        private void panelEx2_Click(object sender, EventArgs e)
        {

        }
    }
}
