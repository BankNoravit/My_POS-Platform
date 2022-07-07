using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IPUR_PURCHASE_REQUISITION_ITEMRepository : IRepositoryBase<PUR_PURCHASE_REQUISITION_ITEM> { }

    public class PUR_PURCHASE_REQUISITION_ITEMRepository : RepositoryBase<PUR_PURCHASE_REQUISITION_ITEM>, IPUR_PURCHASE_REQUISITION_ITEMRepository
    {
        private readonly IDBHelper _dbHelper;

        public PUR_PURCHASE_REQUISITION_ITEMRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

