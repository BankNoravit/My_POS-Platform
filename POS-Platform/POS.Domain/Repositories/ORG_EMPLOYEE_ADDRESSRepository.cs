using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IORG_EMPLOYEE_ADDRESSRepository : IRepositoryBase<ORG_EMPLOYEE_ADDRESS> { }

    public class ORG_EMPLOYEE_ADDRESSRepository : RepositoryBase<ORG_EMPLOYEE_ADDRESS>, IORG_EMPLOYEE_ADDRESSRepository
    {
        private readonly IDBHelper _dbHelper;

        public ORG_EMPLOYEE_ADDRESSRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

