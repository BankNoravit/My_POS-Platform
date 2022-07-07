using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IPUR_VENDORRepository : IRepositoryBase<PUR_VENDOR> { }

    public class PUR_VENDORRepository : RepositoryBase<PUR_VENDOR>, IPUR_VENDORRepository
    {
        private readonly IDBHelper _dbHelper;

        public PUR_VENDORRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

