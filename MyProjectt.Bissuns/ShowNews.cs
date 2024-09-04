using MyProjectt.DataLayer;
using MyProjectt.DataLayer.Context;
using MyProjectt.ViewModel.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.Bissuns
{
    public class ShowNews
    {
        public static ViewNews Get(int NewID)
        {
            ViewNews ViewNewResult;
            using (UnitOfWord db = new UnitOfWord())
            {
                var result = db.NewRepository.GetInformationByID(NewID);
                ViewNewResult = new ViewNews()
                {
                    Text = result.NewsText,
                    SendDate = (DateTime)result.SendDate,
                    Subject = result.Subject
                };
            }
            return ViewNewResult;
        }
    }
}

    
