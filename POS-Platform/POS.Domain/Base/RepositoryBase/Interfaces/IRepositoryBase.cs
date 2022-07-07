using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain
{
    public interface IRepositoryBase<T> where T : class
    {
        // Query
        IQueryable<T> Query();
        IQueryable<T> Query(Expression<Func<T, bool>> where);

        // Get
        T Get(Expression<Func<T, bool>> where);
        Task<T> GetAsync(Expression<Func<T, bool>> where);
        T Get(Expression<Func<T, bool>> where, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null);
        Task<T> GetAsync(Expression<Func<T, bool>> where, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null);

        // GetMany
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
        Task<IEnumerable<T>> GetManyAsync(Expression<Func<T, bool>> where);
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null);
        Task<IEnumerable<T>> GetManyAsync(Expression<Func<T, bool>> where, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null);

        // GetAll
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
        IEnumerable<T> GetAll(Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null);
        Task<IEnumerable<T>> GetAllAsync(Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null);

        // Add
        void Add(T entity);
        void Add(IEnumerable<T> entityList);

        // Update
        void Update(T entity);
        void Update(T entity, params Expression<Func<T, object>>[] properties);

        // Delete
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);

        // Utility
        bool Any(Expression<Func<T, bool>> where);
        Task<bool> AnyAsync(Expression<Func<T, bool>> where);
        int GetCount(Expression<Func<T, bool>> where);
        Task<int> GetCountAsync(Expression<Func<T, bool>> where);
        int GetMax(Expression<Func<T, int>> where);
        Task<int> GetMaxAsync(Expression<Func<T, int>> where);
        string GetMax(Expression<Func<T, string>> where);
        Task<string> GetMaxAsync(Expression<Func<T, string>> where);
        string GetMax(Expression<Func<T, bool>> where, Expression<Func<T, string>> col);
        Task<string> GetMaxAsync(Expression<Func<T, bool>> where, Expression<Func<T, string>> col);
    }
}
