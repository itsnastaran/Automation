using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.DataLayer.Repository
{
    public interface IAttachFileRepository
    {
        AttachFile GetAtchFileByID(int ID);
        bool DeleteAtachFileByLaterID(int LaterID);
        string GetFilenameByLatterID(int LatterID);
        bool checkFileAccess(int LatterID, string Filename);
        byte[] GetFileDateByLatterID(int LetterID);
        bool GetFileisAcess(int LatersID);
    
    }
}
