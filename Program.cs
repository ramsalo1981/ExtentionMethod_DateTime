namespace CAExtentionsMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Datetime.Now
            DateTime dt = DateTime.Now;
            Console.WriteLine($"DateTime.Now: {dt}"); // yyyy-MM-dd hh:mm:ss
            Console.WriteLine("-----------------------");

            //New datetime()
            dt = new DateTime(2023, 11, 04, 12, 30, 00);
            Console.WriteLine($"DateTime: {dt}"); // yyyy-MM-dd hh:mm:ss
            Console.WriteLine("-----------------------");

            //TimeSpan
            DateTime dtt = DateTime.Now;
            Console.WriteLine($"DateTime.Now: {dtt}"); // yyyy-MM-dd hh:mm:ss
            TimeSpan ts = new TimeSpan(2,15,00);//Add 2h 15m 00s
            dtt = dtt.Add(ts);
            Console.WriteLine($"DateTime after adding timespan(2,15,00): {dtt}"); // yyyy-MM-dd hh:mm:ss
            Console.WriteLine("-----------------------");

            //Add days
            DateTime dtd = DateTime.Now;
            dtd = dtd.AddDays(4);
            Console.WriteLine($"DateTime + 4 Days: {dtd}"); // yyyy-MM-dd hh:mm:ss
            Console.WriteLine("-----------------------");

            //Datetimeoffset => date in utc (GMT)
            DateTimeOffset dts = DateTimeOffset.Now;
            Console.WriteLine($"DateTimeOffset.Now: {dts}"); // yyyy-MM-dd hh:mm:ss + - GMT
            Console.WriteLine("-----------------------");

            dts = DateTimeOffset.UtcNow;
            Console.WriteLine($"DateTimeOffset.UtcNow: {dts}"); // yyyy-MM-dd hh:mm:ss GMT
            Console.WriteLine("-----------------------");

            //check if year is leap (februari 29days) or not
            Console.WriteLine($"Is Leap Year: {DateTime.IsLeapYear(2020)}");
            Console.WriteLine("-----------------------");


            //----------------------(1)--------------------
            // using date time witout extention method
            DateTime dthw = DateTime.Now;
            var dth = DateTimeHelper.IsWeekend(dthw);
            Console.WriteLine($"Today is weekend {dthw.DayOfWeek} :  {dth}");
            Console.WriteLine("-----------------------");

            DateTime dthwo = DateTime.Now;
            var wd = DateTimeHelper.IsWorkDay(dthwo);
            Console.WriteLine($"Today is workday {dthwo.DayOfWeek} :  {wd}");
            Console.WriteLine("-----------------------");

            //----------------------(2)--------------------
            // using date time with extention method => see DateTimeExtentions Class
            // 1- Extention method must be static and inside static class
            // 2 parameter in extention method must start with this (this DateTime value)
            DateTime dthwe = DateTime.Now;
            
            Console.WriteLine($"Today is weekend {dthw.DayOfWeek} :  {dthwe.IsWeekend()}");
            Console.WriteLine("-----------------------");

            DateTime dthwoe = DateTime.Now;
            Console.WriteLine($"Today is workday {dthwo.DayOfWeek} :  {dthwoe.IsWorkDay()}");
            Console.WriteLine("-----------------------");


            Console.ReadKey();
        }
    }
}