using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IFNA_BANK_ACCOUNTRepository : IRepositoryBase<FNA_BANK_ACCOUNT> { }

    public class FNA_BANK_ACCOUNTRepository : RepositoryBase<FNA_BANK_ACCOUNT>, IFNA_BANK_ACCOUNTRepository
    {
        private readonly IDBHelper _dbHelper;

        public FNA_BANK_ACCOUNTRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

