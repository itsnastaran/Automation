using MyProjectt.DataLayer.Context;
using MyProjectt.Utility.Convert;
using MyProjectt.ViewModel.Letters;
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
    public partial class Frm_showCirculationletter : Form
    {
        public string LetterNumber { get; set; }
        public string SendDateLeter { get; set; }
        public int LeeterID { get; set; }
        public Frm_showCirculationletter()
        {
            InitializeComponent();
        }

        private void Frm_showCirculationletter_Load(object sender, EventArgs e)
        {
            lbltitle.Text = $"وضعیت گردش نامه به شماره {LetterNumber} ارسالی در مورخه {SendDateLeter} است";
            BindInformationSendDateLetter();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BindInformationSendDateLetter()
        {
            List<ListViewFollowLetter> list = new List<ListViewFollowLetter>();
            using (UnitOfWord db = new UnitOfWord())
            {
                list = db.RefrenceLetterRepository.GetAllCirculationletter(LeeterID);
                if (list.Count != 0)
                {
                    foreach (var item in list)
                    {
                        lblmain.Text += $"نامه شما در تاریخ {item.DateRefrence.Toshamsi()} به {item.FullNameReciveLetter} توسط {item.FullNameSenderLetter} ارجاع داده شده است. توضیحات نامه : {item.DiscriptionRefrence}";
                        lblmain.Text += "\r\n";
                    }
                }
                else
                {
                    this.lblmain.ForeColor = Color.Red;
                    this.lblmain.Text = "هیچ گردشی برای این نامه ثبت نشده است";
                }
            }
        }
    }
}
