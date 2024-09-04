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
    public partial class Frm_ShowReciveRefrenceLetters : Form
    {
        public Frm_ShowReciveRefrenceLetters()
        {
            InitializeComponent();
        }

        private void Frm_ShowReciveRefrenceLetters_Load(object sender, EventArgs e)
        {
            this.Top = 109;
            this.Left = 0;
            datefrom.Value = DateTime.Now.AddDays(-30);
            GetAllLetterRefrence();
            BindUser();
        }
        private void GetAllLetterRefrence()
        {
            DateTime Dtf = datefrom.Value;
            DateTime DTt = datefrom.Value;
            using (UnitOfWord db = new UnitOfWord())
            {
                var result = db.RefrenceLetterRepository.GetAllLetterRefrence(ListUserVariable.UserID, Dtf, DTt, GetSearch());
                DG_RefrenceAllLetter.Rows.Clear();
                if (result.Count() != 0)
                {
                    foreach (var item in result)
                    {
                        DG_RefrenceAllLetter.Rows.Add(item.LetterID, item.Letter.SecurityType, item.Letter.LetterTypeAction, item.Letter.LetterNumber, item.Letter.LetterSubject, item.User.UserFirstName+" "+item.User.UserFamily,
                        item.FullNameReference, item.Letter.SecurityType, item.Letter.LetterTypeAction, item.Letter.LetterType, item.Letter.AnswerDeadline,
                        item.ReadType, item.Letter.Reference, item.ReferenceDate.Value.Toshamsi(), item.Letter.LetterFollow, item.Description, item.Letter.LetterFile);
                    }
                }
                else
                {
                    DG_RefrenceAllLetter.Rows.Clear();
                }
            }
        }
        private string GetSearch()
        {

            string str = "";
            if (txtsender.Text != "")
            {
                str += "and FullNameRefrence like '%" + txtsender.Text + "%'";
            }
            if (txtletternumber.Text != "")
            {
                str += "and LetterNumber like '%" + txtletternumber.Text + "%'";
            }
            if (txtsubject.Text != "")
            {
                str += "and LetterSubject like '%" + txtsubject.Text + "%'";
            }
            if (txtletterref.Text != "")
            {
                str += "and Refrence like '%" + txtsubject.Text + "%'";
            }
           
            if (Com_UserCreate.SelectedIndex >= 1)
            {
                str += "and UserID =" + (int)Com_UserCreate.SelectedValue + "";

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
            GetAllLetterRefrence();
        }
        private void BindUser()
        {
            List<ListViewUserCreateLetter> list = new List<ListViewUserCreateLetter>();
            using (UnitOfWord db = new UnitOfWord())
            {
                list.Add(new ListViewUserCreateLetter()
                {
                    Fullname = "نامی انتخاب کنید",
                    UserID = 0

                });
                list.AddRange(db.RefrenceLetterRepository.Get());
                Com_UserCreate.DataSource = list;
                Com_UserCreate.DisplayMember = "Fullname";
                Com_UserCreate.ValueMember = "UserID";
            }
        }
    }
}
