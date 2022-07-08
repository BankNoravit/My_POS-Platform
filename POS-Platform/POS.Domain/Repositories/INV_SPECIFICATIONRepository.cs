using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IINV_SPECIFICATIONRepository : IRepositoryBase<INV_SPECIFICATION> { }

    public class INV_SPECIFICATIONRepository : RepositoryBase<INV_SPECIFICATION>, IINV_SPECIFICATIONRepository
    {
        private readonly IDBHelper _dbHelper;

        public INV_SPECIFICATIONRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

