using System;
using System.Security.Cryptography;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation in Master Branch\n");
            Company company1 = new Company("Capgemini", 25, 100,1500);
            Company company2 = new Company("TCS", 25, 120, 1200);
            EmployeeWageComputation.EmpWage.ComputeEmpWage(company1);
            EmployeeWageComputation.EmpWage.ComputeEmpWage(company2);
        }
    }
    public class EmpWage
    {
        const int IS_FULL_TIME = 2;
        const int IS_PART_TIME = 1;
        public static void ComputeEmpWage(Company company)
        {
            int numOfWorkingDays = company.noOfWorkingDays;
            int maxHrsInMonth = company.maxHrsInMonth;
            string companyName = company.companyName;
            int empRatePerHOur = company.empRatePerHour;
            //Variables
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            Console.WriteLine("Company : "+companyName);
            while(totalEmpHrs<=maxHrsInMonth && totalWorkingDays<numOfWorkingDays)
            {
                totalWorkingDays++;
                //Computation
                int empHrs = EmpHrs();
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#: " + totalWorkingDays+ " Emp Hrs : "+empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHOur;
            Console.WriteLine("Total Emp Wage : "+totalEmpWage +"\nTotal Working Hrs: "+totalEmpHrs+"\n");
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
    public class Company
    {
        public string companyName;
        public int noOfWorkingDays;
        public int maxHrsInMonth;
        public int empRatePerHour;
        public Company(string name,int workDays,int hrs,int rate)
        {
            companyName = name;
            noOfWorkingDays = workDays;
            maxHrsInMonth = hrs;
            empRatePerHour = rate;
        }
    }
}
