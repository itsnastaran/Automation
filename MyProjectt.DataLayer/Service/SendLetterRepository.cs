using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProjectt.DataLayer.Repository;

namespace MyProjectt.DataLayer.Service
{
    public class SendLetterRepository:ISendLetterRepository
    {
        projectmainEntities2 db;
        public SendLetterRepository(projectmainEntities2 contect)
        {
            this.db = contect;
        }
        public int ContAllsendLatterUser(int UserID)
        {
            return db.SendLetters.Count(x => x.UserID_SendLetters == UserID);
        }

        public int CountAllReciveLetters(int UserID)
        {
            return db.SendLetters.Count(x => x.UserID == UserID);
        }

        public int GetCountLetterStartMonthEndMonth(DateTime Start, DateTime End, int UserID)
        {
            return db.SendLetters.Count(x => x.UserID == UserID || x.UserID_SendLetters == UserID && x.SendDateLetter >= Start && x.SendDateLetter < End);
        }

        public int GetNewLetter(int UserIDReciver)
        {
            try
            {
                return db.SendLetters.Count(x => x.UserID == UserIDReciver && x.IsShow == 1);
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public bool UpdateisShowByUserID(int UserID)
        {
            try
            {
                db.UpdatesendletterisshowbyUserID(UserID);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    
    }
}
