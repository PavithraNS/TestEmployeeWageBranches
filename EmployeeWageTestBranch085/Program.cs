using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageTestBranch085
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            Console.WriteLine("Welcome to EmployeeWage computation");

            Random random = new Random();
            int empCheck= random.Next(0,2);
            if(empCheck==IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
