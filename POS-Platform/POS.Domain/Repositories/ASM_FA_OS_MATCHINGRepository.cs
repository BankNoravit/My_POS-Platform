using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using POS.Domain.Models;

namespace POS.Domain.Repositories
{
    public interface IASM_FA_OS_MATCHINGRepository : IRepositoryBase<ASM_FA_OS_MATCHING> { }

    public class ASM_FA_OS_MATCHINGRepository : RepositoryBase<ASM_FA_OS_MATCHING>, IASM_FA_OS_MATCHINGRepository
    {
        private readonly IDBHelper _dbHelper;

        public ASM_FA_OS_MATCHINGRepository(ReadWriteMainDBContext readWriteDBContext, ReadOnlyMainDBContext readOnlyDBContext)
            : base(readWriteDBContext, readOnlyDBContext) { this._dbHelper = new DBHelper(); }
    }
}

