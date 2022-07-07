using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IPUR_GOODS_RETURNRepository : IRepositoryBase<PUR_GOODS_RETURN> { }

    public class PUR_GOODS_RETURNRepository : RepositoryBase<PUR_GOODS_RETURN>, IPUR_GOODS_RETURNRepository
    {
        private readonly IDBHelper _dbHelper;

        public PUR_GOODS_RETURNRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

