using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCorp.Entities
{
    public class Employee: Person
    {

        public Employee(string firstname, string lastname, decimal salary, string position, DateTime startDate)
            : this(id: default, firstname, lastname, salary, position, startDate) { }

        public Employee(int id, string firstname, string lastname, decimal salary, string position, DateTime startDate)
            : base(id, firstname, lastname)
        {
            Salary = salary;
            Position = position;
            StartDate = startDate;
        }

        public virtual decimal Salary
        {
            get; set;
        }

        public virtual DateTime StartDate
        {
            get;
            set;
        }

        public virtual string Position
        {

            get; set;
        }
    }
}
