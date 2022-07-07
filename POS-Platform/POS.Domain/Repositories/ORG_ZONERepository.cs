using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IORG_ZONERepository : IRepositoryBase<ORG_ZONE> { }

    public class ORG_ZONERepository : RepositoryBase<ORG_ZONE>, IORG_ZONERepository
    {
        private readonly IDBHelper _dbHelper;

        public ORG_ZONERepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

