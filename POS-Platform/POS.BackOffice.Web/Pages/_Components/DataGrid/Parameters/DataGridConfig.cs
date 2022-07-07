using POS.BackOffice.Web.Services;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Data;

namespace POS.BackOffice.Web.Pages.Components
{
    public class DataGridConfig
    {
        public string GridID { get; set; }
        public ODATA_ROUTE_NAME ODataRouteName { get; set; }
        public bool AllowPaging { get; set; }
        public bool AllowSorting { get; set; }
        public bool AllowReordering { get; set; }
        public bool AllowResizing { get; set; }
        public bool AllowFiltering { get; set; }
        public bool AllowGrouping { get; set; }
        public bool AllowGridEditing { get; set; }
        public bool AllowExcelExport { get; set; }
        public bool ShowColumnChooser { get; set; }

        public DataGridConfig()
        {
            this.AllowPaging = true;
            this.AllowSorting = true;
            this.AllowReordering = true;
            this.AllowResizing = true;
            this.AllowFiltering = false;
            this.AllowGrouping = false;
            this.AllowGridEditing = false;
            this.AllowExcelExport = true;
            this.ShowColumnChooser = true;
        }
    }
}