using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IPUR_VENDOR_CONTACTRepository : IRepositoryBase<PUR_VENDOR_CONTACT> { }

    public class PUR_VENDOR_CONTACTRepository : RepositoryBase<PUR_VENDOR_CONTACT>, IPUR_VENDOR_CONTACTRepository
    {
        private readonly IDBHelper _dbHelper;

        public PUR_VENDOR_CONTACTRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

