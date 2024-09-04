using MyProjectt.ViewModel.Letters;
using MyProjectt.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.DataLayer.Repository
{
    public interface IReferenceLetterRepository
    {
        int GetCountLevelNumbers(int LetterID);
        IEnumerable<ReferenceLetter> GetAllLetterRefrence(int UserID, DateTime start, DateTime End, string Parametr);
        List<ListViewUserCreateLetter> Get();
        IEnumerable<ReferenceLetter> GetSendrefrenceLetter(int UserID, DateTime start, DateTime End, string Parametr);
        bool CheckRefrenceLetter(int LetterID, int UserReciveID, int UserRefrenceID);
        List<ListViewFollowLetter> GetAllCirculationletter(int LetterID);
        int GetNewLetterRefrence(int UserID);
        bool UpdateLetterrefrenceByUserID(int UserID);
    
    }
}
