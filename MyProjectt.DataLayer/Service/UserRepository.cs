using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProjectt.DataLayer.Repository;

namespace MyProjectt.DataLayer.Service
{
    public class UserRepository:IUserRepository
    {
        projectmainEntities2 db;
        public UserRepository(projectmainEntities2 Contect)
        {
            db = Contect;
        }

        public int GetCountUser()
        {
            try
            {
                return db.Users.Count();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int GetCountUserActive()
        {
            try
            {
                return db.Users.Count(x => x.Activity == 1);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public IEnumerable<User> GetUser()
        {
            return db.Users.ToList();
        }
        public IEnumerable<User> GetUser(string paramert = null)
        {
            if (paramert != null)
            {
                return db.Database.SqlQuery<User>("select * from [User] where 1=1 " + paramert).ToList();
            }
            else
            {
                return GetUser();
            }
        }
        public User GetUserByID(int ID)
        {
            return db.Users.SingleOrDefault(x => x.UserID == ID);

        }

        public User GetUserLogin(string Username, string Password, int typeCodeUser)
        {
            return db.Users.SingleOrDefault(x => x.UserName == Username && x.Password == Password && x.Activity == 1 && x.UserType.CodeType == typeCodeUser);
        }

        public bool GetUserNameByRepetitious(string UserName)
        {
            return db.Users.Any(x => x.UserName == UserName && x.Activity == 1);
        }
        public bool IsctivityByID(int ID)
        {

            try
            {
                var result = db.Users.Find(ID);
                result.Activity = 1;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool onActivityByID(int ID)
        {
            try
            {
                var result = db.Users.Find(ID);
                result.Activity = 2;
                return true;
            }
            catch
            {
                return false;
            }
        }

    
    }
}
