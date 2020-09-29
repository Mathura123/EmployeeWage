using System;

namespace EmployeeWageComputation
{
    class Program
    {
        const int IS_FULL_TIME = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation in Master Branch");
            EmployeeWageComputation.Program.PresentAbsent();
        }
        static void PresentAbsent()
        {
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if(empCheck==IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
