using System;

namespace Students
{
    class Workers : Humans
    {
        public double WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public Workers(string Nume,string Prenume, double WeekSalary, int HoursDay):base("NumeAng","PrenumeAng")
        {
            base.LastName = Nume;
            base.FirstName = Prenume;
            this.WeekSalary = WeekSalary;
            this.WorkHoursPerDay = HoursDay;
        }

        public double MoneyPerHour(double WeekSalary, int WorkHours)
        {
            return Math.Round(WeekSalary / WorkHours,2);
        }
    }
}
