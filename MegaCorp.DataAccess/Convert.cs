using System;
using System.Data;

using MegaCorp.Entities;

namespace MegaCorp.DataAccess
{
    public static class Convert
    {
        public static Employee ToEmployee(DataRow dataRow)
        {
            return new Employee(default, default, default, default, default);
        }
    }
}
