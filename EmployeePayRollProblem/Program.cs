using System;

namespace EmployeePayRollProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepo employee = new();
            employee.UpdateBasePay();

        }
    }
}
