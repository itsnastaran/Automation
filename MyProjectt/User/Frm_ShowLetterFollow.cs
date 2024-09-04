﻿using MyProjectt.DataLayer.Context;
using MyProjectt.Utility.Convert;
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
    public partial class Frm_ShowLetterFollow : Form
    {
        public Frm_ShowLetterFollow()
        {
            InitializeComponent();
        }

        private void Frm_ShowLetterFollow_Load(object sender, EventArgs e)
        {
            this.Top = 109;
            this.Left = 0;
            datefrom.Value = DateTime.Now.AddDays(-30);
            dateto.Value = DateTime.Now.AddDays(1);
            GetAllLetterUser();
        }
        private void GetAllLetterUser()
        {
            DateTime Start = datefrom.Value;
            DateTime End = dateto.Value;
            using (UnitOfWord db = new UnitOfWord())
            {
                var list = db.LetterRepository.GetAllSendLetterFollow(ViewModel.User.ListUserVariable.UserID, Start, End, "");
                DG_AllSendLeterFlow.Rows.Clear();
                if (list.Count() != 0)
                {
                    foreach (var item in list)
                    {
                        DG_AllSendLeterFlow.Rows.Add(item.LetterID, item.Letter.SecurityType, item.Letter.LetterTypeAction, item.Letter.LetterNumber,
                        item.Letter.LetterSubject, item.FullNameReciveLetters, item.Letter.SecurityType,
                        item.Letter.LetterTypeAction, item.Letter.BayganiType, item.Letter.LetterType,
                        item.Letter.AnswerDeadline != null ? item.Letter.AnswerDeadline.Value.Toshamsi() : "",
                        item.Letter.LetterAttachment, item.Letter.Reference, item.SendDateLetter.Toshamsi(),
                        item.Letter.LetterFollow, item.Letter.LetterFile != null ? item.Letter.LetterFile : "");
                    }

                    for (int i = 0; i < list.Count(); i++)
                    {
                        if (Convert.ToInt32(DG_AllSendLeterFlow.Rows[i].Cells["SecurityType"].Value) == 2)
                        {
                            DG_AllSendLeterFlow.Rows[i].Cells["Security"].Style.BackColor = Color.Pink;
                        }
                        if (Convert.ToInt32(DG_AllSendLeterFlow.Rows[i].Cells["SecurityType"].Value) == 3)
                        {
                            DG_AllSendLeterFlow.Rows[i].Cells["Security"].Style.BackColor = Color.Red;
                        }
                        if (Convert.ToInt32(DG_AllSendLeterFlow.Rows[i].Cells["LAtction"].Value) == 2)
                        {
                            DG_AllSendLeterFlow.Rows[i].Cells["LatterAction"].Style.BackColor = Color.Yellow;
                        }
                        if (Convert.ToInt32(DG_AllSendLeterFlow.Rows[i].Cells["LAtction"].Value) == 3)
                        {
                            DG_AllSendLeterFlow.Rows[i].Cells["LatterAction"].Style.BackColor = Color.DarkRed;
                        }
                    }
                }
                else
                {
                    DG_AllSendLeterFlow.Rows.Clear();
                }
            }
        }
        private string GetSearch()
        {

            string str = "";
            if (txtreciver.Text != "")
            {
                str += "and FullNameReciveLetters like '%" + txtreciver.Text + "%'";
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
            return str;
        }

        private void Pic_search_Click(object sender, EventArgs e)
        {
            GetSearch();
        }

        private void DG_AllSendLeterFlow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                var savefiles = new SaveFileDialog();
                var result = DG_AllSendLeterFlow["FileAtachment", e.RowIndex].Value.ToString();
                if (DG_AllSendLeterFlow.Columns[e.ColumnIndex].Name == "FileAtachment" && result != "")
                {
                    using (UnitOfWord db = new UnitOfWord())
                    {
                        int LaterID = (int)DG_AllSendLeterFlow.CurrentRow.Cells["LetterID"].Value;
                        savefiles.FileName = result;
                        if (savefiles.ShowDialog() == DialogResult.OK)
                        {
                            byte[] FileDate = db.AtachFileRepository.GetFileDateByLatterID(LaterID);
                            bool isacsess = SaveFiles.SaveFile(savefiles.FileName, FileDate);
                            if (isacsess)
                            {
                                MessageBox.Show("فایل پیوست با موفقیت دانلود شد");
                            }
                            else
                            {
                                MessageBox.Show("در دانلود فایل مشکلی بوجود آمده است");
                            }
                        }
                    }
                }
            }
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {

        }
        private void CiriculiionLetter_Click(object sender, EventArgs e)
        {
            if (DG_AllSendLeterFlow.CurrentRow.Selected)
            {
                int LetterID = (int)DG_AllSendLeterFlow.CurrentRow.Cells[0].Value;
                string LetterNumber = DG_AllSendLeterFlow.CurrentRow.Cells["LatterNumber"].Value.ToString();
                string SendDateLetter = DG_AllSendLeterFlow.CurrentRow.Cells["SendDate"].Value.ToString();
                Frm_showCirculationletter frm = new Frm_showCirculationletter();
                frm.LeeterID = LetterID;
                frm.LetterNumber = LetterNumber;
                frm.SendDateLeter = SendDateLetter;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("برای مشاهده گردش نامه، باید نامه را انتخاب کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
