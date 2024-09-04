using MyProjectt.Bissuns;
using MyProjectt.DataLayer;
using MyProjectt.DataLayer.Context;
using MyProjectt.Utility.Convert;
using MyProjectt.ViewModel.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using TextRuler.AdvancedTextEditorControl;


namespace MyProjectt.User
{
    public partial class Frm_CreateLetter : Form
    {
        public int LeterID_EditeAdd { get; set; } = 0;
        public string LatterNumber { get; set; }
        public Frm_CreateLetter()
        {
            InitializeComponent();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_CreateLetter_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTabIndex = 0;
            this.Top = 109;
            this.Left = 0;
            if (LeterID_EditeAdd == 0)
            {
                this.btn_createletter.Text = "ایجاد نامه";
            }

            else if (LeterID_EditeAdd != 0 && !string.IsNullOrEmpty(LatterNumber)) 
            {

            }

            else 
            {
                this.btn_createletter.Text = "ویرایش نامه";
                if (LeterID_EditeAdd != 0)
                {
                    GetInfornationLatter(LeterID_EditeAdd);
                }
            }
        }

        private void btn_createletter_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {
                errorProvider1.Clear();
                using (TransactionScope scope = new TransactionScope())
                {
                    using (UnitOfWord db = new UnitOfWord())
                    {
                        byte securityType = 1;
                        byte LatterAction = 1;
                        if (Rad_SecurityMahramne.Checked)
                        {
                            securityType = 2;
                        }
                        if (Rad_Securityseriy.Checked)
                        {
                            securityType = 3;
                        }
                        if (LatterTActionfori.Checked)
                        {
                            LatterAction = 2;
                        }
                        if (LatterTActionAniy.Checked)
                        {
                            LatterAction = 3;
                        }

                        Letter later = new Letter()
                        {
                            LetterSubject = txt_subject.Text,
                            LetterAbstract = txt_abstract.Text,
                            LetterText = advanceTextEditor1.TextEditor.Text,
                            LetterNumber = ULetter.GetLatternumber().LatterNumber, 
                            SecurityType = securityType,
                            LetterTypeAction = LatterAction,
                            LetterFollow = Rad_FllowYes.Checked ? (byte)1 : (byte)2,
                            LetterAttachment = Rad_AttachmentYes.Checked ? (byte)1 : (byte)2,
                            LetterResponse = Rad_ResponseYes.Checked ? (byte)1 : (byte)2,
                            CreateDate = DateTime.Now,
                            BayganiType = 1,
                            LetterType = 1,
                            DraftType = 1,
                            LetterFile = "matn",
                            Reference = "letter",
                            UserID = ListUserVariable.UserID
                        };
                        
                        if (Rad_ResponseYes.Checked)
                        {
                            later.AnswerDeadline = ConvertDate.ConvertShamsiToMiladi(PersinaDateTime.Value.Year, PersinaDateTime.Value.Month, PersinaDateTime.Value.Day);
                        }
                      
                        if (LeterID_EditeAdd != 0 && !string.IsNullOrEmpty(LatterNumber))
                        {
                            later.LetterType = 2;
                            later.ReplyRetterID = LeterID_EditeAdd;
                            later.Reference = this.LatterNumber;
                            LeterID_EditeAdd = 0;
                        }
                        AttachFile AL = new AttachFile(); 
                        if (Rad_AttachmentYes.Checked)
                        {
                            int _Sizefile = 0;
                            string _filename = "";
                            byte[] _filedate = { 0 };
                            if (Rad_AttachmentYes.Checked == true)
                            {
                                if (!chechAtchFileisAcssess())
                                {
                                    if (!string.IsNullOrEmpty(Lbl_PathFile.Text))
                                    {
                                        _filedate = FilesRead.GetReadFiles(out _Sizefile, out _filename, Lbl_PathFile.Text);
                                        AL = new AttachFile()
                                        {
                                            FileSize = _Sizefile,
                                            FileName = _filename,
                                            LetterID = later.LetterID,
                                            FileDate = _filedate
                                        };
                                        if (this.LeterID_EditeAdd != 0) 
                                        {
                                            AL.LetterID = LeterID_EditeAdd;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("شما باید فایلی را هم انتخاب کنبد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }
                        }
                        if (LeterID_EditeAdd == 0)
                        {
                            
                            if (Rad_AttachmentYes.Checked == true)
                            {
                                bool issuccess = db.LeterGRepository.Insert(later);
                                bool isAtachfile = db.AtachFileG.Insert(AL);
                                if (issuccess && isAtachfile)
                                {
                                    MessageBox.Show("ثبت نامه با موفقیت انجام شد و به قسمت پیش نویس ها منتقل شد.", "اطاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("عملیات با شکست مواجه شد.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                bool issuccess = db.LeterGRepository.Insert(later);
                                if (issuccess)
                                {
                                    MessageBox.Show("ثبت نامه با موفقیت انجام شد و به قسمت پیش نویس ها منتقل شد.", "اطاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("عملیات با شکست مواجه شد.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                        }
                        else
                        {
                            later.LetterID = LeterID_EditeAdd;
                            
                            bool issuccess = db.LeterGRepository.Update(later);
                            
                            if (Rad_AttachmentNot.Checked == true)
                            {
                                bool istrue = db.AtachFileRepository.DeleteAtachFileByLaterID(this.LeterID_EditeAdd);
                                if (istrue && issuccess) 
                                {
                                    MessageBox.Show("عملیات با موفقیت انجام شد", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else if (issuccess) 
                                {
                                    MessageBox.Show("عملیات با موفقیت انجام شد", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("عملیات با شکست مواجه شده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            if (Rad_AttachmentYes.Checked == true)
                            {
                                
                                if (!chechAtchFileisAcssess()) 
                                {
                                  
                                    db.AtachFileRepository.DeleteAtachFileByLaterID(this.LeterID_EditeAdd);
                                    db.AtachFileG.Insert(AL);
                                }
                                if (issuccess)
                                {
                                    MessageBox.Show("عملیات با موفقیت انجام شد", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("عملیات با شکست مواجه شده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        db.Save();
                    }
                    scope.Complete();
                    this.LeterID_EditeAdd = 0;
                }
            }
        }
        private bool isvalid()
        {
            bool flag = true;
            if (string.IsNullOrEmpty(txt_subject.Text))
            {
                errorProvider1.SetError(txt_subject, "موضوع نمیتواند خالی باشد");
                errorProvider1.SetIconAlignment(txt_subject, ErrorIconAlignment.MiddleLeft);
                flag = false;
            }
            if (string.IsNullOrEmpty(txt_abstract.Text))
            {
                errorProvider1.SetError(txt_abstract, "چکیده نمیتواند خالی باشد");
                errorProvider1.SetIconAlignment(txt_abstract, ErrorIconAlignment.MiddleLeft);
                flag = false;
            }
            if (string.IsNullOrEmpty(advanceTextEditor1.TextEditor.Text))
            {
                MessageBox.Show("متن نامه نمیتواند خالی باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            return flag;
        }
        private void Rad_AttachmentYes_CheckedChanged(object sender, System.EventArgs e)
        {
            if (Rad_AttachmentYes.Checked == true)
            {
                btn_AtachmentFile.Enabled = true;
            }
            else
            {
                btn_AtachmentFile.Enabled = false;
            }
        }
        private void Rad_ResponseYes_CheckedChanged(object sender, System.EventArgs e)
        {
            if (Rad_ResponseYes.Checked == true)
            {
                PersinaDateTime.Enabled = true;
            }
            else
            {
                PersinaDateTime.Enabled = false;

            }
        }

        private void btn_AtachmentFile_Click(object sender, System.EventArgs e)
        {
            openFileDialog1.Filter = "All Files (*.*) | *.*";
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                List<string> str = new List<string>() { ".zip", ".pdf", ".doc", ".xls", ".xlsx", ".docx", ".jpg", ".png" };
                string Formatfile = Path.GetExtension(openFileDialog1.FileName);
                if (!str.Contains(Formatfile))
                {
                    MessageBox.Show("فایلی با فرمت مناسب انتخاب کنید", "هشدار", MessageBoxButtons.OK);
                    return;
                }
                Lbl_PathFile.Text = openFileDialog1.FileName;
            }
        }
        private bool chechAtchFileisAcssess()
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                bool istrue = db.AtachFileRepository.checkFileAccess(this.LeterID_EditeAdd, Lbl_PathFile.Text.Trim());
                if (istrue)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private void GetInfornationLatter(int LatterID)
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                var result = db.LetterRepository.GetLatterById(LatterID, ListUserVariable.UserID);
                if (result != null)
                {
                    txt_subject.Text = result.LetterSubject;
                    txt_abstract.Text = result.LetterAbstract;
                    tabControl1.SelectedTabIndex = 1;
                    advanceTextEditor1.TextEditor.Text = result.LetterText;
                    tabControl1.SelectedTabIndex = 0;
                    if (result.SecurityType == 2)
                    {
                        Rad_SecurityMahramne.Checked = true;
                    }
                    if (result.SecurityType == 2)
                    {
                        Rad_Securityseriy.Checked = true;
                    }
                    if (result.LetterTypeAction == 2)
                    {
                        LatterTActionfori.Checked = true;
                    }
                    if (result.LetterTypeAction == 3)
                    {
                        LatterTActionAniy.Checked = true;
                    }
                    if (result.LetterFollow == 1)
                    {
                        Rad_FllowYes.Checked = true;
                    }
                    else
                    {
                        Rad_Fllownot.Checked = true;
                    }
                    if (result.LetterAttachment == 1)
                    {
                        Rad_AttachmentYes.Checked = true;
                        var resfilename = db.AtachFileRepository.GetFilenameByLatterID(LeterID_EditeAdd);
                        if (resfilename != null)
                        {
                            Lbl_PathFile.Text = resfilename;
                        }
                    }
                    else
                    {
                        Rad_AttachmentNot.Checked = true;
                    }
                    if (result.LetterResponse == 1)
                    {
                        DateTime d = new DateTime();
                        d = (DateTime)result.AnswerDeadline;
                        PersinaDateTime.Value = d;
                        Rad_ResponseYes.Checked = true;
                    }
                    else
                    {
                        Rad_ResponseNot.Checked = true;
                    }
                }
            }
        }
    }
}
