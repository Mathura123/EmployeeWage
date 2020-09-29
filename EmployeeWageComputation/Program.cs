using System;

namespace EmployeeWageComputation
{
    class Program
    {
        const int IS_FULL_TIME = 2;
        const int IS_PART_TIME = 1;
        const int EMP_RATE_PER_HOUR = 20;
        const int NUM_OF_WORKING_DAYS = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation in Master Branch");
            EmployeeWageComputation.Program.ComputeEmpWage();
        }
        static void ComputeEmpWage()
        {
            //Variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                //Computation
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
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage : " + empWage);
            }
            Console.WriteLine("Total Emp Wage : "+totalEmpWage);
        }
    }
}
