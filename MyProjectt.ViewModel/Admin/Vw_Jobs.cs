using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.ViewModel.Admin
{
    public class Vw_Jobs
    {
        public int JobID { get; set; }
        public string JobName { get; set; }
        public Nullable<int> job_LevelID { get; set; }
        public Nullable<int> DeterminaljobLevelID { get; set; }
        public Nullable<int> countchild { get; set; }
    }
}
