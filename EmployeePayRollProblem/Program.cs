using System;

namespace EmployeePayRollProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepo employees = new();
            employees.GetEmployeesByDateRange();
        }
    }
}
