using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProjectt.DataLayer.Repository;

namespace MyProjectt.DataLayer.Service
{
    public class SendNoteRepository:ISendNoteRepository
    {
        projectmainEntities2 db;
        public SendNoteRepository(projectmainEntities2 contect)
        {
            db = contect;
        }
    }
}

    
