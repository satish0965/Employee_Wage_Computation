using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//UC - 2
//Calculate Daily Employee Wage 
//Assume Wage per hour is 20
//Assume Full Day hour is 8

namespace Program
{
    internal class DailyEmpWage
    {
        int IS_EmpPresent = 1;
        int Wage_Per_Hour = 20;
        int FullDay_Hour = 8;
        int DailyWage = 0;
        public void CheckDailyEmpWg()
        {
            Random ChechEmp = new Random();
            int value = ChechEmp.Next(0, 2);
            if (value == IS_EmpPresent)
            {
                DailyWage = FullDay_Hour * Wage_Per_Hour;

                Console.WriteLine("Employee Present and DailyWage = {0}", DailyWage);

            }
            else
            {
                Console.WriteLine("Employee Absent");

            }

        }

    }
}
