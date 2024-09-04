using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.DataLayer.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUser();
        IEnumerable<User> GetUser(string paramert);
        bool GetUserNameByRepetitious(string UserName);
        bool onActivityByID(int ID);
        bool IsctivityByID(int ID);
        User GetUserByID(int ID);
        int GetCountUserActive();
        int GetCountUser();
        User GetUserLogin(string Username, string Password, int typeCodeUser);
        
    }
}
