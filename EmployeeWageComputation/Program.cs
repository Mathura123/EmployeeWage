using System;
using System.Security.Cryptography;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation in Master Branch");
            Console.WriteLine("=====================================================\n");
            EmpWageBuilder empObj = new EmpWageBuilder();
            CompanyEmpWage company1= empObj.AddCompanyEmpwage("Capgemini", 25, 100, 1500);
            CompanyEmpWage company2= empObj.AddCompanyEmpwage("TCS", 25, 120, 1200);
            EmployeeWageComputation.EmpWageBuilder.ComputeEmpWage(company1);
            EmployeeWageComputation.EmpWageBuilder.ComputeEmpWage(company2);
        }
    }
}
