using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain
{
    public abstract class RepositoryBase<T> where T : class 
    {
        #region [Private Members]
        private ReadWriteMainDBContext _readWriteDB;
        private ReadOnlyMainDBContext _readOnlyDB;
        private DbSet<T> _readWriteDBSet;
        private DbSet<T> _readOnlyDBSet;

        private EntityState _modifiedState;
        #endregion [Private Members]

        #region [Constructor]
        protected RepositoryBase(ReadWriteMainDBContext readWriteDB, ReadOnlyMainDBContext readOnlyDB)
        {
            this._readWriteDB = readWriteDB;
            this._readOnlyDB = readOnlyDB;

            this._readWriteDBSet = this._readWriteDB.Set<T>();
            this._readOnlyDBSet = this._readOnlyDB.Set<T>();

            this._modifiedState = EntityState.Modified;
        }
        #endregion [Constructor]

        #region [Implement]

        #region [Queryable]

        public IQueryable<T> Query()
        {
            return this._readOnlyDBSet;
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> where)
        {
            return this._readOnlyDBSet.Where(where);
        }

        #endregion [Queryable]

        #region [Get]
        public T Get(Expression<Func<T, bool>> where)
        {
            return this._readOnlyDBSet.Where(where).FirstOrDefault<T>();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> where)
        {
            return await this._readOnlyDBSet.Where(where).FirstOrDefaultAsync<T>();
        }

        public T Get(Expression<Func<T, bool>> where, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null)
        {
            if (includes != null)
            {
                return includes(this._readOnlyDBSet).Where(where).FirstOrDefault<T>();
            }
            return this._readOnlyDBSet.Where(where).FirstOrDefault<T>();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> where, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null)
        {
            if (includes != null)
            {
                return await includes(this._readOnlyDBSet).Where(where).FirstOrDefaultAsync<T>();
            }
            return await this._readOnlyDBSet.Where(where).FirstOrDefaultAsync<T>();
        }
        #endregion [Get]

        #region [GetMany]
        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return this._readOnlyDBSet.Where(where).ToList();
        }

        public virtual async Task<IEnumerable<T>> GetManyAsync(Expression<Func<T, bool>> where)
        {
            return await this._readOnlyDBSet.Where(where).ToListAsync();
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null)
        {
            if (includes != null)
            {
                return includes(this._readOnlyDBSet).Where(where).ToList();
            }
            return this._readOnlyDBSet.Where(where).ToList();
        }

        public virtual async Task<IEnumerable<T>> GetManyAsync(Expression<Func<T, bool>> where, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null)
        {
            if (includes != null)
            {
                return await includes(this._readOnlyDBSet).Where(where).ToListAsync();
            }
            return await this._readOnlyDBSet.Where(where).ToListAsync();
        }

        #endregion [GetMany]

        #region [GetAll]
        public virtual IEnumerable<T> GetAll()
        {
            return this._readOnlyDBSet.ToList();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await this._readOnlyDBSet.ToListAsync();
        }

        public virtual IEnumerable<T> GetAll(Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null)
        {
            if (includes != null)
            {
                return includes(this._readOnlyDBSet).ToList();
            }
            return this._readOnlyDBSet.ToList();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync(Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null)
        {
            if (includes != null)
            {
                return await includes(this._readOnlyDBSet).ToListAsync();
            }
            return await this._readOnlyDBSet.ToListAsync();
        }
        #endregion [GetAll]

        #region [Add]
        public virtual void Add(T entity)
        {
            this._readWriteDBSet.Add(entity);
        }

        public virtual void Add(IEnumerable<T> entityList)
        {
            foreach (T entity in entityList)
            {
                this._readWriteDBSet.Add(entity);
            }
        }
        #endregion [Add]

        #region [Update]
        public virtual void Update(T entity)
        {
            this._readWriteDBSet.Attach(entity);
            this._readWriteDB.Entry(entity).State = this._modifiedState;
        }

        public virtual void Update(T entity, params Expression<Func<T, object>>[] properties)
        {
            this._readWriteDB.Entry(entity).State = this._modifiedState;
            foreach (var selector in properties)
            {
                this._readWriteDB.Entry(entity).Property(selector).IsModified = true;
            }
        }
        #endregion [Update]

        #region [Delete]
        public virtual void Delete(T entity)
        {
            this._readWriteDBSet.Remove(entity);
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = this._readWriteDBSet.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                this._readWriteDBSet.Remove(obj);
        }
        #endregion [Delete]

        #region [Utility]
        public bool Any(Expression<Func<T, bool>> where)
        {
            return this._readOnlyDBSet.Any(where);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> where)
        {
            return await this._readOnlyDBSet.AnyAsync(where);
        }

        public virtual int GetCount(Expression<Func<T, bool>> where)
        {
            return this._readOnlyDBSet.Where(where).Count();
        }

        public virtual async Task<int> GetCountAsync(Expression<Func<T, bool>> where)
        {
            return await this._readOnlyDBSet.Where(where).CountAsync();
        }

        public virtual int GetMax(Expression<Func<T, int>> where)
        {
            return this._readOnlyDBSet.Max(where);
        }

        public virtual async Task<int> GetMaxAsync(Expression<Func<T, int>> where)
        {
            return await this._readOnlyDBSet.MaxAsync(where);
        }

        public virtual string GetMax(Expression<Func<T, string>> where)
        {
            return this._readOnlyDBSet.Max(where);
        }

        public virtual async Task<string> GetMaxAsync(Expression<Func<T, string>> where)
        {
            return await this._readOnlyDBSet.MaxAsync(where);
        }

        public virtual string GetMax(Expression<Func<T, bool>> where, Expression<Func<T, string>> col)
        {
            return this._readOnlyDBSet.Where(where).Max(col);
        }

        public virtual async Task<string> GetMaxAsync(Expression<Func<T, bool>> where, Expression<Func<T, string>> col)
        {
            return await this._readOnlyDBSet.Where(where).MaxAsync(col);
        }
        #endregion [Utility]

        #endregion [Implement]

        #region [Protected: Stored procedure]
        protected virtual IEnumerable<T2> ExcuteStoredProcedure<T2>(Dictionary<string, object> spParams = null) where T2 : class
        {
            return this._ExcuteStoredProcedure<T2>(spParams: spParams).ToList();
        }
        protected virtual async Task<IEnumerable<T2>> ExcuteStoredProcedureAsync<T2>(Dictionary<string, object> spParams = null) where T2 : class
        {
            return await this._ExcuteStoredProcedure<T2>(spParams: spParams).ToListAsync();
        }
        #region [Private Excute Logic]
        private IQueryable<T2> _ExcuteStoredProcedure<T2>(Dictionary<string, object> spParams = null) where T2 : class
        {
            var spName = typeof(T2).Name;
            if (spParams != null && spParams.Count() > 0)
            {
                #region [Prepare: Parameter name]
                var selectedParams = spParams.Where(f =>
                                              (
                                                  !(f.Value is string) && f.Value != null
                                              ) ||
                                              (
                                                  (f.Value is string) && !string.IsNullOrEmpty(((string)f.Value))
                                              ));
                spName = spName + " @" + string.Join(", @", selectedParams.Select(s => s.Key + "=@" + s.Key).ToArray());
                #endregion [Prepare: Parameter name]
                #region [Split & Merge: mappingParams.Value by Microsoft.Data.SqlClient.SqlParameter]
                var paramAssignedType = selectedParams
                                        .Where(f => f.Value is Microsoft.Data.SqlClient.SqlParameter)
                                        .Select(s => (Microsoft.Data.SqlClient.SqlParameter)s.Value);
                var paramUnassignedType = selectedParams
                                          .Where(f => !(f.Value is Microsoft.Data.SqlClient.SqlParameter))
                                          .Select(s =>
                                          new Microsoft.Data.SqlClient.SqlParameter(s.Key,
                                              (
                                                  (
                                                      !(s.Value is string) && s.Value == null
                                                  ) ||
                                                  (
                                                      (s.Value is string) && string.IsNullOrEmpty(((string)s.Value))
                                                  )
                                              ) ? DBNull.Value : s.Value
                                          ));
                var sqlParams = paramAssignedType.Concat(paramUnassignedType);
                #endregion [Split & Merge: mappingParams.Value by Microsoft.Data.SqlClient.SqlParameter]
                return this._readOnlyDB.Set<T2>().FromSqlRaw($"EXEC dbo.{spName};", sqlParams.ToArray());
            }
            else
            {
                return this._readOnlyDB.Set<T2>().FromSqlRaw($"EXEC dbo.{spName};");
            }
        }
        #endregion [Private Excute Logic]
        #endregion [Protected: Stored procedure]
    }
}
