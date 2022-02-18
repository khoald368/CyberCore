using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;

namespace CyberCore.DataMining
{
    public interface ISqlClient
    {
        Task<IEnumerable<T>> QueryAsync<T>(string connection, string command, object parameters = null);

        Task<T> QueryFirstAsync<T>(string connection, string command, object parameters = null);

        Task<T> QueryFirstOrDefaultAsync<T>(string connection, string command, object parameters = null);

        Task<T> QuerySingleAsync<T>(string connection, string command, object parameters = null);

        Task<T> QuerySingleOrDefaultAsync<T>(string connection, string command, object parameters = null);

        Task<int> ExecuteNonQueryAsync(string connection, string command, object parameters = null);
    }

    public class SqlClient : ISqlClient
    {
        public async Task<IEnumerable<T>> QueryAsync<T>(string connection, string command, object parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                return await conn.QueryAsync<T>(sql: command, param: parameters, commandTimeout: CommandTimeout);
            }
        }

        public async Task<T> QueryFirstAsync<T>(string connection, string command, object parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                return await conn.QueryFirstAsync<T>(sql: command, param: parameters, commandTimeout: CommandTimeout);
            }
        }

        public async Task<T> QueryFirstOrDefaultAsync<T>(string connection, string command, object parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                return await conn.QueryFirstOrDefaultAsync<T>(sql: command, param: parameters, commandTimeout: CommandTimeout);
            }
        }

        public async Task<T> QuerySingleAsync<T>(string connection, string command, object parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                return await conn.QuerySingleAsync<T>(sql: command, param: parameters, commandTimeout: CommandTimeout);
            }
        }

        public async Task<T> QuerySingleOrDefaultAsync<T>(string connection, string command, object parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                return await conn.QuerySingleOrDefaultAsync<T>(sql: command, param: parameters, commandTimeout: CommandTimeout);
            }
        }

        public async Task<int> ExecuteNonQueryAsync(string connection, string command, object parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                return await conn.ExecuteAsync(sql: command, param: parameters, commandTimeout: CommandTimeout);
            }
        }

        private int CommandTimeout { get; set; } = 120;
    }
}
