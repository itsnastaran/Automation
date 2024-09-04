using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProjectt.DataLayer.Repository;
using MyProjectt.ViewModel.User;

namespace MyProjectt.DataLayer.Service
{
    public class USetJobRepository:IUSetJobRepository
    {
        projectmainEntities2 db;
        public USetJobRepository(projectmainEntities2 context)
        {
            db = context;
        }

        public bool DeleteUserJob(int ID, DateTime EndDate)
        {
            try
            {
                var result = db.UserSetJobs.Where(x => x.UserID == ID && x.Status == 1 && x.EndDateJob == null).SingleOrDefault();
                result.EndDateJob = EndDate;
                result.Status = 2;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<ListViewSendUserLetter> GetAllUserReciveLatterFilterByFillname(int DTjobLevel, int MyUserID, string Fullname)
        {
            var result = db.UserSetJobs.Where(x => x.Status == 1 && x.Job.DeterminaljobLevelid >= DTjobLevel - 1 && x.UserID != MyUserID && (x.User.UserFirstName+" "+x.User.UserFamily).Contains(Fullname)).Select(a => new ListViewSendUserLetter()
            {
                UserFullName = a.User.UserFirstName+" "+a.User.UserFamily,
                JobName = a.Job.JobName,
                ReciveUserID = a.UserID,
                DtJobLevel = (int)a.Job.DeterminaljobLevelid
            }).ToList();
            return result;
        }

        public IEnumerable<ListViewSendUserLetter> GetAllUserReciveLatter(int DTjobLevel, int MyUserID)
        {
            var result = db.UserSetJobs.Where(x => x.Status == 1 && x.Job.DeterminaljobLevelid >= DTjobLevel - 1 && x.UserID != MyUserID).Select(a => new ListViewSendUserLetter()
            {
                UserFullName = a.User.UserFirstName+" "+a.User.UserFamily,
                JobName = a.Job.JobName,
                ReciveUserID = a.UserID,
                DtJobLevel = (int)a.Job.DeterminaljobLevelid
            });
            return result;
        }

        public bool GetCheackHaveJobByJobID(int JobID)
        {
            try
            {
                return db.UserSetJobs.Any(x => x.JobID == JobID && x.EndDateJob == null && x.Status == 1);
            }
            catch
            {
                return false;
            }
        }

        public bool GetCheackSetjobUserByID(int ID)
        {
            try
            {
                return db.UserSetJobs.Any(x => x.UserID == ID && x.EndDateJob == null && x.Status == 1);
            }
            catch
            {
                return false;
            }
        }

        public int GetDtjobLevelIDByUserID(int userID)
        {
            int DtjobLevelID = (int)db.UserSetJobs.SingleOrDefault(x => x.UserID == userID && x.Status == 1).Job.DeterminaljobLevelid;
            return DtjobLevelID;
        }

        public string GetFullNameByJobID(int JobID)
        {
            return db.UserSetJobs.FirstOrDefault(x => x.JobID == JobID && x.EndDateJob == null && x.Status == 1).User.UserFamily;
        }

        public List<ListViewFullName> GetUserFullNameByID(int UserID)
        {
            return db.Users.Where(x => x.UserID == UserID).Select(x => new ListViewFullName()
            {
                Name = x.UserFirstName,
                Family = x.UserFamily
            }).ToList();
        }

        public IEnumerable<UserSetJob> GetUserJobByID(int ID)
        {
            return db.UserSetJobs.Where(x => x.UserID == ID).ToList();
        }

        public IEnumerable<ListViewSendUserLetter> GetAllUserReciveLatterFilterByFillname(int DTjobLevel, string Fullname, int UserIDCreateLetter)
        {
            var result = db.UserSetJobs.Where(x => x.Status == 1 && x.Job.DeterminaljobLevelid >= DTjobLevel - 1 && x.UserID != ListUserVariable.UserID && x.UserID != UserIDCreateLetter && (x.User.UserFirstName + " " + x.User.UserFamily).Contains(Fullname)).Select(a => new ListViewSendUserLetter()
            {
                UserFullName = a.User.UserFirstName + " " + a.User.UserFamily,
                JobName = a.Job.JobName,
                ReciveUserID = a.UserID,
                DtJobLevel = (int)a.Job.DeterminaljobLevelid
            }).ToList();
            return result;
        }
        public UserSetJob GetUserjobbyUserID(int ID)
        {
            return db.UserSetJobs.SingleOrDefault(x => x.UserID == ID && x.Status==1);

        }

    }
}
