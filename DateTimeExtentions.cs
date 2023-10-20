using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAExtentionsMethod
{
    public static class DateTimeExtentions
    {
        // 1- Extention method must be static and inside static class
        // 2 parameter in extention method must start with this (this DateTime value)
        public static bool IsWeekend(this DateTime value)
        {
            return value.DayOfWeek == DayOfWeek.Saturday || value.DayOfWeek == DayOfWeek.Sunday;
        }

        public static bool IsWorkDay(this DateTime value)
        {
            return !(IsWeekend(value));
        }
    }
}
