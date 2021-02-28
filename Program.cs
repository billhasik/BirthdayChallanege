using System;

namespace BirthdayChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            var birthday = new DateTime(2021, 01, 30);
            Console.WriteLine($"My birthday is {birthday.ToString()}. That means that today I am this old:");

            // var yearsOld = Math.Floor(-birthday.Subtract(DateTime.Today).TotalDays / 365);
            // var numberOfDaysMinusYears = Math.Floor(-birthday.Subtract(DateTime.Today).TotalDays % 365);
            // var monthsOld = Math.Floor(numberOfDaysMinusYears / 30);
            // var daysOld = Math.Floor(numberOfDaysMinusYears % 30);


            var dateToday = DateTime.Now;
            var yearsOld = dateToday.Year - birthday.Year;

            if (dateToday.Month < birthday.Month)
            {
                yearsOld -= 1;
            } else if (dateToday.Month == birthday.Month)
            {
                if (dateToday.Day < birthday.Day)
                {
                    yearsOld -= 1;
                }
            }

            var monthsOld = dateToday.Month - birthday.Month;
            if (monthsOld < 0)
            {
                monthsOld = 12 + monthsOld;
            }

            if (dateToday.AddDays(-22).Day < birthday.Day)
            {

            }
            var daysOld = dateToday.Day;


            Console.WriteLine($"years: {yearsOld}\n" +
                              $"months: {monthsOld}\n" +
                              $"days: {daysOld}");


            Console.WriteLine($"{dateToday.AddDays(-22)}");
        }
    }
}
