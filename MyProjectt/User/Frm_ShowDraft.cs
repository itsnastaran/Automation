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

namespace MyProjectt.User
{
    public partial class Frm_ShowDraft : Form
    {
        public Frm_ShowDraft()
        {
            InitializeComponent();
        }

        private void Frm_ShowDraft_Load(object sender, EventArgs e)
        {
            this.Top = 109;
            this.Left = 0;
            GetInformationLetter();
        }
        private void GetInformationLetter()
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                int UserID = ListUserVariable.UserID;
                IEnumerable<Letter> list = db.LetterRepository.GetLattertypeDraft(Getsearch(), UserID);
                DG_Show_Draft.Rows.Clear();

                if (list.Count() != 0)
                {
                    foreach (var item in list)
                    {
                        DG_Show_Draft.Rows.Add(item.LetterID, item.LetterSubject, item.LetterNumber, item.CreateDate.Value.Toshamsi(), item.SecurityType==1? "عادی":"فوری", item.LetterTypeAction==1? "عادی":"محرمانه", item.LetterFollow==1?"دارد":"ندارد", item.LetterAttachment == 1 ? "دارد" : "ندارد", item.AnswerDeadline != null ? item.AnswerDeadline.Value.Toshamsi() : "", item.LetterType, item.SecurityType);
                    }

                    for (int i = 0; i < list.Count(); i++)
                    {
                        if (Convert.ToInt32(DG_Show_Draft.Rows[i].Cells["ST"].Value) == 2)
                        {
                            DG_Show_Draft.Rows[i].Cells["SecurityType"].Style.BackColor = Color.Pink;
                        }
                        else if (Convert.ToInt32(DG_Show_Draft.Rows[i].Cells["ST"].Value) == 3)
                        {
                            DG_Show_Draft.Rows[i].Cells["SecurityType"].Style.BackColor = Color.Red;
                        }
                    }
                }
                else
                {
                    DG_Show_Draft.Rows.Clear();
                }
            }
        }
        private string Getsearch()
        {
            string str = "";
            if (txt_subject.Text != null)
            {
                str += "and LetterSubject like'%" + txt_subject.Text + "%'";
            }

            if (Rad_SecurityNormal.Checked)
            {
                str += "and SecurityType=1";
            }
            if (Rad_Securityins.Checked)
            {

                str += "and LatterTypeAction=2";
            }
            if (Rad_SecurityAney.Checked)
            {
                str += "and LatterTypeAction=3";
            }

            if (Rad_Actionnormal.Checked)
            {
                str += "and SecurityType=1";

            }
            if (Rad_ActionS.Checked)
            {
                str += "and SecurityType=2";
            }
            if (Rad_ActionM.Checked)
            {

                str += "and SecurityType=3";
            }
            return str;
        }

        private void Picserach_Click(object sender, EventArgs e)
        {
            GetInformationLetter();
        }

        private void Btn_Deletefromdraft_Click(object sender, EventArgs e)
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                if (DG_Show_Draft.CurrentRow.Selected)
                {
                    string letterDraft = DG_Show_Draft.CurrentRow.Cells["SubjectLetter"].Value.ToString();
                    int LetterID = (int)DG_Show_Draft.CurrentRow.Cells[0].Value;
                    int UserID = ListUserVariable.UserID;
                    if (db.AtachFileRepository.GetFileisAcess(LetterID))
                    {
                        MessageBox.Show("برای حذف پیش نویس اول فایل را حذف کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (MessageBox.Show($"آیا از حذف پیش نویس به موضوع {letterDraft} مطمئن هستید", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            bool issuccess = db.LetterRepository.DeleteLetterDraft(UserID, LetterID);
                            if (issuccess)
                            {
                                MessageBox.Show("عملیات با موفقیت با موفقیت انجام شد", "عملیات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("در انجام عملیات مشکلی بوجود آمده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("برای حذف باید اول سطر جاری را انتخاب کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.Save();
                GetInformationLetter();
            }
        }

        private void Btn_sendletter_Click(object sender, EventArgs e)
        {
            if (DG_Show_Draft.Rows.Count != 0)
            {
                if (DG_Show_Draft.CurrentRow.Selected == true)
                {
                    int LaterID = (int)DG_Show_Draft.CurrentRow.Cells[0].Value;
                    Frm_SelectUserSendLatter frm = new Frm_SelectUserSendLatter();
                    frm.LaterIDSelect = LaterID;
                    frm.ShowDialog();
                    GetInformationLetter();
                }
                else
                {
                    MessageBox.Show("برای ارسال نامه باید سطری را انتخاب کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("هیچ نامه ای برای ارسال ندارید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Btn_EditLetter_Click(object sender, EventArgs e)
        {
            if (DG_Show_Draft.CurrentRow.Selected)
            {
                int LatterID = (int)DG_Show_Draft.CurrentRow.Cells[0].Value;
                
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();

                Frm_CreateLetter frm = new Frm_CreateLetter();
                frm.LeterID_EditeAdd = LatterID;
                frm.MdiParent = Frm_MainUser.ActiveForm;

                frm.Show();
            }
            else
            {
                MessageBox.Show("برای ویرایش نامه باید نامه ای را انتخاب کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    
    
    }
}
