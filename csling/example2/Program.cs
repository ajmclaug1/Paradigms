using System;

namespace csling;



    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2002, 8, 9);

            int daysTillEndOfMonth = date.DaysTillEndOfMonth();

            Console.WriteLine(daysTillEndOfMonth);
        }
    }

    public static class DateUtilities
    {
        public static int DaysTillEndOfMonth(this DateTime date)
        {
            return DateTime.DaysInMonth(date.Year, date.Month) - date.Day;

        }
    }


