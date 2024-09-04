using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.ViewModel.User
{
    public class GetCountLetter
    {
        private int _countletter;
        public int CountLetter
        {
            get => _countletter;
            set
            {
                if (value > 0)
                {
                    _countletter = value;
                }
                else
                {
                    _countletter = 0;
                }
            }
        }
    
    }
}
