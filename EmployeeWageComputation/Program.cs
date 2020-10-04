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
            empObj.AddCompanyEmpWage("DMart", 20, 100, 100);
            empObj.AddCompanyEmpWage("Reliance", 10, 50, 200);
            empObj.ComputeEmpWage();
            empObj.GetTotalEmployeeWage("DMart");
        }
    }
}
