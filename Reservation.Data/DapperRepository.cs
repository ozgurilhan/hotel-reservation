using Dapper;
using DapperExtensions;
using DapperExtensions.Predicate;
using Reservation.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Reservation.Data
{
    public class DapperSort : ISort
    {
        public string PropertyName { get; set; }
        public bool Ascending { get; set; }
        public IList<PropertyInfo> Properties { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class DapperRepository<T> : IRepository<T> where T : class
    {
        public IDbContext Context { get; }
        private Dictionary<Guid, T> _db = new Dictionary<Guid, T>();
        public DapperRepository(IDbContext context)
        {
            Context = context;
        }

        public T GetById(int id)
        {
            var t = Context.Connection.Get<T>(new { Id = id });
            Context.Connection.Close();
            return t;
        }

        public int Insert(T entity)
        {
            var createdOn = entity.GetType().GetProperty("CreatedAt");
            createdOn.SetValue(entity, DateTime.UtcNow);

            var updatedOn = entity.GetType().GetProperty("UpdatedAt");
            updatedOn.SetValue(entity, DateTime.UtcNow);

            int returnValue = 0;

            try
            {
                returnValue = Context.Connection.Insert(entity);
            }
            catch (Exception)
            {

            }
           

            Context.Connection.Close();
            return returnValue;
        }

        public bool Update(T entity)
        {
            var updatedOnProperty = entity.GetType().GetProperty("UpdatedAt");
            updatedOnProperty.SetValue(entity, DateTime.UtcNow);

            var returnValue = Context.Connection.Update(entity);
            Context.Connection.Close();
            return returnValue;
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            if (entity == null) return;
            Context.Connection.Delete<T>(entity);
            Context.Connection.Close();
        }

        public IEnumerable<T> GetList()
        {
            IEnumerable<T> list;
            try
            {
                list = Context.Connection.GetList<T>();
            }
            finally
            {
                Context.Connection.Close();
            }
            return list;
        }

        public IEnumerable<T> GetList(object predicate, List<SortBy> sort)
        {
            IEnumerable<T> list;
            List<ISort> dapperSort = null;
            if (sort != null)
            {
                dapperSort = sort.Select(s => new DapperSort { Ascending = s.Ascending, PropertyName = s.PropertyName }).Cast<ISort>().ToList();

            }

            try
            {
                list = Context.Connection.GetList<T>(predicate, dapperSort);
            }
            finally
            {
                Context.Connection.Close();
            }
            return list;
        }

        public IEnumerable<TT> ExecuteReader<TT>(string query, Dictionary<string, object> parameters = null)
        {
            IEnumerable<TT> list;
            if (parameters == null)
            {

                list = Context.Connection.Query<TT>(query, null, null, true, null, CommandType.StoredProcedure);
                Context.Connection.Close();
                return list;
            }

            var ps = new DynamicParameters();
            foreach (var p in parameters)
            {
                ps.Add(p.Key, p.Value);
            }

            list = Context.Connection.Query<TT>(query, ps, null, true, null, CommandType.StoredProcedure);

            Context.Connection.Close();
            return list;
        }

        public object ExecuteScalar(string query, Dictionary<string, object> parameters = null)
        {
            object result;
            if (parameters == null)
            {
                result = Context.Connection.Execute(query, null, null, null, CommandType.StoredProcedure);
                Context.Connection.Close();
                return result;
            }

            var ps = new DynamicParameters();
            foreach (var p in parameters)
            {
                ps.Add(p.Key, p.Value);
            }

            result = Context.Connection.Execute(query, ps, null, null, CommandType.StoredProcedure);

            Context.Connection.Close();
            return result;
        }

        public int ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            int result;
            if (parameters == null)
            {
                result = Context.Connection.Execute(query, null, null, null, CommandType.StoredProcedure);
                Context.Connection.Close();
                return result;
            }

            var ps = new DynamicParameters();
            foreach (var p in parameters)
            {
                ps.Add(p.Key, p.Value);
            }
            result = Context.Connection.Execute(query, ps, null, null, CommandType.StoredProcedure);

            Context.Connection.Close();
            return result;
        }
    }
}
