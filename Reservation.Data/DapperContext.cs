using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Data
{
    public class DapperContext : IDbContext
    {
        private readonly string _connectionString;
        private IDbConnection _connection;

        public DapperContext()
        {
            _connectionString = ConfigurationManager.AppSettings["ConnectionString"]; 
        }

        public void Dispose()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
                _connection.Close();
        }

        public IDbConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(_connectionString);
                }
                if (_connection.State != ConnectionState.Open) _connection.Open();
                return _connection;
            }
        }
    }
}
