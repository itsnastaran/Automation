using MyProjectt.Bissuns;
using MyProjectt.DataLayer;
using MyProjectt.DataLayer.Context;
using MyProjectt.Utility.Convert;
using MyProjectt.ViewModel.Admin;
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
    public partial class Frm_MainAdmin : Form
    {
        public Frm_MainAdmin()
        {
            InitializeComponent();
        }

        private void datefrom_ValueChanged(object sender, FreeControls.PersianMonthCalendarEventArgs e)
        {

        }

        private void labelItem1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonBar3_ItemClick(object sender, EventArgs e)
        {
            Frm_showUsers frm = new Frm_showUsers();
            frm.ShowDialog();
        }
        private void BindInfoRemember()
        {
            DateTime ST = datefrom.Value;
            DateTime ET = dateto.Value;
            using (UnitOfWord db = new UnitOfWord())
            {
                IEnumerable<Remember> Result = db.RememberRepository.GetRemember(ST, ET);
                Dg_showRemmber.Rows.Clear();
                if (Result.Count() != 0)
                {
                    foreach (var item in Result)
                    {
                        Dg_showRemmber.Rows.Add(item.RememberID, item.Subject, item.Text, item.CreateDate.Toshamsi(), item.RememberDate.Toshamsi(), item.IsRead==1?"خوانده شده":"خوانده نشده");
                    }
                }
                else
                {
                    Dg_showRemmber.Rows.Clear();
                }
                Dg_showRemmber.ScrollBars = ScrollBars.Both;
            }
        }

        private void Frm_MainAdmin_Load(object sender, EventArgs e)
        {
            dateto.Value = DateTime.Now.AddDays(3);
            labelX3.Text = ListUserVariable.Fullname;
            BindInfoRemember();
            InformationUser();
        }

        private void picsearch_Click(object sender, EventArgs e)
        {
            DateTime ST = datefrom.Value;
            DateTime ET = dateto.Value;
            using (UnitOfWord db = new UnitOfWord())
            {
                IEnumerable<Remember> Result = db.RememberRepository.GetRemember(ST, ET);
                Dg_showRemmber.Rows.Clear();
                if (Result.Count() != 0)
                {
                    foreach (var item in Result)
                    {
                        Dg_showRemmber.Rows.Add(item.RememberID, item.Subject, item.Text, item.CreateDate.Toshamsi(), item.RememberDate.Toshamsi(), item.IsRead == 1 ? "خوانده شده" : "خوانده نشده");
                    }
                }
                else
                {
                    Dg_showRemmber.Rows.Clear();
                }
                Dg_showRemmber.ScrollBars = ScrollBars.Both;
            }
        }

        private void txtsubject_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                DateTime ST = datefrom.Value;
                DateTime ET = dateto.Value;
                IEnumerable<Remember> Result = db.RememberRepository.GetRemember(txtsubject.Text, ST, ET);
                Dg_showRemmber.Rows.Clear();
                if (Result.Count() != 0)
                {
                    foreach (var item in Result)
                    {
                        Dg_showRemmber.Rows.Add(item.RememberID, item.Subject, item.Text, item.CreateDate.Toshamsi(), item.RememberDate.Toshamsi(), item.IsRead);
                    }
                }
                else
                {
                    Dg_showRemmber.Rows.Clear();
                }
                Dg_showRemmber.ScrollBars = ScrollBars.Both;
            }
        }

        private void Dg_showRemmber_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dg_showRemmber_DoubleClick(object sender, EventArgs e)
        {
            int RemeberID = (int)Dg_showRemmber.CurrentRow.Cells[0].Value;
            using (UnitOfWord db = new UnitOfWord())
            {
                string[] MessTextSubject = new string[3];
                MessTextSubject[0] = Dg_showRemmber.CurrentRow.Cells["Remembersubject"].Value.ToString();
                MessTextSubject[1] = Dg_showRemmber.CurrentRow.Cells["Rtext"].Value.ToString();
                if (MessageBox.Show(MessTextSubject[1], MessTextSubject[0], MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    db.RememberRepository.UpdateRememberByID(RemeberID);
                }
                db.Save();
                BindInfoRemember();
            }
        }

        private void btn_addremember_ItemClick(object sender, EventArgs e)
        {
            Frm_AddRemember frm = new Frm_AddRemember();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BindInfoRemember();
            }
        }

        private void Frm_MainAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                bool issuccess = db.UserLog.SetDateTimeExiteUser(DateTime.Now, ListUserVariable.UserID);
                if (issuccess)
                {
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    MessageBox.Show("مشکلی در ارتباط با سیستم بوجود آمده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.Save();
            }
        }

        private void labelItem6_Click(object sender, EventArgs e)
        {

        }

        private void btn_userloginexit_ItemClick(object sender, EventArgs e)
        {
            Frm_ExitLoginUser frmE = new Frm_ExitLoginUser();
            frmE.ShowDialog();
        }

        private void btn_showjob_ItemClick(object sender, EventArgs e)
        {
            Frm_ShowJobs frm = new Frm_ShowJobs();
            frm.ShowDialog();
        }

        private void btn_jobassignment_ItemClick(object sender, EventArgs e)
        {
            Frm_ShowUserForJob frm = new Frm_ShowUserForJob();
            frm.ShowDialog();
        }

        private void btn_sendmessageUser_ItemClick(object sender, EventArgs e)
        {
            Frm_CreateNews frm = new Frm_CreateNews();
            frm.ShowDialog();
        }

        private void btn_shownews_ItemClick(object sender, EventArgs e)
        {
            Frm_showNews frm = new Frm_showNews();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToTimeShmsi();
        }
        private void InformationUser()
        {
            lbl_date.Text = DateTime.Now.Toshamsi();
            ShowUserActive OUserInformation = Admin.GetUserInformation();
            lbl_counuser.Text = OUserInformation.CountAllUser.ToString("00");
            lbl_activeuser.Text = OUserInformation.CountAllUserActive.ToString("00");
            lbl_onlineusers.Text = OUserInformation.CountUserOnline.ToString("00");
            lbl_lastdatetimelogin.Text = OUserInformation.LastDatetimeLogin.Toshamsi() + " - " + OUserInformation.LastDatetimeLogin.ToTimeShmsi();
        }

        private void labelItem5_Click(object sender, EventArgs e)
        {

        }
    }
}
