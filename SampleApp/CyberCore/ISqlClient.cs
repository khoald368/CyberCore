using System.Collections.Generic;
using System.Threading.Tasks;

namespace SampleApp.CyberCore
{
    public interface ISqlClient
    {
        Task<IEnumerable<T>> QueryAsync<T>(string command, object parameters = null);

        Task<T> QueryFirstAsync<T>(string command, object parameters = null);

        Task<T> QueryFirstOrDefaultAsync<T>(string command, object parameters = null);

        Task<T> QuerySingleAsync<T>(string command, object parameters = null);

        Task<T> QuerySingleOrDefaultAsync<T>(string command, object parameters = null);

        Task<int> ExecuteNonQueryAsync(string command, object parameters = null);
    }
}
