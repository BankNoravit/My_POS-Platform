using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IPUR_GOODS_RECEIPTRepository : IRepositoryBase<PUR_GOODS_RECEIPT> { }

    public class PUR_GOODS_RECEIPTRepository : RepositoryBase<PUR_GOODS_RECEIPT>, IPUR_GOODS_RECEIPTRepository
    {
        private readonly IDBHelper _dbHelper;

        public PUR_GOODS_RECEIPTRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

