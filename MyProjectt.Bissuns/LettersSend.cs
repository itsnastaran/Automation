using MyProjectt.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.Bissuns
{
    public static class LettersSend
    {
        public static int GetIsTureNewLetter(int UserID)
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                var result = db.SendLatter.GetNewLetter(UserID);
                if (result != 0)
                {
                    return result;
                }
                else
                {
                    return 0;
                }
            }
        }
        public static int GetIsTruNewsLetterRefrence(int UserID)
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                var result = db.RefrenceLetterRepository.GetNewLetterRefrence(UserID);
                if (result != 0)
                {
                    return result;
                }
                else
                {
                    return 0;
                }
            }
        }
        public static int GetCountRecentNews()
        {
            using (UnitOfWord db = new UnitOfWord())
            {
                var result = db.NewRepository.CountRecentNews();
                if (result != 0)
                {
                    return result;
                }
                else
                {
                    return 0;
                }
            }
        }

    
    }
}
