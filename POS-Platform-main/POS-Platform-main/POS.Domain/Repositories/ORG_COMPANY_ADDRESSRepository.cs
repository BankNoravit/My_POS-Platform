using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IORG_COMPANY_ADDRESSRepository : IRepositoryBase<ORG_COMPANY_ADDRESS> { }

    public class ORG_COMPANY_ADDRESSRepository : RepositoryBase<ORG_COMPANY_ADDRESS>, IORG_COMPANY_ADDRESSRepository
    {
        private readonly IDBHelper _dbHelper;

        public ORG_COMPANY_ADDRESSRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

