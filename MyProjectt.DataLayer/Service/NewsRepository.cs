using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProjectt.DataLayer.Repository;

namespace MyProjectt.DataLayer.Service
{
    public class NewsRepository:INewsRepository
    {
        projectmainEntities2 db;
        public NewsRepository(projectmainEntities2 contect)
        {
            this.db = contect;
        }

        public int CountRecentNews()
        {
            try
            {
                return db.News.Count(x => x.SendDate.Value.Year.Equals(DateTime.Now.Year) && x.SendDate.Value.Day.Equals(DateTime.Now.Day));
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public IEnumerable<News> GetAll(DateTime DateFrom, DateTime DateEnd)
        {
            return db.News.Where(x => x.CreateDate >= DateFrom && x.CreateDate <= DateEnd).ToList();
        }

        public IEnumerable<News> GetAllByFilter(DateTime DateFrom, DateTime DateEnd, string Subject, string Text)
        {
            return db.News.Where(x => x.CreateDate >= DateFrom && x.CreateDate <= DateEnd && x.Subject.Contains(Subject) && x.NewsText.Contains(Text)).ToList();
        }

        public IEnumerable<News> GetAllNewsFilterIsSend(DateTime DateFrom, DateTime DateEnd, string Subject, string Text)
        {
            return db.News.Where(x => x.IsSend == 2 && x.CreateDate >= DateFrom && x.CreateDate <= DateEnd && x.Subject.Contains(Subject) && x.NewsText.Contains(Text)).ToList();
        }

        public byte[] GetDateByNewID(int NewsID)
        {
            return db.News.SingleOrDefault(x => x.NewID == NewsID).FileNews;
        }

        public News GetInformationByID(int NewsID)
        {
            return db.News.SingleOrDefault(x => x.NewID == NewsID);

        }

        public News GetNewsInformationByID(int NewsID)
        {
            return db.News.SingleOrDefault(x => x.NewID == NewsID);
        }

        public bool NewsIsSend(int NewsID)
        {
            try
            {
                return db.News.Any(x => x.NewID == NewsID && x.IsSend == 1);
            }
            catch
            {
                return false;
            }
        }

        public bool NotChangeFileAtachNews(int NewsID, string FileAtach)
        {
            try
            {
                var result = db.News.Any(x => x.NewID == NewsID && x.FileName == FileAtach);
                return result;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateNewsSend(int NewsID)
        {
            try
            {
                var result = db.News.Where(x => x.NewID == NewsID).SingleOrDefault();
                result.IsSend = 2;
                result.SendDate = DateTime.Now;
                return true;
            }
            catch
            {
                return false;
            }
        }
    
    }
}
