using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Common
{
    public class PARAM_JQUERY_DATATABLE
    {
        public PARAM_JQUERY_DATATABLE()
        {
            this.order = new List<PARAM_JQUERY_DATATABLE_ORDER>();
            this.columns = new List<PARAM_JQUERY_DATATABLE_COLUMN>();
        }

        public int draw { get; set; }
        public int start { get; set; }
        public int length { get; set; }
        public IDictionary<string, object> active_filters { get; set; }
        public IDictionary<string, ValueTuple<object, object>> active_range_filters { get; set; }
        public PARAM_JQUERY_DATATABLE_SEARCH search { get; set; }
        public List<PARAM_JQUERY_DATATABLE_ORDER> order { get; set; }
        public List<PARAM_JQUERY_DATATABLE_COLUMN> columns { get; set; }
    }

    #region [Sub Class Params]
    public class PARAM_JQUERY_DATATABLE_SEARCH
    {
        public string value { get; set; }
        public bool regex { get; set; }
    }

    public enum PARAM_JQUERY_DATATABLE_DIR
    {
        asc, desc
    }

    public class PARAM_JQUERY_DATATABLE_ORDER
    {
        public int column { get; set; }
        public PARAM_JQUERY_DATATABLE_DIR dir { get; set; }
    }

    public class PARAM_JQUERY_DATATABLE_COLUMN
    {
        public string data { get; set; }
        public string name { get; set; }
        public Boolean orderable { get; set; }
    }
    #endregion [Sub Class Params]
}
