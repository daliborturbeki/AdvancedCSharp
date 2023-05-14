using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPData
{
    internal static class Data
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee() { ID = 1, FirstName = "Joe", LastName = "Smith", AnnualSalary = 50000, IsManager = false, DepartmentID = 1 });
            employees.Add(new Employee() { ID = 2, FirstName = "Jane", LastName = "Doe", AnnualSalary = 60000, IsManager = false, DepartmentID = 2 });
            employees.Add(new Employee() { ID = 3, FirstName = "Douglas", LastName = "Roberts", AnnualSalary = 70000, IsManager = true, DepartmentID = 1 });
            employees.Add(new Employee() { ID = 4, FirstName = "Melissa", LastName = "Jones", AnnualSalary = 80000, IsManager = true, DepartmentID = 2 });
            
            return employees;
        }

        public static List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();

            departments.Add(new Department() { ID = 1, ShortName = "HR", LongName = "Human Resources" });
            departments.Add(new Department() { ID = 2, ShortName = "IT", LongName = "Information Technology" });

            return departments;
        }
    }
}
