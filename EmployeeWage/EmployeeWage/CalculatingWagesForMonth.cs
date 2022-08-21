using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//UC - 5
//Calculating Wages for a Month
//Assume 20 Working Day per Month



namespace Program
{
    public class CalculatingWagesForMonth
    {
        public const float EmpWagePerHour = 20;
        internal void CheckEmpPresentAbsent() { }
        public const int FullTime_Working_Hours_PerDay = 8;
        public const int PartTime_Working_Hours_PerDay = 4;
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int IS_ABSENT = 0;
        public const int Num_WorkingDays_Per_Month = 20;
        public float EmpMonthlyWage = 0;
        float EmpDailyWage = 0;

        public int IsEmployeePresent()
        {
            return new Random().Next(0, 3);
        }

        public void CalculateEmpWage()
        {
            int DayNumber = 1;
            int EmpWorkingHours = 0;
            while (DayNumber <= Num_WorkingDays_Per_Month)
            {

                switch (IsEmployeePresent())
                {
                    case IS_ABSENT:
                        EmpWorkingHours = 0;
                        break;

                    case IS_PART_TIME:
                        EmpWorkingHours = PartTime_Working_Hours_PerDay;
                        break;

                    case IS_FULL_TIME:
                        EmpWorkingHours = FullTime_Working_Hours_PerDay;
                        break;
                }
                EmpDailyWage = EmpWorkingHours * EmpWagePerHour;

                EmpMonthlyWage += EmpDailyWage;
                DayNumber++;
            }
            Console.WriteLine("Employee Monthly Wage = {0}", EmpMonthlyWage);
        }
    }
}