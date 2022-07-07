using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IFNA_BANKRepository : IRepositoryBase<FNA_BANK> { }

    public class FNA_BANKRepository : RepositoryBase<FNA_BANK>, IFNA_BANKRepository
    {
        private readonly IDBHelper _dbHelper;

        public FNA_BANKRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

