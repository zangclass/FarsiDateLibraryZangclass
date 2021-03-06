using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarsiDateLibraryZangclass
{
    public static class FarsiDateZangclass
    {
        public static int Year { get; set; }
        public static int Month { get; set; }
        public static int Day { get; set; }
        public static bool Kabiseh { get; set; }
        /// <summary>
        /// تاریخ شمسی همان لحظه در سیستم را به شما باز میگرداند
        /// </summary>
        /// <returns>خروجی تاریخ شمسی است</returns>
        public static string Now()
        {
            PersianCalendar pc = new PersianCalendar();
            var str = $"{pc.GetYear(DateTime.Now)}/{pc.GetMonth(DateTime.Now)}" +
                $"/{pc.GetDayOfWeek(DateTime.Now)} {DateTime.Now.ToLongTimeString()}";
            return str;
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// </summary>
        /// <param name="date">ورود تاریخ میلادی</param>
        /// <returns>خروجی تاریخ شمسی</returns>
        public static string ConvertDateTo(DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(date)}/{pc.GetMonth(date)}" +
                $"/{pc.GetDayOfWeek(date)} {date.ToLongTimeString()}";
        }

        /// <summary>
        /// تبدیل تاریخ شمسی به تاریخ میلادی
        /// </summary>
        /// <param name="yaer">سال ورودی</param>
        /// <param name="month">ماه ورودی</param>
        /// <param name="day">روز ورودی</param>
        /// <returns>خروجی ماه میلادی به صورت رشته می باشد</returns>
        public static string ConvertDateTo(int yaer, int month, int day)
        {
            PersianCalendar p = new PersianCalendar();
            string str = Convert.ToString(p.ToDateTime(yaer, month, day, 0, 0, 0, 0), CultureInfo.InvariantCulture);
            return str.Substring(0, 10);
        }

        /// <summary>
        /// محاسبه اینکه سال مورد نظر کبیسه است یا نه
        /// </summary>
        /// <param name="yaer">سال ورودی</param>
        /// <returns>خروجی بولین است و اگر مقدار true باشد یعنی سال کبیسه میباشد.</returns>
        public static bool CalcKabiseh(int yaer)
        {
            int j = yaer % 33;
            if (j == 1 || j == 5 || j == 9 || j == 13 || j == 17 || j == 22 || j == 26 || j == 30)
            {
                Kabiseh = true;
            }
            else
            {
                Kabiseh = false;
            }
            return Kabiseh;
        }

        /// <summary>
        /// اسم ماه را به این تابع میدهیم و تاریخ را برای اول ماه تنظیم میکنه
        /// </summary>
        /// <param name="month">ورودی اینامی از اسم ماه</param>
        public static void SelectFirstDayMonth(MonthFarsi month)
        {
            switch (month)
            {
                case MonthFarsi.Farvardin:
                    Month = 1;
                    Day = 1;
                    break;
                case MonthFarsi.Ordibehesht:
                    Month = 2;
                    Day = 1;
                    break;
                case MonthFarsi.Khordad:
                    Month = 3;
                    Day = 1;
                    break;
                case MonthFarsi.Tir:
                    Month = 4;
                    Day = 1;
                    break;
                case MonthFarsi.Mordad:
                    Month = 5;
                    Day = 1;
                    break;
                case MonthFarsi.Shahrivar:
                    Month = 6;
                    Day = 1;
                    break;
                case MonthFarsi.Mehr:
                    Month = 7;
                    Day = 1;
                    break;
                case MonthFarsi.Aban:
                    Month = 8;
                    Day = 1;
                    break;
                case MonthFarsi.Azar:
                    Month = 9;
                    Day = 1;
                    break;
                case MonthFarsi.Dey:
                    Month = 10;
                    Day = 1;
                    break;
                case MonthFarsi.Bahman:
                    Month = 11;
                    Day = 1;
                    break;
                case MonthFarsi.Esfand:
                    Month = 12;
                    Day = 1;
                    break;
            }
        }
        /// <summary>
        /// اسم ماه را به این تابع میدهیم و تاریخ را برای اول ماه تنظیم میکنه
        /// </summary>
        /// <param name="month">ورودی اینامی از اسم ماه</param>
        public static void SelectLastDayMonth(MonthFarsi month)
        {
            switch (month)
            {
                case MonthFarsi.Farvardin:
                    Month = 1;
                    Day = 31;
                    break;
                case MonthFarsi.Ordibehesht:
                    Month = 2;
                    Day = 31;
                    break;
                case MonthFarsi.Khordad:
                    Month = 3;
                    Day = 31;
                    break;
                case MonthFarsi.Tir:
                    Month = 4;
                    Day = 31;
                    break;
                case MonthFarsi.Mordad:
                    Month = 5;
                    Day = 31;
                    break;
                case MonthFarsi.Shahrivar:
                    Month = 6;
                    Day = 31;
                    break;
                case MonthFarsi.Mehr:
                    Month = 7;
                    Day = 30;
                    break;
                case MonthFarsi.Aban:
                    Month = 8;
                    Day = 30;
                    break;
                case MonthFarsi.Azar:
                    Month = 9;
                    Day = 30;
                    break;
                case MonthFarsi.Dey:
                    Month = 10;
                    Day = 30;
                    break;
                case MonthFarsi.Bahman:
                    Month = 11;
                    Day = 30;
                    break;
                case MonthFarsi.Esfand:
                    Month = 12;
                    Day = Kabiseh == true ? 30 : 29;
                    break;
            }

        }

    }
}
