using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IINV_SPECIFICATION_ITEMRepository : IRepositoryBase<INV_SPECIFICATION_ITEM> { }

    public class INV_SPECIFICATION_ITEMRepository : RepositoryBase<INV_SPECIFICATION_ITEM>, IINV_SPECIFICATION_ITEMRepository
    {
        private readonly IDBHelper _dbHelper;

        public INV_SPECIFICATION_ITEMRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

