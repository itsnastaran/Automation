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

namespace MyProjectt.User
{
    public partial class Frm_ShowNews : Form
    {
        public Frm_ShowNews()
        {
            InitializeComponent();
        }

        private void Frm_ShowNews_Load(object sender, EventArgs e)
        {
            this.Top = 109;
            this.Left = 0;
            GetIonformation();
            datefrom.Value = DateTime.Now.AddDays(-30);
           
        }
        private void GetIonformation()
        {
            DateTime From = datefrom.Value;
            DateTime To = dateto.Value;
            using (UnitOfWord db = new UnitOfWord())
            {
                dataGridView1.Rows.Clear();
                var result = db.NewRepository.GetAllNewsFilterIsSend(From, To, txtsubject.Text, txttext.Text);
                if (result.Count() != 0)
                {
                    foreach (var item in result)
                    {
                        dataGridView1.Rows.Add(item.NewID, item.Subject, item.NewsText, item.SendDate.Value.Toshamsi() != null ? item.SendDate.Value.Toshamsi() : "", item.FileName != null ? item.FileName : "");
                    }
                }
                else
                {
                    dataGridView1.Rows.Clear();
                }
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                var result = dataGridView1["Fileatach", e.RowIndex].Value.ToString();
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Fileatach" && result != "")
                {
                    var SaveFile = new SaveFileDialog();
                    using (UnitOfWord db = new UnitOfWord())
                    {
                        int NewsID = (int)dataGridView1.CurrentRow.Cells[0].Value;
                        SaveFile.FileName = result;
                        if (SaveFile.ShowDialog() == DialogResult.OK)
                        {
                            byte[] FileAtch = db.NewRepository.GetDateByNewID(NewsID);
                            bool isacsess = SaveFiles.SaveFile(SaveFile.FileName, FileAtch);
                            if (isacsess)
                            {
                                MessageBox.Show("عملیات با موفقیت انجام شد", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("در انجام عملیات مشکلی بوجود آمده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void picsearch_Click(object sender, EventArgs e)
        {
            GetIonformation();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                int newID = (int)dataGridView1.CurrentRow.Cells[0].Value;
                if (newID != 0)
                {
                    Frm_DetailNews frm = new Frm_DetailNews();
                    frm.NewsID = newID;
                    frm.ShowDialog();
                }
            }

        }
    }
}
