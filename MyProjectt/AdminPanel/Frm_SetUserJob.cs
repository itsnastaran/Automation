using MyProjectt.DataLayer;
using MyProjectt.DataLayer.Context;
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

namespace MyProjectt.AdminPanel
{
    public partial class Frm_SetUserJob : Form
    {
        public int UserID = 0;
        public Frm_SetUserJob()
        {
            InitializeComponent();
        }

        private void Frm_SetUserJob_Load(object sender, EventArgs e)
        {
            //lbl_fullname.Text = ListUserVariable.Fullname;

            treeView_job.Nodes.Clear();
            TreeNode N = new TreeNode("مدیر عامل");
            N.ForeColor = Color.Red;
            N.Tag = 1;
            treeView_job.Nodes.Add(N);
            BindJobs(N);
            N.Expand();
        }
        private void BindJobs(TreeNode Tn)
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                int Tag = (int)Tn.Tag;
                var result = db.JobRepository.GetVw(Tag);
                if (result.Count() > 0)
                {
                    foreach (var item in result)
                    {
                        TreeNode M = new TreeNode();
                        M.Tag = item.JobID;
                        M.Text = item.JobID + " - " + item.JobName;
                        Tn.Nodes.Add(M);
                      
                    }
                }
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                var result = treeView_job.SelectedNode;
                if (result != null)
                {
                    //اول برسی اینکه این شغل از قبل به کسی داده شده نباشد
                    //بعد این شغل را اختصاص میدهیم
                    //...
                    bool isCheck = db.USetJobRepository.GetCheackHaveJobByJobID((int)result.Tag);
                    if (isCheck)
                    {
                        string Fullname = db.USetJobRepository.GetFullNameByJobID((int)result.Tag);
                        MessageBox.Show($"این شغل در تحویل {Fullname} است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        UserSetJob oset = new UserSetJob()
                        {
                            UserID = UserID,
                            JobID = (int)result.Tag,
                            Status = 1,
                            SetDateJob = DateTime.Now
                        };

                        bool issuccess = db.USetJobGRepository.Insert(oset);
                        if (issuccess)
                        {
                            MessageBox.Show("عملیات با موفقیت انجام شد", "عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("عملیات یا شکست انجام شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("برای انتساب شغل باید یک شغلی را انتخاب کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.Save();
            }

        }
    }
}
