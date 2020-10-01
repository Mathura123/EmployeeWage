using System;
using System.Security.Cryptography;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation in Master Branch\n");
            Company company1 = new Company("Capgemini", 25, 100, 1500);
            Company company2 = new Company("TCS", 25, 120, 1200);
            EmployeeWageComputation.EmpWage.ComputeEmpWage(company1);
            EmployeeWageComputation.EmpWage.ComputeEmpWage(company2);
        }
    }
}
