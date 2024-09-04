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
    public partial class Frm_ShowJobs : Form
    {
        public Frm_ShowJobs()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ShowJobs_Load(object sender, EventArgs e)
        {
            TreeView_Jobs.Nodes.Clear();
            TreeNode n = new TreeNode("مدیر عامل");
            n.ForeColor = Color.Red;
            n.Tag = 1;
            TreeView_Jobs.Nodes.Add(n);
            bindJobs(n);
            n.Expand();
        }
        private void bindJobs(TreeNode Tn)
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
                        
                        if (item.countchild != null)
                        {
                             int ch = (int)item.countchild;
                        
                        if (ch > 0)
                            {
                                bindJobs(M);
                            }
                            M = null;
                        }
                    }
                }
            }
        }

        private void btn_createjob_Click(object sender, EventArgs e)
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                var Node = TreeView_Jobs.SelectedNode;
                if (Node != null)
                {
                    Frm_AddEditJob frm = new Frm_AddEditJob();
                    frm.JobID = (int)TreeView_Jobs.SelectedNode.Tag;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        Frm_ShowJobs_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("برای اضافه کردن شغل باید یکی از مشاغل را انتخاب کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                db.Save();
            }
        }

        private void btn_editjob_Click(object sender, EventArgs e)
        {
            var Node = TreeView_Jobs.SelectedNode;
            if (Node != null)
            {
                Frm_AddEditJob frm = new Frm_AddEditJob();
                frm.JobIDEdit = (int)TreeView_Jobs.SelectedNode.Tag;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Frm_ShowJobs_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("برای ویرایش کردن شغل باید یکی از مشاغل را انتخاب کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }
    }
}
