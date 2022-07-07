using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface ISA_PASSWORD_POLICYRepository : IRepositoryBase<SA_PASSWORD_POLICY> { }

    public class SA_PASSWORD_POLICYRepository : RepositoryBase<SA_PASSWORD_POLICY>, ISA_PASSWORD_POLICYRepository
    {
        private readonly IDBHelper _dbHelper;

        public SA_PASSWORD_POLICYRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

