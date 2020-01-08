using System;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
           // DateTime now = new DateTime(2023, 3, 2);                            //тестовая дата невисокосный год

             Console.WriteLine("Enter birthday number");
             int dd = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter birthday munth");
             int mm = Convert.ToInt32(Console.ReadLine());

            if (dd == 29 && mm == 2)
            {
                BirthdayFeb29(now);
            }
            else
            {
                TimeSpan interval = DaysCalc(now.Year, mm, dd, now);
                Console.WriteLine($"\nNumber of days until the next birthday: {interval.Days + 1}");
            }
             Console.ReadLine();

         }
        

         static void BirthdayFeb29(DateTime now) //для рожденного 29 февраля
         {             
            DateTime feb28 = new DateTime(now.Year, 2, 28);
            int feb28DayOfYear = feb28.DayOfYear;
            int nowDayOfYear = now.DayOfYear;
            DateTime march1Current = new DateTime(now.Year, 3, 1);            
            DateTime march1Next = new DateTime(now.Year, 3, 1).AddYears(1);
            TimeSpan interval;


            if (nowDayOfYear < (feb28DayOfYear+1) && System.DateTime.DaysInMonth(now.Year, 2) == 29) //текущий год с 29 февраля, сегодня до 29 февраля
            {
                DateTime targetDate = new DateTime(now.Year, 2, 29);
                interval = targetDate - now;
                Console.WriteLine($"\nNumber of days until the next birthday: {interval.Days + 1}");
            }
            else if (nowDayOfYear >= (feb28DayOfYear+1) && System.DateTime.DaysInMonth(now.Year, 2) == 29) //текущий год с 29 февраля, сегодня после 29 февраля
            {
                interval = march1Next - now;
                Console.WriteLine($"\nNumber of days until the next birthday: {interval.Days + 1}");
            }
            else if (System.DateTime.DaysInMonth(now.Year, 2) != 29 && System.DateTime.DaysInMonth(now.Year + 1, 2) != 29) //текущий год без 29 февраля, следующий год без 29 февраля
            {
                interval = DaysCalc(now.Year, 1, 3, now);
                Console.WriteLine($"\nNumber of days until the next birthday: {interval.Days + 1}");
            }
            else if (System.DateTime.DaysInMonth(now.Year, 2) != 29 && now > march1Current) //текущий год без 29 февраля, следующий с 29 февраля, сегодня после 1 марта
            {
                interval = DaysCalc((now.Year + 1), 2, 29, now);
                Console.WriteLine($"\nNumber of days until the next birthday: {interval.Days}");
            }
            else Console.WriteLine("Error");
        }

        static TimeSpan DaysCalc (int curYy, int mm, int dd, DateTime now)
        {
            DateTime targetDate = new DateTime(curYy, mm, dd);
            TimeSpan interval = targetDate - now;
            if (interval.Days <= 0)
            {
                DateTime nextYear = targetDate.AddYears(1);
                interval = nextYear - now;
                return interval;
            }
            else return interval;
        }
        
    }
    
}
