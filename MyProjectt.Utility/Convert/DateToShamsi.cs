using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MyProjectt.Utility.Convert
{
    public static class DateToShamsi
    {
        public static string Toshamsi(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(value) + "/" + pc.GetMonth(value).ToString("00") + "/" + pc.GetDayOfMonth(value).ToString("00");
        }
        public static DateTime ToMiladi(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, new System.Globalization.PersianCalendar());
        }
        public static string ToTimeShmsi(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetHour(value).ToString("00") + " : " + pc.GetMinute(value).ToString("00") + " : " + pc.GetSecond(value).ToString("00");
        }
        public static string ToFullshasi(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            string Date = pc.GetYear(value) + "/" + pc.GetMonth(value).ToString("00") + "/" + pc.GetDayOfMonth(value).ToString("00");
            
            string Time = pc.GetSecond(value).ToString("00") + " : " + pc.GetMinute(value).ToString("00") + " : " + pc.GetHour(value).ToString("00");

            return Date + " - " + Time;

        }
    }
}
