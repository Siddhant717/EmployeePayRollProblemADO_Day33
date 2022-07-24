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
        public void UpdateBasePay()
        {
            var SQL = @$"update employee_payroll set BasicPay = 3000000, Deductions = 800000, TaxablePay= 100000, IncomeTax = 200000, NetPay = 2200000 where name = 'Terissa'";
            String connectingstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=payroll_service;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectingstring);
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

