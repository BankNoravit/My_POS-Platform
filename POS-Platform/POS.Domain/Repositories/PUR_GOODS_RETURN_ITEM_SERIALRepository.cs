using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IPUR_GOODS_RETURN_ITEM_SERIALRepository : IRepositoryBase<PUR_GOODS_RETURN_ITEM_SERIAL> { }

    public class PUR_GOODS_RETURN_ITEM_SERIALRepository : RepositoryBase<PUR_GOODS_RETURN_ITEM_SERIAL>, IPUR_GOODS_RETURN_ITEM_SERIALRepository
    {
        private readonly IDBHelper _dbHelper;

        public PUR_GOODS_RETURN_ITEM_SERIALRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

