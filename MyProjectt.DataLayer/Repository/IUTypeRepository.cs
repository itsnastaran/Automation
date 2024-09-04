using MyProjectt.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.DataLayer.Repository
{
    public interface IUTypeRepository
    {
        
            List<ListViewUserType> Get();
        
    }
}
