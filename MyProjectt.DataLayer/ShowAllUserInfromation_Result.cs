using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.DataLayer
{
    public partial class ShowAllUserInfromation_Result
    {
        public int UserID { get; set; }
        public string UserFirstName { get; set; }
        public string UserFamily { get; set; }
        public string UserName { get; set; }
        public string PersonalCode { get; set; }
        public string UserEmail { get; set; }
        public string FarsiGender { get; set; }
        public string FarsiActivity { get; set; }
        public string UserTell { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string UserImage { get; set; }
        public string UserSignturess { get; set; }
        public System.DateTime CreateDate { get; set; }
        public byte Gender { get; set; }
        public byte Activity { get; set; }
        public string JobName { get; set; }
    }
}
