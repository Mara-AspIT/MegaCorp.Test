using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using MegaCorp.Entities;

namespace MegaCorp.DataAccess
{
    public static class Convert
    {
        public static Employee ToEmployee(DataRow employeeRow, out int departmentFK)
        {
            departmentFK = (int)employeeRow["DepartmentId"];
            int id = (int)employeeRow["EmployeeId"];
            string firstname = (string)employeeRow["Firstname"];
            string lastname = (string)employeeRow["Lastname"];
            DateTime startDate = (DateTime)employeeRow["StartDate"];
            string position = (string)employeeRow["Position"];
            decimal salary = (decimal)employeeRow["Salary"];
            Employee employee = new Employee(id, firstname, lastname, salary, position, startDate);
            return employee;
        }

        public static Department ToDepartment(DataRow departmentRow, Dictionary<Employee, int> employeeDepartmentFK)
        {
            int departmentId = (int)departmentRow["DepartmentId"];
            Dictionary<Employee, int> filtered = employeeDepartmentFK.Where(kvp => kvp.Value == departmentId).ToDictionary(kvp => kvp.Key, kvp=>kvp.Value);
            List<Employee> employees = filtered.Keys.ToList<Employee>();
            string name = (string)departmentRow["Name"];
            return new Department(departmentId, employees, name);
        }
    }
}