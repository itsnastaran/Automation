using MyProjectt.DataLayer.Context;
using MyProjectt.ViewModel.Admin;
using MyProjectt.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.Bissuns
{
    public static class Admin
    {
        public static ShowUserActive GetUserInformation()
        {
            ShowUserActive lstuser = new ShowUserActive();
            using (UnitOfWord db = new UnitOfWord())
            {
                lstuser.CountAllUser = db.UserRepository.GetCountUser();
                lstuser.CountAllUserActive = db.UserRepository.GetCountUserActive();
                lstuser.CountUserOnline = db.UserLog.CountUserOnline();
                lstuser.LastDatetimeLogin = db.UserLog.GetLastLoginAdmin(ListUserVariable.UserID);
            }

            return lstuser;
        }
    }
}

    
