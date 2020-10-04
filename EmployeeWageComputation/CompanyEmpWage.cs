using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    public interface IComputeEmpWage
    {
        public void AddCompanyEmpWage(string companyName, int workDays, int maxHrs, int empRate);
        public void ComputeEmpWage();
    }
    public class CompanyEmpWage
    {
        public string companyName;
        public int noOfWorkingDays;
        public int maxHrsInMonth;
        public int empRatePerHour;
        public int totalEmpWage;
        public CompanyEmpWage(string companyName, int noOfWorkingDays, int maxHrsInMonth, int empRatePerHour)
        {
            this.companyName = companyName;
            this.noOfWorkingDays = noOfWorkingDays;
            this.maxHrsInMonth = maxHrsInMonth;
            this.empRatePerHour = empRatePerHour;
        }
        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

    }
}
