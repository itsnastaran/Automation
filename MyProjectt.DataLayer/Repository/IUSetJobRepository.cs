using MyProjectt.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.DataLayer.Repository
{
    public interface IUSetJobRepository
    {
        List<ListViewFullName> GetUserFullNameByID(int UserID);
        bool GetCheackSetjobUserByID(int ID);
        bool DeleteUserJob(int ID, DateTime EndDate);
        bool GetCheackHaveJobByJobID(int JobID);
        IEnumerable<UserSetJob> GetUserJobByID(int ID);
        string GetFullNameByJobID(int JobID);
        UserSetJob GetUserjobbyUserID(int ID);
        int GetDtjobLevelIDByUserID(int userID);
        IEnumerable<ListViewSendUserLetter> GetAllUserReciveLatter(int DTjobLevel, int MyUserID);
        IEnumerable<ListViewSendUserLetter> GetAllUserReciveLatterFilterByFillname(int DTjobLevel, int MyUserID, string Fullname);
        
        IEnumerable<ListViewSendUserLetter> GetAllUserReciveLatterFilterByFillname(int DTjobLevel, string Fullname, int UserIDCreateLetter);

    }
}
