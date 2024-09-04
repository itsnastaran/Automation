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
using System.Windows.Forms;

namespace MyProjectt.AdminPanel
{
    public partial class Frm_CreateNews : Form
    {
        public int EditeNewID { get; set; } = 0;
        public Frm_CreateNews()
        {
            InitializeComponent();
        }

        private void Frm_CreateNews_Load(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.Toshamsi();
            lbl_username.Text = ListUserVariable.Fullname;
            if (EditeNewID == 0)
            {
                this.btn_save.Text = "ثبت خیر";
                this.Text = "فرم ثبت خبر";
            }
            else
            {
                this.btn_save.Text = "ویرایش خبر";
                this.Text = "فرم ویرایش خبر";
                using (UnitOfWord db = new UnitOfWord())
                {
                    var result = db.NewRepository.GetInformationByID(EditeNewID);
                    if (result != null)
                    {
                        txt_subject.Text = result.Subject;
                        txt_textnews.Text = result.NewsText;
                        lbl_date.Text = result.CreateDate.Value.Toshamsi();
                        if (result.FileName != null)
                        {
                            rad_yes.Checked = true;
                            lbl_fileatach.Text = result.FileName;
                        }
                    }
                }
            }
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private bool ChechForamtExtension(string Format)
        {
            bool flag = true;
            switch (Format)
            {
                case ".zip":
                    flag = true;
                    break;
                case ".pdf":
                    flag = true;
                    break;
                case ".doc":
                    flag = true;
                    break;
                case ".xls":
                    flag = true;
                    break;
                case ".xlsx":
                    flag = true;
                    break;
                case ".docx":
                    flag = true;
                    break;
                case ".jpg":
                    flag = true;
                    break;
                case ".png":
                    flag = true;
                    break;
                case ".txt":
                    flag = true;
                    break;
                default:
                    flag = false;
                    break;
            }
            return flag;
        }
        
        private bool CheckNotNull()
        {
            bool flag = true;
            if (string.IsNullOrEmpty(txt_subject.Text))
            {
                errorProvider1.SetError(txt_subject, "عنوان خبر نمیتواند خالی باشد ...");
                errorProvider1.SetIconAlignment(txt_subject, ErrorIconAlignment.BottomLeft);
                txt_subject.Focus();
                flag = false;
            }
            else if (string.IsNullOrEmpty(txt_textnews.Text))
            {
                errorProvider1.SetError(txt_textnews, "متن خبر نمیتواند خالی باشد");
                errorProvider1.SetIconAlignment(txt_textnews, ErrorIconAlignment.BottomLeft);
                txt_textnews.Focus();
                flag = false;
            }
            return flag;

        }

       


        private void rad_yes_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_yes.Checked == true)
            {
                this.btn_attachfile.Enabled = true;
            }
            else
            {
                this.btn_attachfile.Enabled = false;
            }
        }

        private void btn_attachfile_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            open.Filter = "All Files (*.*) |*.*";
            open.FileName = "";
            open.Multiselect = false;
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (ChechForamtExtension(Path.GetExtension(open.FileName)))
                {
                    lbl_fileatach2.Text = open.FileName;
                }
                else
                {
                    MessageBox.Show("باید فرمت مناسب انتخاب شود", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (CheckNotNull())
            {
                using (UnitOfWord db = new UnitOfWord())
                {
                    News ns = new News()
                    {
                        CreateDate = DateTime.Now,
                        NewsText = txt_textnews.Text,
                        Subject = txt_subject.Text,
                        UserID = ListUserVariable.UserID,
                        IsSend = 1
                    };
                    if (btn_attachfile.Enabled != false)
                    {
                        if (lbl_fileatach.Text != null)//برسی اینکه این فایل از قبل وجود دارد یا نه
                        {

                            if (!db.NewRepository.NotChangeFileAtachNews(EditeNewID, Path.GetFileName(lbl_fileatach2.Text)))
                            {
                                ns.FileNews = FilesRead.GetReadFiles(lbl_fileatach2.Text);
                                ns.FileName = Path.GetFileName(lbl_fileatach2.Text);
                            }
                        }
                    }

                    if (EditeNewID == 0)
                    {
                        //Insert News
                        bool istrue = db.NewsRepository.Insert(ns);
                        if (istrue)
                        {
                            MessageBox.Show("عملیات با موفقیت انجام شد", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("در انجام عملیات مشکلی بوجود آمده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //edite News 
                        ns.NewID = EditeNewID;
                        bool istrue = db.NewsRepository.Update(ns);
                        if (istrue)
                        {
                            MessageBox.Show("عملیات با موفقیت انجام شد", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("عملیات با شکست مواجه شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    db.Save();
                    this.Close();
                }
            }
        }
    }
}
