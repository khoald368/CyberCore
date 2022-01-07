using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;

namespace SampleApp.CyberCore
{
    public class SqlClient : ISqlClient
    {
        public SqlClient(string connectionString, int commandTimeout = 0)
        {
            ConnectionString = connectionString;
            if (commandTimeout != 0) CommandTimeout = commandTimeout;
        }

        public async Task<IEnumerable<T>> QueryAsync<T>(string command, object parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                return await conn.QueryAsync<T>(sql: command, param: parameters, commandTimeout: CommandTimeout);
            }
        }

        public async Task<T> QueryFirstAsync<T>(string command, object parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                return await conn.QueryFirstAsync<T>(sql: command, param: parameters, commandTimeout: CommandTimeout);
            }
        }

        public async Task<T> QueryFirstOrDefaultAsync<T>(string command, object parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                return await conn.QueryFirstOrDefaultAsync<T>(sql: command, param: parameters, commandTimeout: CommandTimeout);
            }
        }

        public async Task<T> QuerySingleAsync<T>(string command, object parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                return await conn.QuerySingleAsync<T>(sql: command, param: parameters, commandTimeout: CommandTimeout);
            }
        }

        public async Task<T> QuerySingleOrDefaultAsync<T>(string command, object parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                return await conn.QuerySingleOrDefaultAsync<T>(sql: command, param: parameters, commandTimeout: CommandTimeout);
            }
        }

        public async Task<int> ExecuteNonQueryAsync(string command, object parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                return await conn.ExecuteAsync(sql: command, param: parameters, commandTimeout: CommandTimeout);
            }
        }

        private string ConnectionString { get; set; }

        private int CommandTimeout { get; set; } = 120;
    }
}
