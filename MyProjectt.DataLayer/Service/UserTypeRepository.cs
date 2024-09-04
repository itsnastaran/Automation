using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProjectt.DataLayer.Repository;
using MyProjectt.ViewModel.User;

namespace MyProjectt.DataLayer.Service
{
    public class UserTypeRepository:IUTypeRepository
    {
        projectmainEntities2 db;
        public UserTypeRepository(projectmainEntities2 contect)
        {
            db = contect;
        }
        public List<ListViewUserType> Get()
        {
            return db.UserTypes.Select(x => new ListViewUserType()
            {
                UserTypeCode = x.CodeType.Value,
                UsertypeID = x.UserTypeID,
                UserTypeName = x.TypeName
            }).ToList();
        }
    }
}
