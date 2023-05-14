using TCPData;
using TCPExtensions;

List<Employee> employees = Data.GetEmployees();

var filteredEmployees = employees.Filter(employee => 
    employee.IsManager == true);

foreach (var employee in filteredEmployees)
{
    Console.WriteLine(employee.FirstName + " " + employee.LastName);
}

Console.WriteLine("\n##############################################\n");

List<Department> departments = Data.GetDepartments();

var filteredDepartments = departments.Where(department =>
    department.ShortName == "HR");

foreach (var department in filteredDepartments)
{
    Console.WriteLine(department.LongName + ", " + department.ShortName);
}

Console.WriteLine("\n##############################################\n");

var resultList = from employee in employees
                 join department in departments
                 on employee.DepartmentID equals department.ID
                 select new
                 {
                     EmployeeName = employee.FirstName + " " + employee.LastName,
                     DepartmentName = department.LongName
                 };

foreach (var result in resultList)
{
    Console.WriteLine(result.EmployeeName + ", " + result.DepartmentName);
}

Console.WriteLine("\n##############################################\n");


