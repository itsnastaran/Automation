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
using System.Windows.Forms;

namespace MyProjectt.User
{
    public partial class Frm_ShownewMesseage : Form
    {
        public Frm_ShownewMesseage()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                bool istrue = db.SendLatter.UpdateisShowByUserID(ListUserVariable.UserID);
                if (istrue)
                {
                    db.Save();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("درارتباط با سرور مشکلی بوجود آمده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
