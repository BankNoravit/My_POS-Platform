using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IPUR_GOODS_RECEIPT_ITEMRepository : IRepositoryBase<PUR_GOODS_RECEIPT_ITEM> { }

    public class PUR_GOODS_RECEIPT_ITEMRepository : RepositoryBase<PUR_GOODS_RECEIPT_ITEM>, IPUR_GOODS_RECEIPT_ITEMRepository
    {
        private readonly IDBHelper _dbHelper;

        public PUR_GOODS_RECEIPT_ITEMRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

