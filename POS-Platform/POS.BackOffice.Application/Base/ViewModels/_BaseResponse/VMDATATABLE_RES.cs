using System;
using System.Collections.Generic;
using System.Text;

namespace POS.ViewModels
{
    public class RESULT_JQUERY_DATATABLE<T>
    {
        public RESULT_JQUERY_DATATABLE()
        {   
            this.data = new List<T>();
        }

        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public IEnumerable<T> data { get; set; }
    }
}
