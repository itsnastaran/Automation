using MyProjectt.DataLayer.Context;
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

namespace MyProjectt.AdminPanel
{
    public partial class Frm_showNews : Form
    {
        public Frm_showNews()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_showNews_Load(object sender, EventArgs e)
        {
            this.datefrom.Value = DateTime.Now.AddDays(-30);
            GetAllInformation();
        }
        private void GetAllInformation()
        {
            DateTime From = datefrom.Value;
            DateTime To = dateto.Value;
            using (UnitOfWord db = new UnitOfWord())
            {
                dataGridViewX1.Rows.Clear();
                var result = db.NewRepository.GetAll(From, To);
                if (result.Count() != 0)
                {
                    foreach (var item in result)
                    {
                        dataGridViewX1.Rows.Add(item.NewID, item.Subject, item.NewsText, item.CreateDate.Value.Toshamsi(),
                       item.SendDate != null ? item.SendDate.Value.Toshamsi() : null, item.IsSend==1?"ارسال نشده":"ارسال شده", item.FileName);
                    }
                }
                else
                {
                    dataGridViewX1.Rows.Clear();
                }
            }
        }
       

        private void btn_sendnews_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewX1.CurrentRow.Selected)
            {
                using (UnitOfWord db = new UnitOfWord())
                {
                    int NewsID = (int)dataGridViewX1.CurrentRow.Cells[0].Value;
                    bool istrue = db.NewRepository.NewsIsSend(NewsID);
                    if (istrue)
                    {
                        bool isupdate = db.NewRepository.UpdateNewsSend(NewsID);
                        if (!isupdate)
                        {
                            MessageBox.Show("عملیات با شکست مواجه شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        MessageBox.Show("عملیات با موفقیت انجام شد", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("این خبر از قبل ارسال شده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    db.Save();
                    GetAllInformation();
                }

            }
            else
            {
                MessageBox.Show("برای ارسال خبر باید حتما سطری را انتخاب کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        

        private void btn_editnews_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.CurrentRow.Selected)
            {
                int NewID = (int)dataGridViewX1.CurrentRow.Cells[0].Value;
                Frm_CreateNews frm = new Frm_CreateNews();
                frm.EditeNewID = NewID;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    GetAllInformation();
                }
            }
            else
            {
                MessageBox.Show("برای ویرایش خبر باید ان را انتخاب کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picsearch_Click(object sender, EventArgs e)
        {
            DateTime From = datefrom.Value;
            DateTime To = dateto.Value;
            using (UnitOfWord db = new UnitOfWord())
            {
                dataGridViewX1.Rows.Clear();
                var result = db.NewRepository.GetAllByFilter(From, To, txtsubject.Text, txttext.Text);
                if (result.Count() != 0)
                {
                    foreach (var item in result)
                    {
                        dataGridViewX1.Rows.Add(item.NewID, item.Subject, item.NewsText, item.CreateDate.Value.Toshamsi(), item.SendDate != null ? item.SendDate.Value.Toshamsi() : "", item.FileName);
                    }
                }
                else
                {
                    dataGridViewX1.Rows.Clear();
                }
            }
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                var result = dataGridViewX1["Attachfile", e.RowIndex].Value.ToString();
                if (dataGridViewX1.Columns[e.ColumnIndex].Name == "Attachfile" && result != "")
                {
                    
                    var SaveFile = new SaveFileDialog();
                    using (UnitOfWord db = new UnitOfWord())
                    {
                        int NewsID = (int)dataGridViewX1.CurrentRow.Cells[0].Value;
                        SaveFile.FileName = result;
                        if (SaveFile.ShowDialog() == DialogResult.OK)
                        {
                            byte[] filedate = db.NewRepository.GetDateByNewID(NewsID);
                            bool isacsess = SaveFiles.SaveFile(SaveFile.FileName, filedate);
                            if (isacsess)
                            {
                                MessageBox.Show("عملیات با موفقیت انجام شد", "اطاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("در انجام انجام عملیات مشکلی بوجود آمده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}

    
