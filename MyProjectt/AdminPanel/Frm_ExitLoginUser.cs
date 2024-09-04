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
using MyProjectt.ViewModel.User;

namespace MyProjectt.AdminPanel
{
    public partial class Frm_ExitLoginUser : Form
    {
        public Frm_ExitLoginUser()
        {
            InitializeComponent();
        }

        private void Frm_ExitLoginUser_Load(object sender, EventArgs e)
        {
            datefrom.Value = DateTime.Now.AddDays(-10);
            BindInformation();
        }
        private void BindInformation()
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                IEnumerable<UserLog> list = db.UserLog.Get(datefrom.Value);
               
                dataGridViewX1.Rows.Clear();
                if (list.Count() > 0)
                {
                    foreach (var item in list)
                    {
                        
                        dataGridViewX1.Rows.Add(item.LoginID,item.User.UserFirstName+" "+item.User.UserFamily , item.ComputerName,
                        item.IPAddress, item.EnterDateTime.Value.ToFullshasi(), item.ExitDateTime == null ? "" : item.ExitDateTime.Value.ToFullshasi());
                    }
                }
                else
                {
                    dataGridViewX1.Rows.Clear();
                }
            };
        }
        
        private void Time_from_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_search_Click(object sender, EventArgs e)
        {
            DateTime StartDate = datefrom.Value;
            DateTime EndDate = dateto.Value;
            using (UnitOfWord db = new UnitOfWord())
            {
                
                dataGridViewX1.Rows.Clear();
                var result = db.UserLog.GetAllByFilter(StartDate,EndDate,txt_fullname.Text,txt_IP.Text,txt_computername.Text);
                
                if (result.Count()!=0)
                {
                    foreach (var item in result)
                    {
                     
                        dataGridViewX1.Rows.Add(item.LoginID, item.User.UserFirstName + " " + item.User.UserFamily, item.ComputerName, item.IPAddress, item.EnterDateTime.Value.ToFullshasi(), item.ExitDateTime == null ? "اشکال در سیستم" : item.ExitDateTime.Value.ToFullshasi());
                    }
                }
                else
                {
                    dataGridViewX1.Rows.Clear();
                }
            }
        }
    }
}
