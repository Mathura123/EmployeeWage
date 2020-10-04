using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    public class EmpWageBuilder
    {
        const int IS_FULL_TIME = 2;
        const int IS_PART_TIME = 1;
        private int noOfCompanies=0;
        private List<CompanyEmpWage> comEmpWageList = new List<CompanyEmpWage>();
        public static void ComputeEmpWage(CompanyEmpWage company)
        {
            int numOfWorkingDays = company.noOfWorkingDays;
            int maxHrsInMonth = company.maxHrsInMonth;
            string companyName = company.companyName;
            int empRatePerHOur = company.empRatePerHour;
            //Variables
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            Console.WriteLine("Company : " + companyName);
            while (totalEmpHrs <= maxHrsInMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                //Computation
                int empHrs = EmpHrs();
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#: " + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHOur;
            company.SetTotalEmpWage(totalEmpWage);
            Console.WriteLine("Total Emp Wage is " + totalEmpWage + " for Company "+ company.companyName + "\n");
        }

        public CompanyEmpWage AddCompanyEmpwage(string companyName, int workDays, int maxHrs, int empRate)
        {
            CompanyEmpWage objComEmpWage = new CompanyEmpWage(companyName, workDays, maxHrs, empRate);
            comEmpWageList.Add(objComEmpWage);
            return objComEmpWage;
        }
        public static int EmpHrs()
        {
            int empHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            return empHrs;
        }

    }
}
