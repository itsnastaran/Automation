using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProjectt.DataLayer.Repository;

namespace MyProjectt.DataLayer.Service
{
    public class NotesRepository:INotesRepository
    {
        projectmainEntities2 db;
        public NotesRepository(projectmainEntities2 contect)
        {
            db = contect;
        }

        public IEnumerable<SendNote> GetAllReviveNots(int UserID, DateTime DateFrom, DateTime DateTo)
        {
            var result = db.SendNotes.Where(x => x.UserID_Recive == UserID && x.SendDate >= DateFrom && x.SendDate <= DateTo);
            return result;
        }

        public IEnumerable<SendNote> GetAllReviveNotsByFilters(int UserID, DateTime DateFrom, DateTime DateTo, string SubjectNots, string FullnameSenders)
        {
            var result = db.SendNotes.Where(x => x.UserID_Recive == UserID && x.SendDate >= DateFrom && x.SendDate <= DateTo && x.FullName.Contains(FullnameSenders) && x.Note.SubjectNote.Contains(SubjectNots));
            return result;
        }

        public IEnumerable<Note> GetAllSendLetters(int UserID, DateTime DateFrom, DateTime DateTo)
        {
            var result = db.Notes.Where(x => x.UserID_Sender == UserID && x.CreateDateNod >= DateFrom && x.CreateDateNod <= DateTo);
            return result;
        }

        public IEnumerable<Note> GetAllSendLettersByFilters(int UserID, DateTime DateFrom, DateTime DateTo, string Subject, string Recivers)
        {
            var result = db.Notes.Where(x => x.UserID_Sender == UserID && x.CreateDateNod >= DateFrom && x.CreateDateNod <= DateTo && x.FullNameSender.Contains(Recivers) && x.SubjectNote.Contains(Subject));
            return result;
        }

    }
}
