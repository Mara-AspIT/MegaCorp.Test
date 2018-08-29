using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCorp.DataAccess;
using MegaCorp.Entities;

namespace MegaCorp.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            List<Employee> employees = employeeRepository.GetAllEmployees();
            DepartmentRepository repository = new DepartmentRepository();
            List<Department> departments = repository.GetAllDepartments();

            foreach(Department department in departments)
            {
                Console.WriteLine($"Der arbejder {department.Employees.Count} i {department.Name} afdelingen:");
                foreach(Employee employee in department.Employees)
                {
                    Console.WriteLine($"\t{employee.Firstname} {employee.Lastname}");
                }
            }

            Console.Write($"I alt arbejder {employees.Count} i MegaCorp. Vores årlige lønudgift er: ");
            decimal total = default;
            foreach(Employee employee in employees)
            {
                total += employee.Salary;
            }
            Console.Write(total.ToString("C2"));    // Currency med to decimaler
            Console.ReadLine();
        }
    }
}
