using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.DataLayer.Repository
{
    public interface INotesRepository
    {
        IEnumerable<Note> GetAllSendLetters(int UserID, DateTime DateFrom, DateTime DateTo);
        IEnumerable<Note> GetAllSendLettersByFilters(int UserID, DateTime DateFrom, DateTime DateTo, string Subject, string Recivers);
        IEnumerable<SendNote> GetAllReviveNots(int UserID, DateTime DateFrom, DateTime DateTo);
        IEnumerable<SendNote> GetAllReviveNotsByFilters(int UserID, DateTime DateFrom, DateTime DateTo, string SubjectNots, string FullnameSenders);
    
    }
}
