using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IFNA_CURRENCYRepository : IRepositoryBase<FNA_CURRENCY> { }

    public class FNA_CURRENCYRepository : RepositoryBase<FNA_CURRENCY>, IFNA_CURRENCYRepository
    {
        private readonly IDBHelper _dbHelper;

        public FNA_CURRENCYRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

