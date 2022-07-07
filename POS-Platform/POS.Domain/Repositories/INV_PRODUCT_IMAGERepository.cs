using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IINV_PRODUCT_IMAGERepository : IRepositoryBase<INV_PRODUCT_IMAGE> { }

    public class INV_PRODUCT_IMAGERepository : RepositoryBase<INV_PRODUCT_IMAGE>, IINV_PRODUCT_IMAGERepository
    {
        private readonly IDBHelper _dbHelper;

        public INV_PRODUCT_IMAGERepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

