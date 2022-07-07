using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IINV_PRODUCT_SPECIFICATIONRepository : IRepositoryBase<INV_PRODUCT_SPECIFICATION> { }

    public class INV_PRODUCT_SPECIFICATIONRepository : RepositoryBase<INV_PRODUCT_SPECIFICATION>, IINV_PRODUCT_SPECIFICATIONRepository
    {
        private readonly IDBHelper _dbHelper;

        public INV_PRODUCT_SPECIFICATIONRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

