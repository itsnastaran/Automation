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
using System.Windows.Forms;

namespace MyProjectt.User
{
    public partial class Frm_AddEditRemember : Form
    {
        public Frm_AddEditRemember()
        {
            InitializeComponent();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                DateTime RemeberDate;
                RemeberDate = persiandate.Value;
                Remember Rm = new Remember()
                {
                    Subject = txtsubject.Text,
                    Text = txttext.Text,
                    CreateDate = DateTime.Now,
                    IsRead = 1,
                    RememberDate = RemeberDate,
                    UserID = ListUserVariable.UserID
                };
                bool issave = db.RememberGRepository.Insert(Rm);
                if (issave)
                {
                    MessageBox.Show("اطلاعات با موفقیت ثبت شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("در ثبت اطلاعات مشکلی بوجود آمده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.Save();
            }
        }
        private void Frm_AddEditRemember_Load(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.Toshamsi();
            this.Top = 109;
            this.Left = 0;
        }
    }
}
