using System;
using System.Collections.Generic;
using System.Text;

namespace POS.ViewModels
{
    public class VMBASE_RES_QUERY<T>
    {
        public VMBASE_RES_QUERY()
        { }

        public VMBASE_RES_QUERY(IQueryable result)
        {
            if (result != null)
                this.RESULT = result as IQueryable<T>;
        }

        public bool SUCCESS { get; init; } = default;
        public string? MESSAGE { get; init; } = default;
        public long? TOTAL_RECORD { get; init; } = 0;
        public IQueryable<T> RESULT { get; set; }
    }
}
