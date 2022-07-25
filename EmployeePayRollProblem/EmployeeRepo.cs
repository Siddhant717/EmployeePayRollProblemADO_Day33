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
        //Retrieve all Employees joined in particular date range
        //Retrieve Sum of Male Employee Salary
        public void SUMofMaleEmployeeSalary()
        {
            var SQL = @$"select SUM(salary) from employee_payroll where Gender = 'M' GROUP BY Gender";
            string connectingString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=payroll_service;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectingString);
            SqlCommand cmd = new SqlCommand(SQL, connection);
            connection.Open();

            int reader = (int)cmd.ExecuteScalar();
            Console.WriteLine("Sum of Male Employee Salary is : " + reader); ;
            Console.ReadKey();
            connection.Close();
        }
        //Retrieve Sum of Female Employee Salary
        public void SUMofFemaleEmployeeSalary()
        {
            var SQL = @$"select SUM(salary) FROM employee_payroll where Gender = 'F' GROUP BY Gender";
            string connectingString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=payroll_service;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectingString);
            SqlCommand cmd = new SqlCommand(SQL, connection);
            connection.Open();

            int reader = (int)cmd.ExecuteScalar();
            Console.WriteLine("Sum of Female Employee Salary is : " + reader);
            Console.ReadKey();
            connection.Close();
        }
        //Retrieve Average Salary of Male Employee
        public void AVGofMaleEmployeeSalary()
        {
            var SQL = @$"select AVG(salary) FROM employee_payroll where Gender = 'M' GROUP BY Gender";
            string connectingString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=payroll_service;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectingString);
            SqlCommand cmd = new SqlCommand(SQL, connection);
            connection.Open();

            int reader = (int)cmd.ExecuteScalar();
            Console.WriteLine("Average Salary of Male Employee is : " + reader); ;
            Console.ReadKey();
            connection.Close();
        }
        //Retrieve Average Salary of Female Employee
        public void AVGofFemaleEmployeeSalary()
        {
            var SQL = @$"select AVG(salary) from employee_payroll where Gender = 'F' GROUP BY Gender";
            string connectingString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=payroll_service;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectingString);
            SqlCommand cmd = new SqlCommand(SQL, connection);
            connection.Open();

            int reader = (int)cmd.ExecuteScalar();
            Console.WriteLine("Average Salary of Female Employee is : " + reader);
            Console.ReadKey();
            connection.Close();
        }
        //Retrieve Minimum Salary of Male Employee 
        public void MINofMaleEmployeeSalary()
        {
            var SQL = @$"select MIN(salary) from employee_payroll where Gender = 'M' GROUP BY Gender";
            string connectingString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=payroll_service;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectingString);
            SqlCommand cmd = new SqlCommand(SQL, connection);
            connection.Open();

            int reader = (int)cmd.ExecuteScalar();
            Console.WriteLine("Minimum Salary of Male Employee is : " + reader); ;
            Console.ReadKey();
            connection.Close();
        }
        //Retrieve Minimum Salary of Female Employee 
        public  void MINofFemaleEmployeeSalary()
        {
            var SQL = @$"select MIN(salary) from employee_payroll where Gender = 'F' GROUP BY Gender";
            string connectingString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=payroll_service;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectingString);
            SqlCommand cmd = new SqlCommand(SQL, connection);
            connection.Open();

            int reader = (int)cmd.ExecuteScalar();
            Console.WriteLine("Minimum Salary of Female Employee is : " + reader);
            Console.ReadKey();
            connection.Close();
        }
        //Retrieve Maximum Salary of Male Employee 
        public void MAXofMaleEmployeeSalary()
        {
            var SQL = @$"select MAX(salary) from employee_payroll where Gender = 'M' GROUP BY Gender";
            string connectingString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=payroll_service;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectingString);
            SqlCommand cmd = new SqlCommand(SQL, connection);
            connection.Open();

            int reader = (int)cmd.ExecuteScalar();
            Console.WriteLine("Maximum Salary of Male Employee is : " + reader); ;
            Console.ReadKey();
            connection.Close();
        }
        //Retrieve Maximum Salary of Female Employee 
        public void MAXofFemaleEmployeeSalary()
        {
            var SQL = @$"select MAX(salary) from employee_payroll where Gender = 'F' GROUP BY Gender";
            string connectingString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=payroll_service;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectingString);
            SqlCommand cmd = new SqlCommand(SQL, connection);
            connection.Open();

            int reader = (int)cmd.ExecuteScalar();
            Console.WriteLine("Maximum Salary of Female Employee is : " + reader);
            Console.ReadKey();
            connection.Close();
        }
        //Retrieve Number (Count) of Male Employee 
        public void COUNTofMaleEmployee()
        {
            var SQL = @$"select COUNT(salary) from employee_payroll where Gender = 'M' GROUP BY Gender";
            string connectingString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=payroll_service;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectingString);
            SqlCommand cmd = new SqlCommand(SQL, connection);
            connection.Open();

            int reader = (int)cmd.ExecuteScalar();
            Console.WriteLine("Number (Count) of Male Employee is : " + reader); ;
            Console.ReadKey();
            connection.Close();
        }
        //Retrieve Number (Count) of Female Employee 
        public void COUNTofFemaleEmployee()
        {
            var SQL = @$"select COUNT(salary) FROM employee_payroll where Gender = 'F' GROUP BY Gender";
            string connectingString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=payroll_service;Integrated Security=True
";
            SqlConnection connection = new SqlConnection(connectingString);
            SqlCommand cmd = new SqlCommand(SQL, connection);
            connection.Open();

            int reader = (int)cmd.ExecuteScalar();
            Console.WriteLine("Number (Count) of Female Employee : " + reader);
            Console.ReadKey();
            connection.Close();
        }

    }
}
     
        

    


