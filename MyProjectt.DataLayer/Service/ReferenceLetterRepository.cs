using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProjectt.DataLayer.Repository;
using MyProjectt.ViewModel.User;
using MyProjectt.ViewModel.Letters;

namespace MyProjectt.DataLayer.Service
{
    public class ReferenceLetterRepository:IReferenceLetterRepository
    {
        projectmainEntities2 db;
        public ReferenceLetterRepository(projectmainEntities2 contect)
        {
            db = contect;
        }

        public bool CheckRefrenceLetter(int LetterID, int UserReciveID, int UserRefrenceID)
        {
            try
            {
                return db.ReferenceLetters.Any(x => x.LetterID == LetterID && x.UserIDReciveID == UserReciveID && x.UserIDReference == UserRefrenceID);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<ListViewUserCreateLetter> Get()
        {
            return db.Users.Select(x => new ListViewUserCreateLetter()
            {
                Fullname = x.UserFirstName + " " + x.UserFamily,
                UserID = x.UserID
            }).ToList();
        }

        public List<ListViewFollowLetter> GetAllCirculationletter(int LetterID)
        {
            return db.ReferenceLetters.Where(x => x.LetterID == LetterID).OrderByDescending(x => x.LevelNumbers).Select(x => new ListViewFollowLetter()
            {
                DateRefrence = (DateTime)x.ReferenceDate,
                DiscriptionRefrence = x.Description,
                FullNameReciveLetter = x.FullNameRecive,
                FullNameSenderLetter = x.FullNameReference
            }).ToList();
        }

        public IEnumerable<ReferenceLetter> GetAllLetterRefrence(int UserID, DateTime start, DateTime End, string Parametr)
        {
            var result = db.ReferenceLetters.Where(x => x.UserIDReciveID == UserID && x.ReferenceDate >= start && x.ReferenceDate <= End);
            return result;
        }
        public int GetCountLevelNumbers(int LetterID)
        {
            try
            {
                var result = db.ReferenceLetters.OrderBy(x => x.LevelNumbers).FirstOrDefault(x => x.LetterID == LetterID).LevelNumbers;
                return (int)result;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int GetNewLetterRefrence(int UserID)
        {
            try
            {
                return db.ReferenceLetters.Count(x => x.UserIDReciveID == UserID && x.IsShow == 1);
            }
            catch (Exception e)
            {
                throw new Exception("Error is The System" + e.Message);
            }
        }

        public IEnumerable<ReferenceLetter> GetSendrefrenceLetter(int UserID, DateTime start, DateTime End, string Parametr)
        {
            var result = db.ReferenceLetters.Where(x => x.UserIDReference == UserID && x.ReferenceDate >= start && x.ReferenceDate <= End);
            return result;
        
        }

        public bool UpdateLetterrefrenceByUserID(int UserID)
        {
            try
            {
                db.UpdateRefremceLetterisShowByUserID(UserID);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    
    }
}
