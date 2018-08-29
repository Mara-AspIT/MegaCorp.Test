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
        public DepartmentRepository() : base(ConnectionStrings.LocalDb)
        {

        }

        public List<Department> GetAllDepartments()
        {
            string sql = SqlQueries.SelectAll + " Departments";
            List<Department> departments = new List<Department>(0);
            DataSet resultSet = Execute(sql);
            List<Employee> employees = new List<Employee>(0);
            Dictionary<Employee, int> employeeDepartmentFK = new Dictionary<Employee, int>();
            foreach(DataRow employeeRow in resultSet.Tables[0].Rows)
            {
                Employee e = Convert.ToEmployee(employeeRow, out int departmentFK);
                employeeDepartmentFK.Add(e, departmentFK);
            }
            foreach(DataRow deparmentRow in resultSet.Tables[1].Rows)
            {

            }
            return departments;
        }
    }
}
