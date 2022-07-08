using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IFNA_COST_CENTERRepository : IRepositoryBase<FNA_COST_CENTER> { }

    public class FNA_COST_CENTERRepository : RepositoryBase<FNA_COST_CENTER>, IFNA_COST_CENTERRepository
    {
        private readonly IDBHelper _dbHelper;

        public FNA_COST_CENTERRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

