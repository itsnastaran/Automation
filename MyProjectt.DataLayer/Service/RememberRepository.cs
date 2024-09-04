using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProjectt.DataLayer.Repository;
using MyProjectt.ViewModel.User;

namespace MyProjectt.DataLayer.Service
{
    public class RememberRepository:IRememberRepository
    {
        projectmainEntities2 db;
        public RememberRepository(projectmainEntities2 contect)
        {
            db = contect;
        }

        public IEnumerable<Remember> GetRemember()
        {
            return db.Remembers.ToList();
        }

        public IEnumerable<Remember> GetRemember(DateTime Start, DateTime End)
        {
            return db.Remembers.Where(x => x.RememberDate >= Start && x.RememberDate <= End && x.UserID == ListUserVariable.UserID).ToList();
        }

        public IEnumerable<Remember> GetRemember(string paramert, DateTime Start, DateTime End)
        {
            return db.Remembers.Where(x => x.Subject.Contains(paramert) && x.RememberDate >= Start && x.RememberDate <= End && x.UserID == ListUserVariable.UserID).ToList();
        }

        public bool UpdateRememberByID(int ID)
        {
            try
            {
                var result = db.Remembers.Find(ID);
                result.IsRead = 2;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
