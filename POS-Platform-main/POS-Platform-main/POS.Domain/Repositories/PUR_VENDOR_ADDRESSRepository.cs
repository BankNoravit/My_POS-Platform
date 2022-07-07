using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IPUR_VENDOR_ADDRESSRepository : IRepositoryBase<PUR_VENDOR_ADDRESS> { }

    public class PUR_VENDOR_ADDRESSRepository : RepositoryBase<PUR_VENDOR_ADDRESS>, IPUR_VENDOR_ADDRESSRepository
    {
        private readonly IDBHelper _dbHelper;

        public PUR_VENDOR_ADDRESSRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

