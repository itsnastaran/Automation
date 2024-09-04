using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.DataLayer.Repository
{
    public interface IULogRepository
    {
        bool SetDateTimeExiteUser(DateTime DataTimeExite, int UserID);
        IEnumerable<UserLog> Get(DateTime EnterLogin);
        IEnumerable<UserLog> Get(string paramert);
        int CountUserOnline();
        DateTime GetLastLoginAdmin(int UserID);
        IEnumerable<UserLog> GetAllByFilter(DateTime DateFrom, DateTime DateEnd, string FullName, string IP, string Computername);


    }
}
