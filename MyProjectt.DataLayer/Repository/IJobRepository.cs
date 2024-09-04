using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.DataLayer.Repository
{
    public interface IJobRepository
    {
        IEnumerable<Vw_jobss> GetVw(int Tag);
        Job GetDeterminanJobByID(int ID);
        bool UpdatejobByID(int ID, string JobText);
        int GetcountJobLevelIDEqalID(int JobID);
        Vw_jobss GetDeterminanJobByID2(int ID);
    }
}
