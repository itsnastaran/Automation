using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProjectt.DataLayer.Repository;

namespace MyProjectt.DataLayer.Service
{
    public class UserLogRepository:IULogRepository
    {
        projectmainEntities2 db;
        public UserLogRepository(projectmainEntities2 contect)
        {
            db = contect;
        }

        public int CountUserOnline()
        {
            var result = db.UserLogs.Where(x => x.EnterDateTime.Value.Day == DateTime.Now.Day && x.ExitDateTime == null).ToList();
            var res2 = 0;
            foreach (var item in result)
            {
                res2= db.Users.Where(x => x.UserID == item.UserID).Count();
            }
            return res2;
        }
        public DateTime GetLastLoginAdmin(int UserID)
        {
            var result = db.UserLogs.Where(x => x.UserID == UserID).OrderByDescending(x => x.UserID).FirstOrDefault().EnterDateTime;
            return (DateTime)result;
        }
        public IEnumerable<UserLog> Get(DateTime EnterLogin)
        {
            return db.UserLogs.Where(x => x.EnterDateTime >= EnterLogin).ToList();
        }

        public IEnumerable<UserLog> Get(string paramert)
        {
            return db.Database.SqlQuery<UserLog>("select * from UserLog where 1=1" + paramert);

        }
        public bool SetDateTimeExiteUser(DateTime DataTimeExite, int UserID)
        {
            try
            {
                var result = db.UserLogs.Where(x => x.UserID == UserID).OrderByDescending(x => x.EnterDateTime).FirstOrDefault();
                result.ExitDateTime = DateTime.Now;
                result.SomHors = (float)(DateTime.Now - result.EnterDateTime).Value.TotalMinutes;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public IEnumerable<UserLog> GetAllByFilter(DateTime DateFrom, DateTime DateEnd, string FullName, string IP, string Computername)
        {
            return db.UserLogs.Where(x => x.EnterDateTime >= DateFrom && x.EnterDateTime <= DateEnd && x.User.UserName.Contains(FullName) && x.IPAddress.Contains(IP) && x.ComputerName.Contains(Computername)).ToList();
        }

    }
}
