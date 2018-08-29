using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCorp.Entities
{
    public class Department: EntityBase
    {

        public Department(int id, List<Employee> employees, string name)
            : base(id)
        {
            Employees = employees;
            Name = name;
        }

        public Department(List<Employee> employees, string name)
            : this(default, employees, name)
        {

        }

        public virtual List<Employee> Employees
        {
            get; set;
        }
        public virtual string Name
        {
            get; set;
        }
    }
}
