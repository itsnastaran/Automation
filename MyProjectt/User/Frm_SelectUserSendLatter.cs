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
using System.Transactions;
using System.Windows.Forms;

namespace MyProjectt.User
{
    public partial class Frm_SelectUserSendLatter : Form
    {
        public int LaterIDSelect { get; set; }
        public int TypeForm { set; get; } = 0;
        public Frm_SelectUserSendLatter()
        {
            InitializeComponent();
        }

        private void Frm_SelectUserSendLatter_Load(object sender, EventArgs e)
        {
            if (TypeForm != 0)
            {
                this.Btn_Send.Text = "ارجاع نامه";
                this.Text = "فرم ارجاع نامه";
                Grop_discriptionLetter.Visible = true;
                GetUserrefrencLetter();
                DG_ShowUser.Height = 181;

            }
            else
            {
                GetUserSendLatters();
                Grop_discriptionLetter.Visible = false;
                DG_ShowUser.Height = 293;
            }

        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Picserach_Click(object sender, EventArgs e)
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                if (txtfullname.Text != null)
                {
                    var DTjoblevel = db.USetJobRepository.GetDtjobLevelIDByUserID(ListUserVariable.UserID);
                    var result = db.USetJobRepository.GetAllUserReciveLatterFilterByFillname(DTjoblevel, ListUserVariable.UserID, txtfullname.Text);
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

        private void txtfullname_TextChanged(object sender, EventArgs e)
        {
            Picserach_Click(sender, e);
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            
            bool checkd = false;
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
                      
                        if (TypeForm == 0)
                        {
                            bool isupdateLater = db.LetterRepository.UpdateDrafttypeLatterByID(this.LaterIDSelect);
                            if (isupdateLater)
                            {
                                bool isAtchSendLatter = true;
                                foreach (DataGridViewRow item in DG_ShowUser.Rows)
                                {
                                    if (Convert.ToBoolean(item.Cells["SelectUser"].Value) == true)
                                    {
                                        string Fullname = DG_ShowUser.CurrentRow.Cells["Fullname"].Value.ToString();
                                        SendLetter sl = new SendLetter()
                                        {
                                            SendDateLetter = DateTime.Now,
                                            LetterID = this.LaterIDSelect,
                                            UserID = (int)item.Cells["ReciveUserID"].Value,
                                            UserID_SendLetters = ListUserVariable.UserID,
                                            IsRead = 1,
                                            FullNameReciveLetters = Fullname,
                                            FullNameSender = ListUserVariable.Fullname,
                                            IsShow = 1
                                        };
                                        isAtchSendLatter = db.SendLatterG.Insert(sl);
                                    }
                                }
                                if (isAtchSendLatter)
                                {
                                    MessageBox.Show("عملیات ارسال نامه با موفقیت انجام شد", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("عملیات با خطا مواجه شد ، دوباره امتحان کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                           
                            var resultLevelNumbers = db.RefrenceLetterRepository.GetCountLevelNumbers(LaterIDSelect);
                            if (resultLevelNumbers != 0)
                            {
                                resultLevelNumbers = (resultLevelNumbers + 1);
                            }
                            else
                            {
                                resultLevelNumbers = 1;
                            }
                            bool isinsert = true;
                            foreach (DataGridViewRow item in DG_ShowUser.Rows)
                            {
                                if (Convert.ToBoolean(item.Cells["SelectUser"].Value) == true)
                                {
                                    string FullnameReciveLatters = DG_ShowUser.CurrentRow.Cells["Fullname"].Value.ToString();
                                    int UserReciveID = (int)DG_ShowUser.CurrentRow.Cells[0].Value;

                                    

                                    bool ischeckRefrenceLetter = db.RefrenceLetterRepository.CheckRefrenceLetter(LaterIDSelect, UserReciveID, ListUserVariable.UserID);

                                    if (ischeckRefrenceLetter)
                                    {
                                        MessageBox.Show($"این نامه از قبل به {FullnameReciveLatters} ارجاع داده شده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    ReferenceLetter rfce = new ReferenceLetter() 
                                    {
                                        LetterID = LaterIDSelect,
                                        UserIDReference = ListUserVariable.UserID,
                                        UserIDReciveID = (int)DG_ShowUser.CurrentRow.Cells["ReciveUserID"].Value,
                                        FullNameRecive = FullnameReciveLatters,
                                        FullNameReference = ListUserVariable.Fullname,
                                        ReferenceDate = DateTime.Now,
                                        ReadType = 1,
                                        Description = Rich_description.Text,
                                        LevelNumbers = resultLevelNumbers,
                                        IsShow = 1
                                    };
                                    isinsert = db.RefrenceLetterRepositoryG.Insert(rfce);
                                }

                            }
                            if (isinsert) 
                            {
                                MessageBox.Show("نامه با موفقیت ارجاع داده شد", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("در ارجاع نامه مشکلی بوجود آمده است، لطفا دوباره امتحان کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        db.Save();
                        transaction.Complete();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("برای ارسال نامه حتما باید شخصی را انتخاب کنید", "هشدار");
            }
        }
        private void GetUserSendLatters()
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
        private void GetUserrefrencLetter()
        {
            
            using (UnitOfWord db = new UnitOfWord())
            {
                int UserIDCreateLetter = db.LetterRepository.GetUserIDByLetterID(LaterIDSelect);
                var DTjoblevel = db.USetJobRepository.GetDtjobLevelIDByUserID(ListUserVariable.UserID);
                if (DTjoblevel != 0)
                {
                    var result = db.USetJobRepository.GetAllUserReciveLatterFilterByFillname(DTjoblevel, txtfullname.Text, UserIDCreateLetter);
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
    }
}
