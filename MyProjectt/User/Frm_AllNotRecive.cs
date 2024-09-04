using MyProjectt.DataLayer;
using MyProjectt.DataLayer.Context;
using MyProjectt.ViewModel.User;
using System;
using MyProjectt.Utility.Convert;
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
    public partial class Frm_AllNotRecive : Form
    {
        public Frm_AllNotRecive()
        {
            InitializeComponent();
        }

        private void Frm_AllNotRecive_Load(object sender, EventArgs e)
        {
            this.Top = 109;
            this.Left = 0;
            datefrom.Value = DateTime.Now.AddDays(-30);
            GetInformationNots();
        }
        private void GetInformationNots()
        {
            DateTime DTf = datefrom.Value;
            DateTime DTt = dateto.Value;
            using (UnitOfWord db = new UnitOfWord())
            {
                IEnumerable<SendNote> result = db.NotRepository.GetAllReviveNots(ListUserVariable.UserID, DTf, DTt);
                DG_SendNots.Rows.Clear();
                if (result.Count() != 0)
                {
                    foreach (var item in result)
                    {
                        DG_SendNots.Rows.Add(item.NoteID, item.Note.SubjectNote, item.Note.SubjectMatn, item.Note.FullNameSender, item.SendDate);
                    }
                }
                else
                {
                    DG_SendNots.Rows.Clear();
                }
            }
        }
        private void GetInformationByFilters(string Senders, string Subject)
        {
            DateTime DTf = datefrom.Value;
            DateTime DTt = dateto.Value;
            using (UnitOfWord db = new UnitOfWord())
            {
                IEnumerable<SendNote> result = db.NotRepository.GetAllReviveNotsByFilters(ListUserVariable.UserID, DTf, DTt, Subject, Senders);
                DG_SendNots.Rows.Clear();
                if (result.Count() != 0)
                {
                    foreach (var item in result)
                    {
                        DG_SendNots.Rows.Add(item.NoteID, item.Note.SubjectNote, item.Note.SubjectMatn, item.FullName, item.SendDate);
                    }
                }
                else
                {
                    DG_SendNots.Rows.Clear();
                }
            }
        }

        private void Pic_search_Click(object sender, EventArgs e)
        {
            GetInformationByFilters(txtsender.Text, txtsubject.Text);
        }
    }
}
