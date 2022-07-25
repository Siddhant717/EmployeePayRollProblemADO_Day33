﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRollProblem
{
    public class EmployeeRepo
    {
        //Retrieve all Employees joined in particular date range
        public void GetEmployeesByDateRange()
        {
            var SQL = @$"select * from employee_payroll where StartDate BETWEEN CAST('2021-01-01' AS DATE) AND GETDATE()";
            string connectingString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=payroll_service;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectingString);
            SqlCommand cmd = new SqlCommand(SQL, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<EmployeePayroll> employeePayroll = new List<EmployeePayroll>();
            while (reader.Read())
            {
                var employee = new EmployeePayroll();
                employee.Id = reader.GetInt32(0);
                employee.Name = reader.GetString(1);
                employee.Salary = reader.GetInt32(2);
                employee.StartDate = reader.GetDateTime(3);
                employee.Gender = reader.GetString(4);
                employee.PhoneNumber = reader.GetInt64(5);
                employee.Address = reader.GetString(6);
                employee.Department = reader.GetString(7);
                employee.BasicPay = reader.GetDouble(8);
                employee.Deductions = reader.GetDouble(9);
                employee.TaxablePay = reader.GetDouble(10);
                employee.IncomeTax = reader.GetDouble(11);
                employee.NetPay = reader.GetDouble(12);

                employeePayroll.Add(employee);
            }
            connection.Close();
            foreach (var emp in employeePayroll)
            {
                Console.WriteLine("\nID :" + emp.Id +
                    "\nName :" + emp.Name +
                    "\nSalary :" + emp.Salary +
                    "\nStart Date : " + emp.StartDate +
                    "\nGender :" + emp.Gender +
                    "\nPhoneNumber :" + emp.PhoneNumber +
                    "\nAddress :" + emp.Address +
                    "\nDepartment :" + emp.Department +
                    "\nBasic Pay :" + emp.BasicPay +
                    "\nDeductions :" + emp.Deductions +
                    "\nTaxable Pay :" + emp.TaxablePay +
                    "\nIncome Tax :" + emp.TaxablePay +
                    "\nNet Pay :" + emp.NetPay);
            }
        }

    }
}
     
        

    


