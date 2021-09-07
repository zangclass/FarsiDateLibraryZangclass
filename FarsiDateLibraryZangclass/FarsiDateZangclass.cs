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
        public static string Now()
        {
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(DateTime.Now)}/{pc.GetMonth(DateTime.Now)}" +
                $"/{pc.GetDayOfWeek(DateTime.Now)} {DateTime.Now.ToLongTimeString()}";
        }
    }

}
