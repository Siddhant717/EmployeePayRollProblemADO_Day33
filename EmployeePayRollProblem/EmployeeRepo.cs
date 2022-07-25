using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRollProblem
{
    public class EmployeeRepo
    {
        //Updating the Salary for Terissa
        public  void UpdateBasePay(string EmployeeName)
        {
            EmployeePayroll emp = new EmployeePayroll()
            {
                Name = EmployeeName,
                BasicPay = 3000000,
                Deductions = 50000,
                TaxablePay = 500000,
                IncomeTax = 15000,
                NetPay = 2200000
            };
            var SQL = @$"update employee_payroll set BasicPay = '{emp.BasicPay}', Deductions = '{emp.Deductions}', TaxablePay= '{emp.TaxablePay}', IncomeTax = '{emp.IncomeTax}', NetPay = '{emp.NetPay}' where name = '{emp.Name}'";
            string connectingString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=payroll_service;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectingString);
            SqlCommand cmd = new SqlCommand(SQL, connection);
            connection.Open();
            int reader = cmd.ExecuteNonQuery();
            Console.WriteLine(reader);
            Console.WriteLine("Commands Completed Successfully");
            Console.ReadKey();
            connection.Close();
        }

    }
}

