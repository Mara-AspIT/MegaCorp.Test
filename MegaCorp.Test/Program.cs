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
            EmployeeRepository repository = new EmployeeRepository();
            List<Employee> employees = repository.GetAllEmployees();
            foreach(var item in employees)
            {
                Console.WriteLine(item);
            }
        }
    }
}
