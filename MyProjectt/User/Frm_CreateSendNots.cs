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
using System.Transactions;
using System.Windows.Forms;

namespace MyProjectt.User
{
    public partial class Frm_CreateSendNots : Form
    {
        public Frm_CreateSendNots()
        {
            InitializeComponent();
        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_CreateSendNots_Load(object sender, EventArgs e)
        {
            this.Top = 109;
            this.Left = 0;
            lbl_date.Text = DateTime.Now.Toshamsi();
            GetAllInformation();
        }
        private void GetAllInformation()
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                var DTjoblevel = db.USetJobRepository.GetDtjobLevelIDByUserID(ListUserVariable.UserID);
                if (DTjoblevel != 0)
                {
                    var result = db.USetJobRepository.GetAllUserReciveLatter(DTjoblevel, ListUserVariable.UserID);
                    if (result != null)
                    {
                        foreach (var item in result)
                        {
                            
                            DG_ShowUser.Rows.Add(item.ReciveUserID, item.UserFullName, item.JobName, item.DtJobLevel);
                        }
                    }
                }
            }
        }

        private void pic_search_Click(object sender, EventArgs e)
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                if (txt_fullname.Text != null)
                {
                    var DTjoblevel = db.USetJobRepository.GetDtjobLevelIDByUserID(ListUserVariable.UserID);
                    var result = db.USetJobRepository.GetAllUserReciveLatterFilterByFillname(DTjoblevel, ListUserVariable.UserID, txt_fullname.Text);
                    var lst = result.GetEnumerator();
                    DG_ShowUser.Rows.Clear();
                    if (lst.MoveNext())
                    {
                        foreach (var item in result)
                        {
                            DG_ShowUser.Rows.Add(item.ReciveUserID, item.UserFullName, item.JobName, item.DtJobLevel);
                        }
                    }
                    else
                    {
                        DG_ShowUser.Rows.Clear();
                    }
                }
            }
        }

        private void Btn_sendnote_Click(object sender, EventArgs e)
        {
            bool checkd = false;

            if (Check(txt_subject.Text, txt_matn.Text))
            {
                errorProvider_Matn.Clear();
                errorProvider_subject.Clear();

                foreach (DataGridViewRow item in DG_ShowUser.Rows)
                {
                    if (Convert.ToBoolean(item.Cells["SelectUser"].Value) == true)
                    {
                        checkd = true;
                    }
                }

                if (checkd)
                {
                    using (TransactionScope transaction = new TransactionScope())
                    {
                        using (UnitOfWord db = new UnitOfWord())
                        {
                            bool isAtachSendnot = true;
                            
                            Note N = new Note()
                            {
                                SubjectNote = txt_subject.Text,
                                SubjectMatn = txt_matn.Text,
                                CreateDateNod = DateTime.Now,
                                UserID_Sender = ListUserVariable.UserID,
                                FullNameSender = ListUserVariable.Fullname
                            };
                            foreach (DataGridViewRow item in DG_ShowUser.Rows)
                            {
                                if (Convert.ToBoolean(item.Cells["SelectUser"].Value) == true)
                                {
                                    string Fullname = DG_ShowUser.CurrentRow.Cells["Fullname"].Value.ToString();
                                    int userId = Convert.ToInt32(DG_ShowUser.CurrentRow.Cells["ReciveUserID"].Value);
                                    SendNote sn = new SendNote()
                                    {
                                        FullName = Fullname,
                                        SendDate = DateTime.Now,
                                        NoteID = N.NoteID,
                                        UserID_Recive = userId
                                    };
                                    isAtachSendnot = db.SendNotRepositoryG.Insert(sn);
                                }
                            }
                            bool isAtachNods = db.NotRepositoryG.Insert(N);
                            if (isAtachNods && isAtachSendnot)
                            {
                                MessageBox.Show("عملیات موفقیت آمیز بود");
                            }
                            else
                            {
                                MessageBox.Show("عملیات با شکست مواجه شد");
                            }
                            db.Save();
                        }

                        transaction.Complete();
                    }
                }
                else
                {
                    MessageBox.Show("باید برای ارسال نامه شخصی را انتخاب کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                return;
            }

        }
        private bool Check(string Subject, string Matn)
        {
            bool isflag = true;
            if (string.IsNullOrEmpty(Subject))
            {
                errorProvider_subject.SetError(txt_subject, "موضوع یاداشت نمی تواند خالی باشد");
                isflag = false;
            }
            if (string.IsNullOrEmpty(Matn))
            {
                errorProvider_Matn.SetError(txt_matn, "متن یاداشت نمی تواند خالی باشد");
                isflag = false;
            }
            return isflag;
        }
    }
}
