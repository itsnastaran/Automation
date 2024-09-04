using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProjectt.DataLayer.Repository;

namespace MyProjectt.DataLayer.Service
{
    public class AttachFileRepository:IAttachFileRepository
    {
        projectmainEntities2 db;
        public AttachFileRepository(projectmainEntities2 contect)
        {
            db = contect;
        }

        public bool checkFileAccess(int LatterID, string Filename)
        {
            try
            {
                return db.AttachFiles.Any(x => x.LetterID == LatterID && x.FileName == Filename);
            }
            catch
            {

                return false;
            }
        }

        public bool DeleteAtachFileByLaterID(int LaterID)
        {
            try
            {
                var result = db.AttachFiles.SingleOrDefault(x => x.LetterID == LaterID);
                db.AttachFiles.Remove(result);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public AttachFile GetAtchFileByID(int ID)
        {
            return db.AttachFiles.Find(ID);
        }

        public byte[] GetFileDateByLatterID(int LetterID)
        {
            byte[] result = db.AttachFiles.SingleOrDefault(x => x.LetterID == LetterID).FileDate;
            return result;
        }

        public bool GetFileisAcess(int LatersID)
        {
            try
            {
                return db.AttachFiles.Any(c => c.LetterID.Equals(LatersID));
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public string GetFilenameByLatterID(int LatterID)
        {
            return db.AttachFiles.FirstOrDefault(x => x.LetterID == LatterID).FileName;
        }
    
    }
}
