using MyProjectt.Bissuns;
using MyProjectt.DataLayer;
using MyProjectt.Utility.Convert;
using MyProjectt.ViewModel.News;
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
    public partial class Frm_DetailNews : Form
    {
        public int NewsID { get; set; }
        public Frm_DetailNews()
        {
            InitializeComponent();
        }

        private void Frm_DetailNews_Load(object sender, EventArgs e)
        {
            GetAllInformation();
        }
        private void GetAllInformation()
        {
            ViewNews result = ShowNews.Get(NewsID);
            lbl_senddate.Text = result.SendDate.Toshamsi();
            lbl_subject.Text = result.Subject;
            lbl_text.Text = result.Text;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
