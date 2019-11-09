using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaboratory_02._04._19_
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(10, 50,20940);
            Test(5,50,10530);
            Test(20,50,35740);
            Console.ReadKey();
        }


        public static decimal CalculateWeeklySalary(decimal HoursPerWeek, decimal RatePerHour)
        {
            var WeeklySalary = HoursPerWeek * RatePerHour;
            return WeeklySalary;
        }
        public static void Test(decimal HoursPerWeek,decimal RatePerHour,decimal expectedResult)
        {
            var actual = CalculateYearlySalaryWithOvertimeAndTaxes(HoursPerWeek, RatePerHour);
            var result = "\tExpected:" + expectedResult + "\tActual:" + actual;

            if (actual == expectedResult)
                result = "PASSED" + result;
            else
                result = "FAILED" + result;
            Console.WriteLine(result);
        }
        public static decimal CalculateYearlySalary(decimal HoursPerWeek, decimal RatePerHour)
        {
            var YearlySalary = CalculateWeeklySalary(HoursPerWeek, RatePerHour) * 52;
            return YearlySalary;
        }
        public static decimal CalculateWeeklySalaryWithOvertime(decimal HoursPerWeek, decimal RatePerHour)
        {
            decimal WeeklySalaryWithOvertime = 0;
            if (HoursPerWeek > 40)
            {
                WeeklySalaryWithOvertime += CalculateWeeklySalary(40, RatePerHour);
                WeeklySalaryWithOvertime += CalculateWeeklySalary(HoursPerWeek - 40,RatePerHour*2);
            }
            else
            {
                WeeklySalaryWithOvertime = CalculateWeeklySalary(HoursPerWeek,RatePerHour);
            }
            return WeeklySalaryWithOvertime;
        }
        public static decimal CalculateYearlySalaryWithOvertime(decimal HoursPerWeek,decimal RatePerHour)
        {
            var YearlySalaryWithOvertime = CalculateWeeklySalaryWithOvertime(HoursPerWeek,RatePerHour) * 52;
            return YearlySalaryWithOvertime;
        }
        public static decimal CalculateYearlySalaryWithOvertimeAndTaxes(decimal HoursPerWeek,decimal RatePerHour)
        {
            decimal result;
            decimal YearlySalaryTaxes = 0;
            decimal RawSalary = CalculateYearlySalaryWithOvertime(HoursPerWeek,RatePerHour);
            if (RawSalary  <= 20000)
            {
                YearlySalaryTaxes = RawSalary * 0.19m;
                result = RawSalary - YearlySalaryTaxes;
                return result;
            }
            else if (RawSalary <= 30000)
            {
                YearlySalaryTaxes += 20000 * 0.19m;
                YearlySalaryTaxes += (RawSalary - 20000) * 0.21m;
                result = RawSalary - YearlySalaryTaxes;
                return result;
            }
            else
            {
                YearlySalaryTaxes += 20000 * 0.19m;
                YearlySalaryTaxes += 10000 * 0.21m;
                YearlySalaryTaxes += (RawSalary - 30000) * 0.28m;
                result = RawSalary - YearlySalaryTaxes;
                return result;
            }
        }
    }
}
