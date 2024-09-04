using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.ViewModel.Admin
{
    public class ShowUserActive
    {
        public int CountAllUserActive { get; set; }
        public int CountAllUser { get; set; }
        public int CountUserOnline { get; set; }
        public DateTime LastDatetimeLogin { get; set; }
    
    }
}
