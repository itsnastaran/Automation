using MyProjectt.DataLayer.Context;
using MyProjectt.Utility.Convert;
using MyProjectt.ViewModel.Letters;
using MyProjectt.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.Bissuns
{
    public class ULetter
    {
        public static GetCountLetter GetCountUserRepository()
        {
            GetCountLetter list = new GetCountLetter(); 
            using (UnitOfWord db = new UnitOfWord())
            {
                DateTime StartDate = new DateTime(DateTime.Now.Year,DateTime.Now.Month, 01);
                DateTime EndDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);
                list.CountLetter = db.SendLatter.GetCountLetterStartMonthEndMonth(StartDate, EndDate, ListUserVariable.UserID);
            }
            return list;
        }
        public static GetCountLetter GetAllLetteruser()
        {
            GetCountLetter list = new GetCountLetter();
            using (UnitOfWord db = new UnitOfWord())
            {
                var result = db.LetterRepository.GetAllLetterUser(ListUserVariable.UserID);
                if (result >= 1)
                {
                    list.CountLetter = result;
                }
                else
                {
                    list.CountLetter = 0;
                }
            }
            return list;
        }
        public static ListViewAllSendLetter GetAllSendLaterUser()
        {
            ListViewAllSendLetter lst = new ListViewAllSendLetter();
            using (UnitOfWord db = new UnitOfWord())
            {
                lst.SendcountLatter = db.SendLatter.ContAllsendLatterUser(ListUserVariable.UserID);
                lst.CountReciveLetter = db.SendLatter.CountAllReciveLetters(ListUserVariable.UserID);
            }
            return lst;
        }

        
        public static ListViewNumberLetter GetLatternumber()
        {
            ListViewNumberLetter lst = new ListViewNumberLetter();
            var DateYaerTo = DateTime.Now.Toshamsi();
            string DateYaer = DateYaerTo.Substring(0, 4);
            using (UnitOfWord db = new UnitOfWord())
            {
                int Dtjlevel = db.USetJobRepository.GetDtjobLevelIDByUserID(ListUserVariable.UserID);
                if (Dtjlevel >= 1)
                {
                    lst.LatterNumber = DateYaer + " / " + Dtjlevel; 
                }
                return lst;
            }
        }

    }
}
