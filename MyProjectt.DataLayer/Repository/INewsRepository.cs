using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.DataLayer.Repository
{
    public interface INewsRepository
    {
        IEnumerable<News> GetAll(DateTime DateFrom, DateTime DateEnd);
        bool NewsIsSend(int NewsID);
        bool UpdateNewsSend(int NewsID);
        byte[] GetDateByNewID(int NewsID);
        IEnumerable<News> GetAllByFilter(DateTime DateFrom, DateTime DateEnd, string Subject, string Text);
        News GetInformationByID(int NewsID);
        bool NotChangeFileAtachNews(int NewsID, string FileAtach);
        IEnumerable<News> GetAllNewsFilterIsSend(DateTime DateFrom, DateTime DateEnd, string Subject, string Text);
        News GetNewsInformationByID(int NewsID);
        int CountRecentNews();
    

    }
}
