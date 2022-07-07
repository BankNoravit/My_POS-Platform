using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IPUR_PURCHASE_REQUISITION_ITEM_LOCATIONRepository : IRepositoryBase<PUR_PURCHASE_REQUISITION_ITEM_LOCATION> { }

    public class PUR_PURCHASE_REQUISITION_ITEM_LOCATIONRepository : RepositoryBase<PUR_PURCHASE_REQUISITION_ITEM_LOCATION>, IPUR_PURCHASE_REQUISITION_ITEM_LOCATIONRepository
    {
        private readonly IDBHelper _dbHelper;

        public PUR_PURCHASE_REQUISITION_ITEM_LOCATIONRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

