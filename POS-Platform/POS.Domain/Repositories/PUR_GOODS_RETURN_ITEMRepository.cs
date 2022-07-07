using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IPUR_GOODS_RETURN_ITEMRepository : IRepositoryBase<PUR_GOODS_RETURN_ITEM> { }

    public class PUR_GOODS_RETURN_ITEMRepository : RepositoryBase<PUR_GOODS_RETURN_ITEM>, IPUR_GOODS_RETURN_ITEMRepository
    {
        private readonly IDBHelper _dbHelper;

        public PUR_GOODS_RETURN_ITEMRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

