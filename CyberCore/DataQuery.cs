using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCore
{
    public interface IDataQuery
    {

    }

    public class DataQuery : IDataQuery
    {
        public void Initialize(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public async Task<IEnumerable<T>> GetListAsync<T>(QueryPaging paging, QueryFilter filter) where T : class
        {
            return null;
        }

        private string ConnectionString { get; set; }
    }

    public class QueryPaging
    {

    }

    public class QueryFilter
    {

    }
}
