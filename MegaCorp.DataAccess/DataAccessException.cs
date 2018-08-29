using System;
using System.Runtime.Serialization;

namespace MegaCorp.DataAccess
{
    [Serializable]
    public class DataAccessException: Exception
    {
        public DataAccessException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}