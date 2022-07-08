using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IFNA_BANK_BRANCHRepository : IRepositoryBase<FNA_BANK_BRANCH> { }

    public class FNA_BANK_BRANCHRepository : RepositoryBase<FNA_BANK_BRANCH>, IFNA_BANK_BRANCHRepository
    {
        private readonly IDBHelper _dbHelper;

        public FNA_BANK_BRANCHRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

