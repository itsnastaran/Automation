using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.ViewModel.User
{
    public class ListViewSendUserLetter
    {
        private int _reciveuserid;
        private string _fullname;
        private string _jobname;
        private int _dtjoblevel;
        public int ReciveUserID
        {
            get => _reciveuserid;
            set
            {
                if (value != 0)
                {
                    _reciveuserid = value;
                }
                else
                {
                    _reciveuserid = 0;
                }

            }
        }
        public string UserFullName
        {
            get => _fullname;
            set
            {
                if (value != null)
                {
                    _fullname = value;
                }
                else
                {
                    _fullname = "";
                }
            }
        }
        public string JobName
        {
            get => _jobname;
            set
            {
                if (value != null)
                {
                    _jobname = value;
                }
                else
                {
                    _jobname = "";
                }
            }
        }
        public int DtJobLevel
        {
            get => _dtjoblevel;
            set
            {
                if (value != 0)
                {
                    _dtjoblevel = value;
                }
                else
                {
                    _dtjoblevel = 0;
                }
            }
        }
    
    }
}
