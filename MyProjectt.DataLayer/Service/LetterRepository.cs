using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProjectt.DataLayer.Repository;

namespace MyProjectt.DataLayer.Service
{
    public class LetterRepository:ILetterRepository
    {
        projectmainEntities2 db;
        public LetterRepository(projectmainEntities2 context)
        {
            db = context;
        }

        public bool ArchiveLatters(int LettterID)
        {
           
                try
                {
                    var result = db.Letters.SingleOrDefault(x => x.LetterID == LettterID);
                    result.BayganiType = 2;
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }

         }

        public bool CheckLatterIsArchive(int LAtterID)
        {
            try
            {
                return db.Letters.Any(x => x.LetterID == LAtterID && x.BayganiType == 2);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool DeleteLetterDraft(int UserID, int LetterID)
        {
            try
            {
                var result = db.Letters.FirstOrDefault(x => x.UserID == UserID && x.LetterID == LetterID && x.DraftType == 1);
                db.Letters.Remove(result);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public int GetAllLetterUser(int UserID)
        {
            return db.Letters.Where(x => x.UserID == UserID).Count();
        }

        public DateTime GetAnswerDedline(int LatersID)
        {

            return (DateTime)db.Letters.SingleOrDefault(x => x.LetterID == LatersID).AnswerDeadline;

        }

        public bool GetisTrueAnswerDedline(int LatersID, DateTime Dt)
        {
            try
            {
                var result = db.Letters.Any(x => x.LetterID == LatersID && x.LetterResponse == 1 && x.AnswerDeadline >= Dt);
                return result;
            }
            catch (Exception msg)
            {
                throw new Exception("Error is ..." + msg);

            }

        }

        public Letter GetLatterById(int LatterID, int UserID)
        {
            return db.Letters.Where(x => x.LetterID == LatterID && x.UserID == UserID).SingleOrDefault();

        }

        public string GetLatterNumberByID(int LatterID)
        {
            return db.Letters.SingleOrDefault(x => x.LetterID == LatterID).LetterNumber;

        }

        public IEnumerable<Letter> GetLattertypeDraft(string Paramert, int UserID)
        {
            return db.Database.SqlQuery<Letter>("Select * from Letter where 1=1 and Drafttype=1 and UserID=" + UserID + "" + Paramert).ToList();

        }

        public List<Letter> GetLetterStartMonthEndMonth(DateTime St, DateTime En, int UserID)
        {
            return db.Letters.Where(x => x.UserID == UserID && x.CreateDate >= St && x.CreateDate <= En).ToList();

        }

        public int GetUserIDByLetterID(int LAtterID)
        {
            return db.Letters.SingleOrDefault(x => x.LetterID == LAtterID).UserID;
        }
        public bool UpdateDrafttypeLatterByID(int LatterID)
        {
            try
            {
                var result = db.Letters.Find(LatterID);
                result.DraftType = 2;
                result.SendDate = DateTime.Now;
                return true;
            }
            catch
            {

                return false;
            }
        }

        public IEnumerable<SendLetter> GetAllSendLatterByUserID(int UserID, string Datefrom, string Dateto)
        {
            var result = db.Database.SqlQuery<SendLetter>("select * from SendLetter where 1=1 and Letter.DraftType =2 and UserID_SendLetters=" + UserID + "and SendDateLetter between" + "'" + Datefrom + "'" + " and " + "'" + Dateto + "'" + "").ToList();
            return result;
        }
        public IEnumerable<SendLetter> GetAllSendLatterByUserID(int UserID, DateTime Datefrom, DateTime Dateto, string Prametrs)
        {
            var result = db.Database.SqlQuery<SendLetter>("select * from SendLetter where 1=1 and Letter.DraftType =2 and UserID_SendLetters=" + UserID + "and SendDateLetter between" + "'" + Datefrom + "'" + " and " + "'" + Dateto + "'" + "" + Prametrs).ToList();
            return result;
        }
        public IEnumerable<SendLetter> GetAllSendLatterByUserID(int UserID, string Datefrom, string Dateto, string Prametrs)
        {
            var result = db.Database.SqlQuery<SendLetter>("select * from SendLetter where 1=1 and Letter.DraftType =2 and UserID_SendLetters=" + UserID + "and SendDateLetter between" + "'" + Datefrom + "'" + " and " + "'" + Dateto + "'" + "" + Prametrs).ToList();
            return result;
        }
        public IEnumerable<SendLetter> GetAllSendLatterByUserID2(int UserID, DateTime Datefrom, DateTime Dateto, string Prametrs)
        {
            var result = db.SendLetters.Where(x => x.UserID_SendLetters==UserID && x.Letter.DraftType==2 && x.SendDateLetter>=Datefrom && x.SendDateLetter<=Dateto);
            return result;
        }
        public IEnumerable<SendLetter> GetAllActionLatterByUserID(int UserID, DateTime Datefrom, DateTime Dateto, string Prametrs)
        {
            var result = db.SendLetters.Where(x => x.UserID == UserID && x.Letter.LetterTypeAction==2 && x.Letter.DraftType == 2 && x.SendDateLetter >= Datefrom && x.SendDateLetter <= Dateto);
            return result;
        }
        public IEnumerable<SendLetter> GetAllInstansLatterByUserID(int UserID, DateTime Datefrom, DateTime Dateto, string Prametrs)
        {
            var result = db.SendLetters.Where(x => x.UserID == UserID && x.Letter.SecurityType == 2 && x.Letter.DraftType == 2 && x.SendDateLetter >= Datefrom && x.SendDateLetter <= Dateto);
            return result;
        }
        public IEnumerable<SendLetter> GetAllReadLatterByUserID(int UserID, DateTime Datefrom, DateTime Dateto, string Prametrs)
        {
            var result = db.SendLetters.Where(x => x.UserID == UserID && x.IsRead == 2 && x.Letter.DraftType == 2 && x.SendDateLetter >= Datefrom && x.SendDateLetter <= Dateto);
            return result;
        }
        public IEnumerable<SendLetter> GetAllUnreadLatterByUserID(int UserID, DateTime Datefrom, DateTime Dateto, string Prametrs)
        {
            var result = db.SendLetters.Where(x => x.UserID == UserID && x.IsRead == 1 && x.Letter.DraftType == 2 && x.SendDateLetter >= Datefrom && x.SendDateLetter <= Dateto);
            return result;
        }
        public IEnumerable<SendLetter> GetAllLetterUserByUserID(int UserID, DateTime DateFrom, DateTime DateTo, string Parametr)
        {
            var result = db.SendLetters.Where(x => x.UserID == UserID && x.Letter.DraftType == 2 && x.SendDateLetter >= DateFrom && x.SendDateLetter <= DateTo);
            return result;
        }
        public IEnumerable<SendLetter> GetAllLetterUserByUserID2(int UserID, string DateFrom, string DateTo, string Parametr)
        {
            var result = db.Database.SqlQuery<SendLetter>("select * from SendLetter INNER JOIN Letter ON 1=1 and Letter.DraftType =2 and SendLetter.UserID=" + UserID + " and SendLetter.SendDateLetter between " + "'" + DateFrom + "'" + "and " + "'" + DateTo + "'" + Parametr).ToList();
            return result;
        }
        public IEnumerable<SendLetter> GetAllLetterUserByUserID2(int UserID, DateTime DateFrom, DateTime DateTo, string Parametr)
        {
            var result = db.Database.SqlQuery<SendLetter>("select * from SendLetter INNER JOIN Letter ON 1=1 and Letter.DraftType =2 and SendLetter.UserID=" + UserID + " and SendLetter.SendDateLetter between " + "'" + DateFrom + "'" + "and " + "'" + DateTo + "'" + Parametr).ToList();
            
            return result;
        }
        public IEnumerable<SendLetter> GetAllLetterUserByUserID(int UserID, string DateFrom, string DateTo, string Parametr)
        {
            var result = db.Database.SqlQuery<SendLetter>("select * from SendLetter where 1=1 and UserID=" + UserID + " and SendDateLetter between " + "'" + DateFrom + "'" + "and " + "'" + DateTo + "'" + Parametr).ToList();
            return result;
        }
        public IEnumerable<SendLetter> GetAllSendLetterFollow(int UserID, DateTime StratDate, DateTime EndDate, string Parametr)
        {
            var result = db.SendLetters.Where(x => x.UserID_SendLetters == UserID && x.Letter.DraftType == 2 && x.Letter.LetterFollow==1 && x.SendDateLetter >= StratDate && x.SendDateLetter <= EndDate);
            return result;
        }
        public IEnumerable<SendLetter> Getletter(int userid,string paramert = null)
        {
            if (paramert != null)
            {
                return db.Database.SqlQuery<SendLetter>("select * from [SendLetter] where 1=1 and UserID=" + userid+ paramert).ToList();
            }
            else
            {
                return Getletter(userid);
            }
        }

    }

}


    

