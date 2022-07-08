using Microsoft.Extensions.DependencyInjection;

namespace POS.Domain
{
    public partial interface IUnitOfWork
    {
        Task SaveAsync();
        void Dispose();
    }

    public partial class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ReadWriteMainDBContext _readWriteDB;
        private readonly ReadOnlyMainDBContext _readOnlyDB;

        public UnitOfWork(ReadWriteMainDBContext readWriteDB, ReadOnlyMainDBContext readOnlyDB)
        {
            this._readWriteDB = readWriteDB;
            this._readOnlyDB = readOnlyDB;

            this._RegisterRepositories(readWriteDB, readOnlyDB);
        }

        public async Task SaveAsync()
        {
            await this._readWriteDB.SaveChangesAsync();
        }

        public void Dispose()
        {
            this._readWriteDB.Dispose();
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this._readWriteDB.Dispose();
            }
        }
    }
}