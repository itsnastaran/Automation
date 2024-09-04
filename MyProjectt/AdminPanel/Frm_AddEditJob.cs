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
using ValidationComponents;

namespace MyProjectt.AdminPanel
{
    public partial class Frm_AddEditJob : Form
    {
        public int JobIDEdit = 0;
        public int JobID = 0;
        public Frm_AddEditJob()
        {
            InitializeComponent();
        }

        private void Frm_AddEditJob_Load(object sender, EventArgs e)
        {
            if(JobIDEdit!=0)
            {
                this.Text = "فرم ویرایش شغل سازمان";
                using (UnitOfWord db = new UnitOfWord())
                {
                    var result = db.JobGRepository.GetByID(JobIDEdit);
                    if(result!=null)
                    {
                        txt_jobname.Text = result.JobName;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else
            {
                this.Text = "فرم افزودن شغل جدید";
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
                if (BaseValidator.IsFormValid(this.components))
                {
                    if (JobIDEdit == 0)
                    {
                        //insert to tabel job
                        var result = db.JobRepository.GetDeterminanJobByID(JobID);
                        
                        Job ojob = new Job()
                        {
                            JobName = txt_jobname.Text,
                            Job_LevelId = 1
                        };
                        bool issucess = db.JobGRepository.Insert(ojob);
                        
                        if (issucess)
                        {
                            MessageBox.Show("عملیات با موفقیت ثبت شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("عملیات نا موفقیت بود", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //update job id;
                        bool issuccess = db.JobRepository.UpdatejobByID(JobIDEdit, txt_jobname.Text);
                        if (issuccess)
                        {
                            MessageBox.Show("عملیات با موفقیت ثبت شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("عملیات نا موفقیت بود", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                db.Save();
            }
        }
    }
}
