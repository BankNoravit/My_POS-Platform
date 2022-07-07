using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IPUR_PURCHASE_ORDERRepository : IRepositoryBase<PUR_PURCHASE_ORDER> { }

    public class PUR_PURCHASE_ORDERRepository : RepositoryBase<PUR_PURCHASE_ORDER>, IPUR_PURCHASE_ORDERRepository
    {
        private readonly IDBHelper _dbHelper;

        public PUR_PURCHASE_ORDERRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

