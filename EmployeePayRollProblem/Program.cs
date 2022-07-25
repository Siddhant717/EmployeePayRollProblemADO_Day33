using System;

namespace EmployeePayRollProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepo employees = new();
            employees.SUMofMaleEmployeeSalary();
            employees.SUMofFemaleEmployeeSalary();
            employees.AVGofMaleEmployeeSalary();
            employees.AVGofFemaleEmployeeSalary();
            employees.COUNTofMaleEmployee();
            employees.COUNTofFemaleEmployee();
            employees.MINofMaleEmployeeSalary();
            employees.MINofFemaleEmployeeSalary();
            employees.MAXofMaleEmployeeSalary();
            employees.MAXofFemaleEmployeeSalary();
        }
    }
}
