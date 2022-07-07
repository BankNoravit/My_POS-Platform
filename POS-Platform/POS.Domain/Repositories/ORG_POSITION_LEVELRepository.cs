using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IORG_POSITION_LEVELRepository : IRepositoryBase<ORG_POSITION_LEVEL> { }

    public class ORG_POSITION_LEVELRepository : RepositoryBase<ORG_POSITION_LEVEL>, IORG_POSITION_LEVELRepository
    {
        private readonly IDBHelper _dbHelper;

        public ORG_POSITION_LEVELRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

