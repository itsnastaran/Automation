using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.ViewModel.User
{
    public class ListUserVariable
    {
        public static int UserID { get; set; }
        public static string Userfirstname { get; set; }
        public static string UserFamily { get; set; }
        public static string Username { get; set; }
        public static int UserTypeCode { get; set; }
        private static string _fullname;
        public static string Fullname
        {
            get
            {
                if (_fullname == null)
                {
                    _fullname = Userfirstname + " " + UserFamily;
                }
                return _fullname;
            }
        }
    
    }
}
