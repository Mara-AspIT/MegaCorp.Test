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
            return departments;
        }
    }
}
