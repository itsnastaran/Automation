using MyProjectt.DataLayer;
using MyProjectt.DataLayer.Context;
using MyProjectt.Utility.Convert;
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
    public partial class Frm_ShowRemmber : Form
    {
        public Frm_ShowRemmber()
        {
            InitializeComponent();
        }

        private void Frm_ShowRemmber_Load(object sender, EventArgs e)
        {
            this.Top = 109;
            this.Left = 0;
            datefrom.Value = DateTime.Now.AddDays(-3);
            BindRemmberInformation();
        }
        private void BindRemmberInformation(string str = "")
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                DateTime StartDate = datefrom.Value;
                DateTime EndDate = dateto.Value;
                IEnumerable<Remember> Result = db.RememberRepository.GetRemember(str, StartDate, EndDate);
                if (Result.Count() > 0)
                {
                    DG_ShowRemmber.Rows.Clear();
                    foreach (var item in Result)
                    {
                        DG_ShowRemmber.Rows.Add(item.RememberID, item.Subject, item.Text, item.CreateDate.Toshamsi(), item.RememberDate.Toshamsi(), item.IsRead==1?"خوانده شده":"خوانده نشده", item.IsRead);


                    }
                    foreach (DataGridViewRow item in DG_ShowRemmber.Rows)
                    {
                        if (Convert.ToInt32(item.Cells["status"].Value) == 1)
                        {
                            item.DefaultCellStyle.BackColor = Color.Red;
                        }
                        else
                        {
                            item.DefaultCellStyle.BackColor = Color.Green;
                        }
                    }
                }
                else
                {
                    DG_ShowRemmber.Rows.Clear();
                }
            }
        }

        private void Picserach_Click(object sender, EventArgs e)
        {
            BindRemmberInformation(txtsubject.Text.Trim());
        }

        private void DG_ShowRemmber_DoubleClick(object sender, EventArgs e)
        {
            
            using (UnitOfWord db = new UnitOfWord())
            {
                string RemmberText = DG_ShowRemmber.CurrentRow.Cells["TextRemmber"].Value.ToString();
                string RemmberSubject = DG_ShowRemmber.CurrentRow.Cells["Subject"].Value.ToString();
                int RemmberID = (int)DG_ShowRemmber.CurrentRow.Cells[0].Value;
                if (MessageBox.Show(RemmberText, RemmberSubject, MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    db.RememberRepository.UpdateRememberByID(RemmberID);
                }
                db.Save();
                BindRemmberInformation();
            }
        
        }
    }
}
