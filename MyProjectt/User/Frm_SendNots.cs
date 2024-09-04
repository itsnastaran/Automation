using MyProjectt.DataLayer;
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
using MyProjectt.Utility.Convert;

namespace MyProjectt.User
{
    public partial class Frm_SendNots : Form
    {
        public Frm_SendNots()
        {
            InitializeComponent();
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {
            this.Top = 109;
            this.Left = 0;
            datefrom.Value = DateTime.Now.AddDays(-30);
            GetAllInformation();
        }
        private void GetAllInformation()
        {
            DateTime DTf = datefrom.Value;
            DateTime DTt = dateto.Value;
            using (UnitOfWord db = new UnitOfWord())
            {
               
                IEnumerable<Note> result = db.NotRepository.GetAllSendLetters(ListUserVariable.UserID, DTf, DTt);
                DG_SendNots.Rows.Clear();
                if (result.Count() != 0)
                {
                    foreach (var item in result)
                    {
                        DG_SendNots.Rows.Add(item.NoteID, item.SubjectNote, item.SubjectMatn, item.FullNameSender, item.CreateDateNod);
                    }
                }
                else
                {
                    DG_SendNots.Rows.Clear();
                }
            }
        }

        private void picsearch_Click(object sender, EventArgs e)
        {
            DateTime DTf = datefrom.Value;
            DateTime DTt = dateto.Value;
            using (UnitOfWord db = new UnitOfWord())
            {
               
                IEnumerable<Note> result = db.NotRepository.GetAllSendLettersByFilters(ListUserVariable.UserID, DTf, DTt, txtsubject.Text, txtreciver.Text);
                DG_SendNots.Rows.Clear();
                if (result.Count() != 0)
                {
                    foreach (var item in result)
                    {
                        DG_SendNots.Rows.Add(item.NoteID, item.SubjectNote, item.SubjectMatn, item.FullNameSender, item.CreateDateNod);
                    }
                }
                else
                {
                    DG_SendNots.Rows.Clear();
                }
            }
        }
    }
}
