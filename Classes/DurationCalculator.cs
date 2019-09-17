using System;

namespace TimeTraveler
{
    public partial class DurationCalculator
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Hours1 { get; set; }
        public int Minutes1 { get; set; }
        public int Seconds1 { get; set; }
        public int Hours2 { get; set; }
        public int Minutes2 { get; set; }
        public int Seconds2 { get; set; }

        public Duration DurationDays
        {
            get
            {
                var duration = new Duration();
                var date1Year = StartDate.Year;
                var date1Month = StartDate.Month;
                var date1Day = StartDate.Day;
                var hours1 = Hours1;
                var minutes1 = Minutes1;
                var seconds1 = Seconds1;

                var date2Year = EndDate.Year;
                var date2Month = EndDate.Month;
                var date2Day = EndDate.Day;
                var hours2 = Hours2;
                var minutes2 = Minutes2;
                var seconds2 = Seconds2;

                var firstDate = new DateTime(date1Year, date1Month, date1Day, hours1, minutes1, seconds1);
                var secondDate = new DateTime(date2Year, date2Month, date2Day, hours2, minutes2, seconds2);
                var timeSpan = secondDate.Subtract(firstDate);

                duration.Days = timeSpan.Days;
                duration.Hours = timeSpan.Hours;
                duration.Minutes = timeSpan.Minutes;
                duration.Seconds = timeSpan.Seconds;

                return duration;
            }
        }

        public double Hourly
        {
            get
            {
                var days = DurationDays.Days;
                var hours = DurationDays.Hours;
                var minutes = DurationDays.Minutes;
                var seconds = DurationDays.Seconds;
                var decimalDays = days * 24;
                var decimalHours = hours;
                var decimalMinutes = minutes / 60;
                var decimalSeconds = seconds / 3600;

                var time = decimalDays + decimalHours + decimalMinutes + decimalSeconds;

                return time;
            }
        }
    }
}