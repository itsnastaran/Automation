using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.DataLayer.Repository
{
    public interface ILetterRepository
    {
        IEnumerable<Letter> GetLattertypeDraft(string Paramert, int UserID);
        IEnumerable<SendLetter> GetAllLetterUserByUserID(int UserID, DateTime DateFrom, DateTime DateTo, string Parametr);
        IEnumerable<SendLetter> GetAllLetterUserByUserID2(int UserID, DateTime DateFrom, DateTime DateTo, string Parametr);
        IEnumerable<SendLetter> GetAllLetterUserByUserID(int UserID, string DateFrom, string DateTo, string Parametr);
        bool DeleteLetterDraft(int UserID, int LetterID);
        IEnumerable<SendLetter> Getletter(int userid,string paramert = null);
        List<Letter> GetLetterStartMonthEndMonth(DateTime St, DateTime En, int UserID);

        int GetAllLetterUser(int UserID);

        bool UpdateDrafttypeLatterByID(int LatterID);

        Letter GetLatterById(int LatterID, int UserID);

        string GetLatterNumberByID(int LatterID);
        IEnumerable<SendLetter> GetAllReadLatterByUserID(int UserID, DateTime Datefrom, DateTime Dateto, string Prametrs);
        IEnumerable<SendLetter> GetAllUnreadLatterByUserID(int UserID, DateTime Datefrom, DateTime Dateto, string Prametrs);
        IEnumerable<SendLetter> GetAllSendLatterByUserID2(int UserID, DateTime Datefrom, DateTime Dateto, string Prametrs);

        //IEnumerable<Vw_ReciveLetter> GetAllLetterUserByUserID(int UserID, string DateFrom, string DateTo, string Parametr);

        //IEnumerable<Vw_ReciveLetter> GetAllLetterUserByUserID(int UserID, DateTime DateFrom, DateTime DateTo);

        //IEnumerable<Vw_ReciveLetter> GetAllLetterUserByUserID(int UserID, DateTime DateFrom, DateTime DateTo, string parametr);
        IEnumerable<SendLetter> GetAllInstansLatterByUserID(int UserID, DateTime Datefrom, DateTime Dateto, string Prametrs);
        
         IEnumerable<SendLetter> GetAllSendLatterByUserID(int UserID, string Datefrom, string Dateto);
        IEnumerable<SendLetter> GetAllActionLatterByUserID(int UserID, DateTime Datefrom, DateTime Dateto, string Prametrs);
        IEnumerable<SendLetter> GetAllSendLatterByUserID(int UserID, string Datefrom, string Dateto, string Prametrs);
        bool GetisTrueAnswerDedline(int LatersID, DateTime Dt);
        DateTime GetAnswerDedline(int LatersID);
        bool CheckLatterIsArchive(int LAtterID);
        bool ArchiveLatters(int LettterID);
        int GetUserIDByLetterID(int LAtterID);
        IEnumerable<SendLetter> GetAllSendLetterFollow(int UserID, DateTime StratDate, DateTime EndDate, string Parametr);
    
    }
}
