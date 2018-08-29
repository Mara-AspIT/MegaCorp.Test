using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCorp.Entities;

namespace MegaCorp.DataAccess
{
    public class DepartmentRepository: RepositoryBase
    {
        public DepartmentRepository() : base(ConnectionStrings.LocalDb) { }

        public List<Department> GetAllDepartments()
        {
            string sql = $"{SqlQueries.SelectAll} Employees; {SqlQueries.SelectAll} Departments;";  // 1..*
            DataSet resultSet = Execute(sql);
            Dictionary<Employee, int> employeeDepartmentFK = new Dictionary<Employee, int>();
            foreach(DataRow employeeRow in resultSet.Tables[0].Rows)
            {
                Employee e = Convert.ToEmployee(employeeRow, out int departmentFK);
                employeeDepartmentFK.Add(e, departmentFK);
            }
            List<Department> departments = new List<Department>(0);
            foreach(DataRow departmentRow in resultSet.Tables[1].Rows)
            {
                Department d = Convert.ToDepartment(departmentRow, employeeDepartmentFK);
                departments.Add(d);
            }
            return departments;
        }
    }
}