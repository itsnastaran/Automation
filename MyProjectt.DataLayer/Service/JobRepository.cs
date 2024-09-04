using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProjectt.DataLayer.Repository;

namespace MyProjectt.DataLayer.Service
{
    public class JobRepository:IJobRepository
    {
        projectmainEntities2 db;
        public JobRepository(projectmainEntities2 Context)
        {
            db = Context;
        }

        public int GetcountJobLevelIDEqalID(int JobID)
        {
            return db.Jobs.Count(x => x.Job_LevelId == JobID);
        }

        public Job GetDeterminanJobByID(int ID)
        {
            return db.Jobs.Find(ID);
        }
        public Vw_jobss GetDeterminanJobByID2(int ID)
        {
            return db.Vw_jobss.Find(ID);
        }

        public IEnumerable<Vw_jobss> GetVw(int Tag)
        {
            return db.Vw_jobss.Where(x => x.Job_LevelId == Tag).ToList();
        }

        public bool UpdatejobByID(int ID, string JobText)
        {
            try
            {
                var result = db.Jobs.Find(ID);
                result.JobName = JobText;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
