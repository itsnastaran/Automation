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
    public partial class Frm_AllLettersAction : Form
    {
        public Frm_AllLettersAction()
        {
            InitializeComponent();
        }

        private void Frm_AllLettersAction_Load(object sender, EventArgs e)
        {
            this.Top = 109;
            this.Left = 0;
            datefrom.Value = DateTime.Now.AddDays(-30);

            GetAllLetterUser();
        }
        private void GetAllLetterUser()
        {
            DateTime Dtf = datefrom.Value;
            DateTime DTt = dateto.Value;
            using (UnitOfWord db = new UnitOfWord())
            {
                var list = db.LetterRepository.GetAllActionLatterByUserID(ListUserVariable.UserID, Dtf, DTt, GetSearch());
                DG_ReciveAllLetters.Rows.Clear();
                if (list.Count() != 0)
                {
                    foreach (var item in list)
                    {
                        DG_ReciveAllLetters.Rows.Add(item.LetterID, item.Letter.SecurityType, item.Letter.LetterTypeAction, item.Letter.LetterNumber,
                        item.Letter.LetterSubject, item.FullNameSender, item.Letter.SecurityType == 1 ? "عادی" : "فوری",
                        item.Letter.BayganiType == 1 ? "دارد" : "ندارد", item.Letter.LetterType,
                        item.Letter.AnswerDeadline != null ? item.Letter.AnswerDeadline.Value.Toshamsi() : "",
                        item.Letter.LetterAttachment == 1 ? "دارد" : "ندارد", item.IsRead == 2 ? "خوانده شده" : "خوانده نشده", item.Letter.Reference, item.SendDateLetter.Toshamsi(),
                        item.Letter.LetterFollow == 1 ? "دارد" : "ندارد", item.Letter.LetterFile != null ? item.Letter.LetterFile : "");

                    }
                    for (int i = 0; i < list.Count(); i++)
                    {
                        if (Convert.ToInt32(DG_ReciveAllLetters.Rows[i].Cells["SecurityType"].Value) == 2)
                        {
                            DG_ReciveAllLetters.Rows[i].Cells["Security"].Style.BackColor = Color.Pink;
                        }
                        if (Convert.ToInt32(DG_ReciveAllLetters.Rows[i].Cells["SecurityType"].Value) == 3)
                        {
                            DG_ReciveAllLetters.Rows[i].Cells["Security"].Style.BackColor = Color.Red;
                        }
                        
                    }
                }
                else
                {
                    DG_ReciveAllLetters.Rows.Clear();
                }
            }
        }
        private string GetSearch()
        {

            string str = "";
            if (txtsender.Text != "")
            {
                str += "and FullName like '%" + txtsender.Text + "%'";
            }
            if (txtletternumber.Text != "")
            {
                str += "and LetterNumber like '%" + txtletternumber.Text + "%'";
            }
            if (txtsubject.Text != "")
            {
                str += "and LetterSubject like '%" + txtsubject.Text + "%'";
            }
            if (Rad_SNormal.Checked)
            {
                str += "and SecurityType=1";
            }
            if (Rad_SMahramane.Checked)
            {
                str += "and SecurityType=2";
            }
            if (Rad_SSeri.Checked)
            {
                str += "and SecurityType=3";
            }
            if (Rad_BayganiTrue.Checked)
            {
                str += "and BayeganeType=2";
            }
            if (Rad_BayganiFalse.Checked)
            {
                str += "and BayeganeType=1";
            }
            if (Rad_IsReadTrue.Checked)
            {
                str += "and LetterIsReade=2";
            }
            if (Rad_IsReadFalse.Checked)
            {
                str += "and LetterIsReade=1";
            }
            if (Rad_AtachTrue.Checked)
            {
                str += "and LetterAttachment=1";
            }
            if (Rad_AtachFalse.Checked)
            {
                str += "and LetterAttachment=2";
            }
            if (Rad_FlowTrue.Checked)
            {
                str += "and LetterFollow=1";
            }
            if (Rad_FlowFalse.Checked)
            {
                str += "and LetterFollow=2";
            }
            return str;
        }

        private void Pic_search_Click(object sender, EventArgs e)
        {
            GetAllLetterUser();
        }
    }
}
