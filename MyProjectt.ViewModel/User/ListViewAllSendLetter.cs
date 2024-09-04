using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.ViewModel.User
{
    public class ListViewAllSendLetter
    {
        private int _sendcountlatter;
        private int _countrecivelatters;
        public int SendcountLatter
        {
            get => _sendcountlatter;
            set
            {
                if (value >= 1)
                {
                    _sendcountlatter = value;
                }
                else
                {
                    _sendcountlatter = 0;
                }
            }
        }
        public int CountReciveLetter
        {
            get
            {
                return _countrecivelatters;
            }
            set
            {
                if (value != 0)
                {
                    _countrecivelatters = value;
                }
                else
                {
                    _countrecivelatters = 0;
                }
            }
        }
    
    }
}
