using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IINV_WAREHOUSERepository : IRepositoryBase<INV_WAREHOUSE> { }

    public class INV_WAREHOUSERepository : RepositoryBase<INV_WAREHOUSE>, IINV_WAREHOUSERepository
    {
        private readonly IDBHelper _dbHelper;

        public INV_WAREHOUSERepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

