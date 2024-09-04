using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.DataLayer.Repository
{
    public interface ISendLetterRepository
    {
        int ContAllsendLatterUser(int UserID);
        int CountAllReciveLetters(int UserID);
        int GetCountLetterStartMonthEndMonth(DateTime Start, DateTime End, int UserID);
        int GetNewLetter(int UserIDReciver);
        bool UpdateisShowByUserID(int UserID);
    
    }
}
