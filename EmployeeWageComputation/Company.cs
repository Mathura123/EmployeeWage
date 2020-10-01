using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    public class Company
    {
        public string companyName;
        public int noOfWorkingDays;
        public int maxHrsInMonth;
        public int empRatePerHour;
        public Company(string name, int workDays, int hrs, int rate)
        {
            companyName = name;
            noOfWorkingDays = workDays;
            maxHrsInMonth = hrs;
            empRatePerHour = rate;
        }
    }
}
