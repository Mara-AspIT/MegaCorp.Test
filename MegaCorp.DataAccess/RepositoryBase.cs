using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCorp.DataAccess
{
    public abstract class RepositoryBase
    {
        private readonly string connectionString;

        public RepositoryBase(string connectionString)
        {
            // test connection
            this.connectionString = connectionString;
        }

        protected virtual DataSet Execute(string sql)
        {
            DataSet resultSet = new DataSet();
            try
            {
                using(SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand(sql, new SqlConnection(connectionString))))
                {
                    adapter.Fill(resultSet);
                }
            }
            catch(Exception e)
            {
                throw new DataAccessException("Error accessing data", e);
            }
            return resultSet;
        }
    }
}
