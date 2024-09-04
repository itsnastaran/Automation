using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.Utility.Convert
{
    public class ConvertDate
    {
        private int _day;
        private int _month;
        private int _yaer;
        List<int> listmonth = new List<int>() { 0, 31, 31, 31, 31, 31, 31, 30, 30, 0, 30, 30, 29 };
        public int Year
        {
            get => _day;
            set
            {
                if (value >= 0000 && value <= 9999)
                {
                    _yaer = value;
                }
                else
                {
                    _yaer = 0000;
                }
            }
        }
        public int Month
        {
            get => _month;
            set
            {
                if (value >= 1 && value <= 12)
                {
                    _month = value;
                }
                else
                {
                    _month = 0;
                }
            }
        }
        public int Day

        {
            get => _day;
            set
            {
                if (value >= 1 && value <= listmonth[Month])
                {
                    _day = value;
                }
                else
                {
                    _day = 0;
                }
            }
        }

        public static DateTime ConvertShamsiToMiladi(int Year, int month, int Day)
        {
            PersianCalendar pc = new PersianCalendar();
            DateTime dt = new DateTime(Year, month, Day, pc);
            return dt;
        }
        public static string GetShamsiToMiladiShortDate(DateTime dt)
        {
            DateTime date = new DateTime();
            date = dt;
            return date.ToShortDateString().ToString();
        }
    

    }
}
