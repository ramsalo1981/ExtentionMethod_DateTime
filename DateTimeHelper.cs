using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAExtentionsMethod
{
    public static class DateTimeHelper
    {
        public static bool IsWeekend(DateTime value)
        {
            return value.DayOfWeek == DayOfWeek.Saturday || value.DayOfWeek == DayOfWeek.Sunday;
        }

        public static bool IsWorkDay(DateTime value)
        {
            return !(IsWeekend(value));
        } 
    }
}
