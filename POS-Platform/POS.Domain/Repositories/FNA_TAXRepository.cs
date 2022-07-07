using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IFNA_TAXRepository : IRepositoryBase<FNA_TAX> { }

    public class FNA_TAXRepository : RepositoryBase<FNA_TAX>, IFNA_TAXRepository
    {
        private readonly IDBHelper _dbHelper;

        public FNA_TAXRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

