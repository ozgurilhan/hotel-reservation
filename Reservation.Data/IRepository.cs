using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Data
{

    public class SortBy
    {
        public string PropertyName { get; set; }
        public bool Ascending { get; set; }
    }

    public interface IRepository<T>
    {
        T GetById(int id);

        int Insert(T entity);

        bool Update(T entity);

        void Delete(int id);

        IEnumerable<T> GetList();

        IEnumerable<T> GetList(object predicate, List<SortBy> sort);

        IEnumerable<TT> ExecuteReader<TT>(string query, Dictionary<string, object> parameters = null);

        object ExecuteScalar(string query, Dictionary<string, object> parameters = null);

        int ExecuteNonQuery(string query, Dictionary<string, object> parameters = null);
    }
}
