using MyProjectt.Bissuns;
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
namespace MyProjectt.User
{
    public partial class Frm_MainUser : Form
    {
        public Frm_MainUser()
        {
            InitializeComponent();
        }
        private void Lbl_Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DateTime Start = DateTime.Now;
            DateTime End = DateTime.Now;
            using (UnitOfWord db = new UnitOfWord())
            {
                bool issucess = db.UserLog.SetDateTimeExiteUser(DateTime.Now, ListUserVariable.UserID);
                if (!issucess)
                {
                    MessageBox.Show("در راتباط با سرور مشکلی بوجود آمده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.Save();
                System.Environment.Exit(1);
            }
        }
        private void Frm_MainUser_Load(object sender, EventArgs e)
        {
            BindInformationUser(ListUserVariable.UserID);
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_ShowRemmber Frmrem = new Frm_ShowRemmber();
            Frmrem.MdiParent = this;
            Frmrem.Show();
        }
        private void BindInformationUser(int UserID)
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                var result = db.UserRepository.GetUserByID(UserID);
                if (result != null)
                {
                    lblname.Text = result.UserFirstName;
                    lblfamily.Text = result.UserFamily;
                    if (result.Gender == 1)
                    {
                        lblgender.Text = "مرد";
                    }
                    else if (result.Gender == 2)
                    {
                        lblgender.Text = "زن";
                    }
                    var result2 = db.USetJobRepository.GetUserjobbyUserID(UserID);
                    if (result2 != null)
                    {
                        lbljobname.Text = result2.Job.JobName;
                    }
                    lblbirthday.Text = result.BirthDate.Value.Toshamsi();
                    lblpersonalcode.Text = result.PersonalCode;
                    lbldate.Text = DateTime.Now.Toshamsi();
                    Pic_User.ImageLocation = Application.StartupPath+ "/Image/" + result.UserImage;
                    lbltime.Text = DateTime.Now.ToTimeShmsi();
                    L_A_LetterReciveFromMonth_ToMonth.Text = ULetter.GetCountUserRepository().CountLetter.ToString("00");
                    Lbl_AllLetersCreate.Text = ULetter.GetAllLetteruser().CountLetter.ToString("00");
                    Lbl_AllLetterSend.Text = ULetter.GetAllSendLaterUser().SendcountLatter.ToString("00");
                    Lbl_ReciveAllLetter.Text = ULetter.GetAllSendLaterUser().CountReciveLetter.ToString("00");
                }
                else
                {
                    return;
                }
            }
        }
        private void btn_saveremember_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_AddEditRemember frm = new Frm_AddEditRemember();
            frm.MdiParent = this;
            frm.Show();
        }
        private void btn_showremember_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_ShowRemmber frm = new Frm_ShowRemmber();
            frm.MdiParent = this;
            frm.Show();
        }
        private void Lbl_minimixe_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Btn_Drafts_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_ShowDraft frm = new Frm_ShowDraft();
            frm.MdiParent = this;
            frm.Show();
        }
        private void Btn_CreateLater_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_CreateLetter frm = new Frm_CreateLetter();
            frm.MdiParent = this;
            frm.Show();
        }
        private void Btn_AllReciveLater_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_RecivAllLatters frm = new Frm_RecivAllLatters();
            frm.MdiParent = this;
            frm.Show();
        }
        private void Btn_sendLater_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_SendLatters frm = new Frm_SendLatters();
            frm.MdiParent = this;
            frm.Show();
        }
        private void Btn_CreateNote_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_CreateSendNots frm = new Frm_CreateSendNots();
            frm.MdiParent = this;
            frm.Show();
        }
        private void Btn_sendnote_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_SendNots frm = new Frm_SendNots();
            frm.MdiParent = this;
            frm.Show();
        }
        private void Btn_NoteRecive_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_AllNotRecive frm = new Frm_AllNotRecive();
            frm.MdiParent = this;
            frm.Show();
        }
        private void Btn_AllreadLater_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_AllLettersRead frm = new Frm_AllLettersRead();
            frm.MdiParent = this;
            frm.Show();
        }
        private void Btn_NotReadLater_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_AllLettersUnRead frm = new Frm_AllLettersUnRead();
            frm.MdiParent = this;
            frm.Show();
        }
        private void Btn_SecurityType_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_AllLettersInstans frm = new Frm_AllLettersInstans();
            frm.MdiParent = this;
            frm.Show();
        }
        private void Btn_LatterAction_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_AllLettersAction frm = new Frm_AllLettersAction();
            frm.MdiParent = this;
            frm.Show();
        }
        private void Btn_news_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_ShowNews frm = new Frm_ShowNews();
            frm.MdiParent = this;
            frm.Show();
        }
        private void Btn_ReciveRefrenceLetters_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_ShowReciveRefrenceLetters frm = new Frm_ShowReciveRefrenceLetters();
            frm.MdiParent = this;
            frm.Show();
        }
        private void Btn_LaterRefrence_Click(object sender, EventArgs e)
        {
           if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_SendRefrencetters frm = new Frm_SendRefrencetters();
            frm.MdiParent = this;
            frm.Show();
        }
        private void Btn_FollowUp_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_ShowLetterFollow frm = new Frm_ShowLetterFollow();
            frm.MdiParent = this;
            frm.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            GetNewLetterUser();
            GetNewLetterRefrenceUser();
        }
        private void GetNewLetterUser()
        {
            var result = LettersSend.GetIsTureNewLetter(ListUserVariable.UserID);
            if (result != 0)
            {
                timer1.Stop();
                Frm_ShownewMesseage frm = new Frm_ShownewMesseage();
                frm.ShowDialog();
            }
            timer1.Start();
        }
        private void GetNewLetterRefrenceUser()
        {
            var result = LettersSend.GetIsTruNewsLetterRefrence(ListUserVariable.UserID);
            if (result != 0)
            {
                timer1.Stop();
                Frm_ShowLetterrefrence frm = new Frm_ShowLetterrefrence();
                frm.ShowDialog();
            }
            timer1.Start();
        }
    }
}
