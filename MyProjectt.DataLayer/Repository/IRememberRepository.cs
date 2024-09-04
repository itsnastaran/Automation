using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.DataLayer.Repository
{
    public interface IRememberRepository
    {
        IEnumerable<Remember> GetRemember();
        IEnumerable<Remember> GetRemember(DateTime Start, DateTime End);
        IEnumerable<Remember> GetRemember(string paramert, DateTime Start, DateTime End);
        bool UpdateRememberByID(int UserID);
    }
}
