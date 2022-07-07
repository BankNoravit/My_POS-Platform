using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IORG_COMPANYRepository : IRepositoryBase<ORG_COMPANY> { }

    public class ORG_COMPANYRepository : RepositoryBase<ORG_COMPANY>, IORG_COMPANYRepository
    {
        private readonly IDBHelper _dbHelper;

        public ORG_COMPANYRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

