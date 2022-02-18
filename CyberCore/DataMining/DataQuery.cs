using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCore.DataMining
{
    public interface IDataQuery
    {
        Task<IEnumerable<T>> GetAsync<T>(Paging paging, object filter) where T : class;
    }

    public class DataQuery : IDataQuery
    {
        public void Initialize(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public async Task<IEnumerable<T>> GetAsync<T>(Paging paging, object filter) where T : class
        {
            return null;
        }

        private string ConnectionString { get; set; }
    }
}
