using MyProjectt.DataLayer.Context;
using MyProjectt.Utility.Convert;
using MyProjectt.ViewModel.User;
using MyProjectt.Utility.Files;
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
    public partial class Frm_RecivAllLatters : Form
    {
        public Frm_RecivAllLatters()
        {
            InitializeComponent();
        }

        private void Frm_RecivAllLatters_Load(object sender, EventArgs e)
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
            string DateFrom = Dtf.ToString();
            string DateTo = DTt.ToString();
            using (UnitOfWord db = new UnitOfWord())
            {
                var list = db.LetterRepository.GetAllLetterUserByUserID(ListUserVariable.UserID, Dtf, DTt, GetSearch());
                DG_ReciveAllLetters.Rows.Clear();
                if (list.Count() != 0)
                {
                    foreach (var item in list)
                    {
                        DG_ReciveAllLetters.Rows.Add(item.LetterID, item.Letter.SecurityType , item.Letter.LetterTypeAction, item.Letter.BayganiType, item.Letter.LetterNumber,
                        item.Letter.LetterSubject, item.FullNameSender, item.Letter.SecurityType == 1 ? "عادی" : "فوری",
                        item.Letter.LetterTypeAction == 1 ? "عادی" : "محرمانه", item.Letter.BayganiType == 1 ? "دارد" : "ندارد", item.Letter.LetterType,
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
                        if (Convert.ToInt32(DG_ReciveAllLetters.Rows[i].Cells["LAtction"].Value) == 2)
                        {
                            DG_ReciveAllLetters.Rows[i].Cells["LatterAction"].Style.BackColor = Color.Yellow;
                        }
                        if (Convert.ToInt32(DG_ReciveAllLetters.Rows[i].Cells["LAtction"].Value) == 3)
                        {
                            DG_ReciveAllLetters.Rows[i].Cells["LatterAction"].Style.BackColor = Color.DarkRed;
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
                str += "and FullNameSender like '%" + txtsender.Text + "%'";
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
                str += "and SecurityType=1 ";
            }
            if (Rad_SMahramane.Checked)
            {
                str += "and SecurityType=2";
            }
            if (Rad_SSeri.Checked)
            {
                str += "and SecurityType=3";
            }
            if (Rad_LANormal.Checked)
            {
                str += "and LatterTypeAction=1";
            }
            if (Rad_LAFori.Checked)
            {
                str += "and LatterTypeAction=2";
            }
            if (Rad_LAAniy.Checked)
            {
                str += "and LatterTypeAction=3";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                IEnumerable<DataLayer.SendLetter> list = db.LetterRepository.Getletter(ListUserVariable.UserID,Createsearchstring());
                DG_ReciveAllLetters.Rows.Clear();
                if (list.Count() != 0)
                {
                    foreach (var item in list)
                    {
                        DG_ReciveAllLetters.Rows.Add(item.LetterID, item.Letter.SecurityType, item.Letter.LetterTypeAction, item.Letter.BayganiType, item.Letter.LetterNumber,
                        item.Letter.LetterSubject, item.FullNameSender, item.Letter.SecurityType == 1 ? "عادی" : "فوری",
                        item.Letter.LetterTypeAction == 1 ? "عادی" : "محرمانه", item.Letter.BayganiType == 1 ? "دارد" : "ندارد", item.Letter.LetterType,
                        item.Letter.AnswerDeadline != null ? item.Letter.AnswerDeadline.Value.Toshamsi() : "",
                        item.Letter.LetterAttachment == 1 ? "دارد" : "ندارد", item.IsRead == 2 ? "خوانده شده" : "خوانده نشده", item.Letter.Reference, item.SendDateLetter.Toshamsi(),
                        item.Letter.LetterFollow == 1 ? "دارد" : "ندارد", item.Letter.LetterFile != null ? item.Letter.LetterFile : "");

                    }
                }
                else
                {
                    DG_ReciveAllLetters.Rows.Clear();
                }
                DG_ReciveAllLetters.ScrollBars = ScrollBars.Both;
            }
        }
        private string Createsearchstring()
        {
            string str = "";
            if (txtsender.Text != "")
            {
                str += "and FullNameSender like '%" + txtsender.Text + "%'";
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
                str += "and Letter.SecurityType=1";
            }
            if (Rad_SMahramane.Checked)
            {
                str += "and Letter.SecurityType=2";
            }
            if (Rad_SSeri.Checked)
            {
                str += "and Letter.SecurityType=3";
            }
            if (Rad_LANormal.Checked)
            {
                str += "and LatterTypeAction=1";
            }
            if (Rad_LAFori.Checked)
            {
                str += "and LatterTypeAction=2";
            }
            if (Rad_LAAniy.Checked)
            {
                str += "and LatterTypeAction=3";
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
    }
}
